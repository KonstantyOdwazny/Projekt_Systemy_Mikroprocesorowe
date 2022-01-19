/* USER CODE BEGIN Header */
/**
  ******************************************************************************
  * @file           : main.c
  * @brief          : Main program body
  ******************************************************************************
  * @attention
  *
  * <h2><center>&copy; Copyright (c) 2021 STMicroelectronics.
  * All rights reserved.</center></h2>
  *
  * This software component is licensed by ST under BSD 3-Clause license,
  * the "License"; You may not use this file except in compliance with the
  * License. You may obtain a copy of the License at:
  *                        opensource.org/licenses/BSD-3-Clause
  *
  ******************************************************************************
  */
/* USER CODE END Header */
/* Includes ------------------------------------------------------------------*/
#include "main.h"
#include "adc.h"
#include "i2c.h"
#include "tim.h"
#include "usart.h"
#include "gpio.h"

/* Private includes ----------------------------------------------------------*/
/* USER CODE BEGIN Includes */
#include "stdio.h"
#include "string.h"
#include "bh1750.h"
#include "regulator.h"
#include "led.h"
#include "arm_math.h"
/* USER CODE END Includes */

/* Private typedef -----------------------------------------------------------*/
/* USER CODE BEGIN PTD */

/* USER CODE END PTD */

/* Private define ------------------------------------------------------------*/
/* USER CODE BEGIN PD */
/* USER CODE END PD */

/* Private macro -------------------------------------------------------------*/
/* USER CODE BEGIN PM */

/* USER CODE END PM */

/* Private variables ---------------------------------------------------------*/

/* USER CODE BEGIN PV */

/* USER CODE END PV */

/* Private function prototypes -----------------------------------------------*/
void SystemClock_Config(void);
/* USER CODE BEGIN PFP */

/* USER CODE END PFP */

/* Private user code ---------------------------------------------------------*/
/* USER CODE BEGIN 0 */

#define START 1
#define STOP 0

int akcja = 2;
int pulse = 0;

float wartosc_zadana = 130.0f;

float duty = 0.0f;
BH1750_HandleTypeDef hbh1750_1 = {
.I2C = &hi2c1, .Address = BH1750_ADDRESS_L, .Timeout = 0xffff};
regulator_Handle_TypeDef reg_I = {
   .Ki = 50.0f,.Kd=0.0f,.Kp = 0.0f, .Ts = 0.0007f, .e_int = 0.0f,.e_der = 0.0f,.e_prev = 0.0f, .limitdown = 0.0f, .limitup=100.0f};
LED_HandleTypeDef led = {
  .R = 1.0f, .G = 0.0f, .B = 1.0f, .duty_R=0.0f, .duty_G=0.0f, .duty_B=0.0f};

float LightIntensity = -0.1;
float LightIntensity_Fir = 0.0;
int light = -1;
char komunikat[20];

float led_R;
float led_G;
float led_B;
int pulseR=0,pulseG=0,pulseB=0;

char on[3];
char kolor[12];
char erros[50] = "Zly wzor lub wartosc poza zakresem!";

arm_fir_instance_f32 AnalogInFir;

    #define FirNumTaps 58
    float32_t FirB[FirNumTaps]={
#include "fir_b.csv"
    		};
    float32_t FirX[FirNumTaps]={
#include "fir_state_init.csv"
    		};



void HAL_UART_RxCpltCallback(UART_HandleTypeDef* huart)
{
	if(huart->Instance == USART3)
	{
		if(kolor[0]=='R' && kolor[4]=='G' && kolor[8]=='B' )
		{
		  sscanf(kolor,"R%dG%dB%d",&pulseR,&pulseG,&pulseB);
		  if(pulseR >=0 && pulseR <=100)
		  {
			  led.R = (float)(pulseR/100.0f);

			  //HAL_UART_Receive_IT(&huart3, (uint8_t*)on, 3);
		  }
		  if(pulseG >=0 && pulseG <=100)
		  {
		  	  led.G = (float)(pulseG/100.0f);

		  	  //HAL_UART_Receive_IT(&huart3, (uint8_t*)on, 3);
		  }
		  if(pulseB >=0 && pulseB <=100)
		  {
		  	  led.B = (float)(pulseB/100.0f);

		  	  //HAL_UART_Receive_IT(&huart3, (uint8_t*)on, 3);
		  }
		  HAL_UART_Receive_IT(&huart3, (uint8_t*)on, 3);

		}
		else
		{
			HAL_UART_Transmit(huart, erros, strlen(erros), 1000);
		}


		if(on[0] == 'O' && on[1] == 'N')
		{
		  sscanf(on,"ON%d",&akcja);
		  HAL_UART_Receive_IT(&huart3, (uint8_t*)on, 3);
		}

	}
}

void HAL_TIM_PeriodElapsedCallback(TIM_HandleTypeDef *htim)
{
	if(htim->Instance == TIM2)
	{
//		if(pulse < 1000)
//		{
//			pulse+=100;
//			__HAL_TIM_SET_COMPARE(&htim3,TIM_CHANNEL_2,pulse);
//			__HAL_TIM_SET_COMPARE(&htim3,TIM_CHANNEL_1,pulse);
//		}
//		else
//		{
//			pulse=0;
//			__HAL_TIM_SET_COMPARE(&htim3,TIM_CHANNEL_2,pulse);
//			__HAL_TIM_SET_COMPARE(&htim3,TIM_CHANNEL_1,pulse);
//		}

		if(akcja == START)
		{
		LightIntensity = BH1750_ReadLux(&hbh1750_1);
		arm_fir_f32(&AnalogInFir,&LightIntensity,&LightIntensity_Fir,1);
		light = LightIntensity_Fir*100;

		sprintf(komunikat,"%d.%d\r\n",light/100,light%100);
		HAL_UART_Transmit(&huart3, komunikat, strlen(komunikat), 1000);
		duty = Reg_SignalControl(&reg_I, wartosc_zadana, LightIntensity);
		ColorsGenerator(&led, duty);


		__HAL_TIM_SET_COMPARE(&htim3,TIM_CHANNEL_1,(uint32_t)((led.duty_R)*10));
		__HAL_TIM_SET_COMPARE(&htim3,TIM_CHANNEL_2,(uint32_t)((led.duty_G)*10));
		__HAL_TIM_SET_COMPARE(&htim3,TIM_CHANNEL_3,(uint32_t)((led.duty_B)*10));
		}
		else if(akcja == STOP)
		{
			led.duty_R = 0.0f;
			led.duty_G = 0.0f;
			led.duty_B = 0.0f;
			duty = 0.0f;
			__HAL_TIM_SET_COMPARE(&htim3,TIM_CHANNEL_1,(uint32_t)((led.duty_R)*10));
			__HAL_TIM_SET_COMPARE(&htim3,TIM_CHANNEL_2,(uint32_t)((led.duty_G)*10));
			__HAL_TIM_SET_COMPARE(&htim3,TIM_CHANNEL_3,(uint32_t)((led.duty_B)*10));

		}


	}

}




/* USER CODE END 0 */

/**
  * @brief  The application entry point.
  * @retval int
  */
int main(void)
{
  /* USER CODE BEGIN 1 */

  /* USER CODE END 1 */

  /* MCU Configuration--------------------------------------------------------*/

  /* Reset of all peripherals, Initializes the Flash interface and the Systick. */
  HAL_Init();

  /* USER CODE BEGIN Init */

  /* USER CODE END Init */

  /* Configure the system clock */
  SystemClock_Config();

  /* USER CODE BEGIN SysInit */

  /* USER CODE END SysInit */

  /* Initialize all configured peripherals */
  MX_GPIO_Init();
  MX_USART3_UART_Init();
  MX_ADC1_Init();
  MX_TIM3_Init();
  MX_TIM2_Init();
  MX_I2C1_Init();
  /* USER CODE BEGIN 2 */

  //Inicjalizacja
   arm_fir_init_f32(&AnalogInFir, FirNumTaps, FirB,FirX,1);
   uint8_t TrybPracy = BH1750_CONTINOUS_H_RES_MODE;
   BH1750_Init(&hbh1750_1, TrybPracy);
   HAL_TIM_PWM_Start(&htim3,TIM_CHANNEL_1);
   HAL_TIM_PWM_Start(&htim3,TIM_CHANNEL_2);
   HAL_TIM_PWM_Start(&htim3,TIM_CHANNEL_3);
   HAL_TIM_Base_Start_IT(&htim2);

   char witaj[120] = "Wybierz kolor(wzor: R<000 lub 100>G<000 lub 100>B<000 lub 100>) i nastepnie wlacz uklad (ON lub OF)\r\n";
   HAL_UART_Transmit(&huart3,witaj,strlen(witaj),1000);
   HAL_UART_Receive_IT(&huart3, (uint8_t*)kolor, 12);
  // Koniec inicjalizacji






  /* USER CODE END 2 */

  /* Infinite loop */
  /* USER CODE BEGIN WHILE */
  while (1)
  {

    /* USER CODE END WHILE */

    /* USER CODE BEGIN 3 */
  }
  /* USER CODE END 3 */
}

/**
  * @brief System Clock Configuration
  * @retval None
  */
void SystemClock_Config(void)
{
  RCC_OscInitTypeDef RCC_OscInitStruct = {0};
  RCC_ClkInitTypeDef RCC_ClkInitStruct = {0};
  RCC_PeriphCLKInitTypeDef PeriphClkInitStruct = {0};

  /** Configure LSE Drive Capability
  */
  HAL_PWR_EnableBkUpAccess();
  /** Configure the main internal regulator output voltage
  */
  __HAL_RCC_PWR_CLK_ENABLE();
  __HAL_PWR_VOLTAGESCALING_CONFIG(PWR_REGULATOR_VOLTAGE_SCALE1);
  /** Initializes the RCC Oscillators according to the specified parameters
  * in the RCC_OscInitTypeDef structure.
  */
  RCC_OscInitStruct.OscillatorType = RCC_OSCILLATORTYPE_HSE;
  RCC_OscInitStruct.HSEState = RCC_HSE_BYPASS;
  RCC_OscInitStruct.PLL.PLLState = RCC_PLL_ON;
  RCC_OscInitStruct.PLL.PLLSource = RCC_PLLSOURCE_HSE;
  RCC_OscInitStruct.PLL.PLLM = 4;
  RCC_OscInitStruct.PLL.PLLN = 216;
  RCC_OscInitStruct.PLL.PLLP = RCC_PLLP_DIV2;
  RCC_OscInitStruct.PLL.PLLQ = 4;
  RCC_OscInitStruct.PLL.PLLR = 2;
  if (HAL_RCC_OscConfig(&RCC_OscInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
  /** Activate the Over-Drive mode
  */
  if (HAL_PWREx_EnableOverDrive() != HAL_OK)
  {
    Error_Handler();
  }
  /** Initializes the CPU, AHB and APB buses clocks
  */
  RCC_ClkInitStruct.ClockType = RCC_CLOCKTYPE_HCLK|RCC_CLOCKTYPE_SYSCLK
                              |RCC_CLOCKTYPE_PCLK1|RCC_CLOCKTYPE_PCLK2;
  RCC_ClkInitStruct.SYSCLKSource = RCC_SYSCLKSOURCE_PLLCLK;
  RCC_ClkInitStruct.AHBCLKDivider = RCC_SYSCLK_DIV1;
  RCC_ClkInitStruct.APB1CLKDivider = RCC_HCLK_DIV4;
  RCC_ClkInitStruct.APB2CLKDivider = RCC_HCLK_DIV2;

  if (HAL_RCC_ClockConfig(&RCC_ClkInitStruct, FLASH_LATENCY_7) != HAL_OK)
  {
    Error_Handler();
  }
  PeriphClkInitStruct.PeriphClockSelection = RCC_PERIPHCLK_USART3|RCC_PERIPHCLK_I2C1;
  PeriphClkInitStruct.Usart3ClockSelection = RCC_USART3CLKSOURCE_PCLK1;
  PeriphClkInitStruct.I2c1ClockSelection = RCC_I2C1CLKSOURCE_PCLK1;
  if (HAL_RCCEx_PeriphCLKConfig(&PeriphClkInitStruct) != HAL_OK)
  {
    Error_Handler();
  }
}

/* USER CODE BEGIN 4 */

/* USER CODE END 4 */

/**
  * @brief  This function is executed in case of error occurrence.
  * @retval None
  */
void Error_Handler(void)
{
  /* USER CODE BEGIN Error_Handler_Debug */
  /* User can add his own implementation to report the HAL error return state */
  __disable_irq();
  while (1)
  {
  }
  /* USER CODE END Error_Handler_Debug */
}

#ifdef  USE_FULL_ASSERT
/**
  * @brief  Reports the name of the source file and the source line number
  *         where the assert_param error has occurred.
  * @param  file: pointer to the source file name
  * @param  line: assert_param error line source number
  * @retval None
  */
void assert_failed(uint8_t *file, uint32_t line)
{
  /* USER CODE BEGIN 6 */
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */
  /* USER CODE END 6 */
}
#endif /* USE_FULL_ASSERT */

/************************ (C) COPYRIGHT STMicroelectronics *****END OF FILE****/
