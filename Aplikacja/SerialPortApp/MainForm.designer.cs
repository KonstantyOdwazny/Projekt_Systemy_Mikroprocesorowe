namespace SerialPortApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.portNameLabel = new System.Windows.Forms.Label();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.serialSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
            this.parityComboBox = new System.Windows.Forms.ComboBox();
            this.portNameComboBox = new System.Windows.Forms.ComboBox();
            this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox_settings = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbDataReceive = new System.Windows.Forms.TextBox();
            this.groupBox_receive = new System.Windows.Forms.GroupBox();
            this.rxEnableCheckBox = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox_transmit = new System.Windows.Forms.GroupBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbDataTransmit = new System.Windows.Forms.TextBox();
            this.groupBox_exceptions = new System.Windows.Forms.GroupBox();
            this.btnClearError = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabSerialPort = new System.Windows.Forms.TabPage();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabPage();
            this.btn_TurnON = new System.Windows.Forms.Button();
            this.btn_TurnOFF = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.BlueValue = new System.Windows.Forms.TextBox();
            this.GreenValue = new System.Windows.Forms.TextBox();
            this.RedValue = new System.Windows.Forms.TextBox();
            this.Y_Value = new System.Windows.Forms.TextBox();
            this.BlueTrackbar = new System.Windows.Forms.TrackBar();
            this.GreenTrackbar = new System.Windows.Forms.TrackBar();
            this.RedTrackbar = new System.Windows.Forms.TrackBar();
            this.Y_referenceTrackbar = new System.Windows.Forms.TrackBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).BeginInit();
            this.groupBox_settings.SuspendLayout();
            this.groupBox_receive.SuspendLayout();
            this.groupBox_transmit.SuspendLayout();
            this.groupBox_exceptions.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabSerialPort.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_referenceTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Location = new System.Drawing.Point(10, 59);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(61, 13);
            this.baudRateLabel.TabIndex = 1;
            this.baudRateLabel.Text = "Baud Rate:";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Location = new System.Drawing.Point(10, 86);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(53, 13);
            this.dataBitsLabel.TabIndex = 3;
            this.dataBitsLabel.Text = "Data Bits:";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Location = new System.Drawing.Point(10, 113);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(36, 13);
            this.parityLabel.TabIndex = 5;
            this.parityLabel.Text = "Parity:";
            // 
            // portNameLabel
            // 
            this.portNameLabel.AutoSize = true;
            this.portNameLabel.Location = new System.Drawing.Point(10, 32);
            this.portNameLabel.Name = "portNameLabel";
            this.portNameLabel.Size = new System.Drawing.Size(60, 13);
            this.portNameLabel.TabIndex = 7;
            this.portNameLabel.Text = "Port Name:";
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Location = new System.Drawing.Point(10, 140);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(52, 13);
            this.stopBitsLabel.TabIndex = 9;
            this.stopBitsLabel.Text = "Stop Bits:";
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "BaudRate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(77, 56);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(153, 21);
            this.baudRateComboBox.TabIndex = 2;
            // 
            // dataBitsComboBox
            // 
            this.dataBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "DataBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dataBitsComboBox.FormattingEnabled = true;
            this.dataBitsComboBox.Location = new System.Drawing.Point(77, 83);
            this.dataBitsComboBox.Name = "dataBitsComboBox";
            this.dataBitsComboBox.Size = new System.Drawing.Size(153, 21);
            this.dataBitsComboBox.TabIndex = 4;
            // 
            // parityComboBox
            // 
            this.parityComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "Parity", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.parityComboBox.FormattingEnabled = true;
            this.parityComboBox.Location = new System.Drawing.Point(77, 110);
            this.parityComboBox.Name = "parityComboBox";
            this.parityComboBox.Size = new System.Drawing.Size(153, 21);
            this.parityComboBox.TabIndex = 6;
            // 
            // portNameComboBox
            // 
            this.portNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "PortName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.portNameComboBox.FormattingEnabled = true;
            this.portNameComboBox.Location = new System.Drawing.Point(77, 29);
            this.portNameComboBox.Name = "portNameComboBox";
            this.portNameComboBox.Size = new System.Drawing.Size(153, 21);
            this.portNameComboBox.TabIndex = 8;
            // 
            // stopBitsComboBox
            // 
            this.stopBitsComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.serialSettingsBindingSource, "StopBits", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.stopBitsComboBox.FormattingEnabled = true;
            this.stopBitsComboBox.Location = new System.Drawing.Point(77, 137);
            this.stopBitsComboBox.Name = "stopBitsComboBox";
            this.stopBitsComboBox.Size = new System.Drawing.Size(153, 21);
            this.stopBitsComboBox.TabIndex = 10;
            // 
            // groupBox_settings
            // 
            this.groupBox_settings.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_settings.Controls.Add(this.baudRateComboBox);
            this.groupBox_settings.Controls.Add(this.btnStop);
            this.groupBox_settings.Controls.Add(this.baudRateLabel);
            this.groupBox_settings.Controls.Add(this.btnStart);
            this.groupBox_settings.Controls.Add(this.stopBitsComboBox);
            this.groupBox_settings.Controls.Add(this.stopBitsLabel);
            this.groupBox_settings.Controls.Add(this.dataBitsLabel);
            this.groupBox_settings.Controls.Add(this.portNameComboBox);
            this.groupBox_settings.Controls.Add(this.dataBitsComboBox);
            this.groupBox_settings.Controls.Add(this.portNameLabel);
            this.groupBox_settings.Controls.Add(this.parityLabel);
            this.groupBox_settings.Controls.Add(this.parityComboBox);
            this.groupBox_settings.Location = new System.Drawing.Point(8, 6);
            this.groupBox_settings.Name = "groupBox_settings";
            this.groupBox_settings.Size = new System.Drawing.Size(244, 200);
            this.groupBox_settings.TabIndex = 11;
            this.groupBox_settings.TabStop = false;
            this.groupBox_settings.Text = "Serial Port Settings";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(157, 164);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 23);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Disconnect";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(77, 164);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(74, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Connect";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // tbDataReceive
            // 
            this.tbDataReceive.Location = new System.Drawing.Point(273, 19);
            this.tbDataReceive.Multiline = true;
            this.tbDataReceive.Name = "tbDataReceive";
            this.tbDataReceive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDataReceive.Size = new System.Drawing.Size(232, 97);
            this.tbDataReceive.TabIndex = 13;
            // 
            // groupBox_receive
            // 
            this.groupBox_receive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_receive.Controls.Add(this.rxEnableCheckBox);
            this.groupBox_receive.Controls.Add(this.btnClear);
            this.groupBox_receive.Controls.Add(this.tbDataReceive);
            this.groupBox_receive.Location = new System.Drawing.Point(9, 212);
            this.groupBox_receive.Name = "groupBox_receive";
            this.groupBox_receive.Size = new System.Drawing.Size(511, 151);
            this.groupBox_receive.TabIndex = 14;
            this.groupBox_receive.TabStop = false;
            this.groupBox_receive.Text = "Receive";
            // 
            // rxEnableCheckBox
            // 
            this.rxEnableCheckBox.AutoSize = true;
            this.rxEnableCheckBox.Checked = true;
            this.rxEnableCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rxEnableCheckBox.Location = new System.Drawing.Point(273, 121);
            this.rxEnableCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.rxEnableCheckBox.Name = "rxEnableCheckBox";
            this.rxEnableCheckBox.Size = new System.Drawing.Size(75, 17);
            this.rxEnableCheckBox.TabIndex = 15;
            this.rxEnableCheckBox.Text = "Rx Enable";
            this.rxEnableCheckBox.UseVisualStyleBackColor = true;
            this.rxEnableCheckBox.CheckedChanged += new System.EventHandler(this.RxEnableCheckBox_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(419, 121);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // groupBox_transmit
            // 
            this.groupBox_transmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_transmit.Controls.Add(this.btnSend);
            this.groupBox_transmit.Controls.Add(this.tbDataTransmit);
            this.groupBox_transmit.Location = new System.Drawing.Point(8, 369);
            this.groupBox_transmit.Name = "groupBox_transmit";
            this.groupBox_transmit.Size = new System.Drawing.Size(511, 72);
            this.groupBox_transmit.TabIndex = 15;
            this.groupBox_transmit.TabStop = false;
            this.groupBox_transmit.Text = "Transmit";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(420, 43);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(85, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // tbDataTransmit
            // 
            this.tbDataTransmit.Location = new System.Drawing.Point(12, 19);
            this.tbDataTransmit.Name = "tbDataTransmit";
            this.tbDataTransmit.Size = new System.Drawing.Size(494, 20);
            this.tbDataTransmit.TabIndex = 0;
            // 
            // groupBox_exceptions
            // 
            this.groupBox_exceptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_exceptions.Controls.Add(this.btnClearError);
            this.groupBox_exceptions.Controls.Add(this.error_label);
            this.groupBox_exceptions.Location = new System.Drawing.Point(258, 6);
            this.groupBox_exceptions.Name = "groupBox_exceptions";
            this.groupBox_exceptions.Size = new System.Drawing.Size(261, 200);
            this.groupBox_exceptions.TabIndex = 16;
            this.groupBox_exceptions.TabStop = false;
            this.groupBox_exceptions.Text = "Exceptions";
            // 
            // btnClearError
            // 
            this.btnClearError.Location = new System.Drawing.Point(171, 164);
            this.btnClearError.Name = "btnClearError";
            this.btnClearError.Size = new System.Drawing.Size(74, 23);
            this.btnClearError.TabIndex = 13;
            this.btnClearError.Text = "Clear error";
            this.btnClearError.UseVisualStyleBackColor = true;
            this.btnClearError.Click += new System.EventHandler(this.BtnClearError_Click);
            // 
            // error_label
            // 
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(17, 29);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(228, 124);
            this.error_label.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabSerialPort);
            this.tabMain.Controls.Add(this.tabInput);
            this.tabMain.Controls.Add(this.tabControl);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(532, 472);
            this.tabMain.TabIndex = 17;
            // 
            // tabSerialPort
            // 
            this.tabSerialPort.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tabSerialPort.Controls.Add(this.groupBox_settings);
            this.tabSerialPort.Controls.Add(this.groupBox_exceptions);
            this.tabSerialPort.Controls.Add(this.groupBox_transmit);
            this.tabSerialPort.Controls.Add(this.groupBox_receive);
            this.tabSerialPort.Location = new System.Drawing.Point(4, 22);
            this.tabSerialPort.Name = "tabSerialPort";
            this.tabSerialPort.Padding = new System.Windows.Forms.Padding(3);
            this.tabSerialPort.Size = new System.Drawing.Size(524, 446);
            this.tabSerialPort.TabIndex = 0;
            this.tabSerialPort.Text = "Serial Port";
            // 
            // tabInput
            // 
            this.tabInput.Location = new System.Drawing.Point(4, 22);
            this.tabInput.Margin = new System.Windows.Forms.Padding(2);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(2);
            this.tabInput.Size = new System.Drawing.Size(524, 446);
            this.tabInput.TabIndex = 1;
            this.tabInput.Text = "Input plot";
            this.tabInput.UseVisualStyleBackColor = true;
            this.tabInput.Click += new System.EventHandler(this.tabInput_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.btn_TurnON);
            this.tabControl.Controls.Add(this.btn_TurnOFF);
            this.tabControl.Controls.Add(this.btn_Update);
            this.tabControl.Controls.Add(this.BlueValue);
            this.tabControl.Controls.Add(this.GreenValue);
            this.tabControl.Controls.Add(this.RedValue);
            this.tabControl.Controls.Add(this.Y_Value);
            this.tabControl.Controls.Add(this.BlueTrackbar);
            this.tabControl.Controls.Add(this.GreenTrackbar);
            this.tabControl.Controls.Add(this.RedTrackbar);
            this.tabControl.Controls.Add(this.Y_referenceTrackbar);
            this.tabControl.Location = new System.Drawing.Point(4, 22);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Windows.Forms.Padding(2);
            this.tabControl.Size = new System.Drawing.Size(524, 446);
            this.tabControl.TabIndex = 2;
            this.tabControl.Text = "Output control";
            this.tabControl.UseVisualStyleBackColor = true;
            // 
            // btn_TurnON
            // 
            this.btn_TurnON.Location = new System.Drawing.Point(18, 282);
            this.btn_TurnON.Name = "btn_TurnON";
            this.btn_TurnON.Size = new System.Drawing.Size(75, 23);
            this.btn_TurnON.TabIndex = 10;
            this.btn_TurnON.Text = "ON";
            this.btn_TurnON.UseVisualStyleBackColor = true;
            this.btn_TurnON.Click += new System.EventHandler(this.btn_TurnON_Click);
            // 
            // btn_TurnOFF
            // 
            this.btn_TurnOFF.Location = new System.Drawing.Point(18, 311);
            this.btn_TurnOFF.Name = "btn_TurnOFF";
            this.btn_TurnOFF.Size = new System.Drawing.Size(75, 23);
            this.btn_TurnOFF.TabIndex = 9;
            this.btn_TurnOFF.Text = "OFF";
            this.btn_TurnOFF.UseVisualStyleBackColor = true;
            this.btn_TurnOFF.Click += new System.EventHandler(this.btn_TurnOFF_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(18, 253);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 8;
            this.btn_Update.Text = "Send";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // BlueValue
            // 
            this.BlueValue.Enabled = false;
            this.BlueValue.Location = new System.Drawing.Point(332, 198);
            this.BlueValue.Name = "BlueValue";
            this.BlueValue.ReadOnly = true;
            this.BlueValue.Size = new System.Drawing.Size(50, 20);
            this.BlueValue.TabIndex = 7;
            this.BlueValue.Text = "0";
            // 
            // GreenValue
            // 
            this.GreenValue.Enabled = false;
            this.GreenValue.Location = new System.Drawing.Point(333, 147);
            this.GreenValue.Name = "GreenValue";
            this.GreenValue.ReadOnly = true;
            this.GreenValue.Size = new System.Drawing.Size(49, 20);
            this.GreenValue.TabIndex = 6;
            this.GreenValue.Text = "0";
            // 
            // RedValue
            // 
            this.RedValue.Enabled = false;
            this.RedValue.Location = new System.Drawing.Point(333, 96);
            this.RedValue.Name = "RedValue";
            this.RedValue.ReadOnly = true;
            this.RedValue.Size = new System.Drawing.Size(49, 20);
            this.RedValue.TabIndex = 5;
            this.RedValue.Text = "0";
            // 
            // Y_Value
            // 
            this.Y_Value.Enabled = false;
            this.Y_Value.Location = new System.Drawing.Point(333, 44);
            this.Y_Value.Name = "Y_Value";
            this.Y_Value.ReadOnly = true;
            this.Y_Value.Size = new System.Drawing.Size(49, 20);
            this.Y_Value.TabIndex = 4;
            this.Y_Value.Text = "0";
            // 
            // BlueTrackbar
            // 
            this.BlueTrackbar.BackColor = System.Drawing.Color.Navy;
            this.BlueTrackbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.BlueTrackbar.Location = new System.Drawing.Point(18, 173);
            this.BlueTrackbar.Maximum = 100;
            this.BlueTrackbar.Name = "BlueTrackbar";
            this.BlueTrackbar.Size = new System.Drawing.Size(308, 45);
            this.BlueTrackbar.SmallChange = 5;
            this.BlueTrackbar.TabIndex = 3;
            this.BlueTrackbar.TickFrequency = 5;
            this.BlueTrackbar.Scroll += new System.EventHandler(this.BlueTrackbar_Scroll);
            // 
            // GreenTrackbar
            // 
            this.GreenTrackbar.BackColor = System.Drawing.Color.Green;
            this.GreenTrackbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.GreenTrackbar.Location = new System.Drawing.Point(18, 122);
            this.GreenTrackbar.Maximum = 100;
            this.GreenTrackbar.Name = "GreenTrackbar";
            this.GreenTrackbar.Size = new System.Drawing.Size(308, 45);
            this.GreenTrackbar.SmallChange = 5;
            this.GreenTrackbar.TabIndex = 2;
            this.GreenTrackbar.TickFrequency = 5;
            this.GreenTrackbar.Scroll += new System.EventHandler(this.GreenTrackbar_Scroll);
            // 
            // RedTrackbar
            // 
            this.RedTrackbar.BackColor = System.Drawing.Color.Maroon;
            this.RedTrackbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.RedTrackbar.Location = new System.Drawing.Point(18, 71);
            this.RedTrackbar.Maximum = 100;
            this.RedTrackbar.Name = "RedTrackbar";
            this.RedTrackbar.Size = new System.Drawing.Size(308, 45);
            this.RedTrackbar.SmallChange = 5;
            this.RedTrackbar.TabIndex = 1;
            this.RedTrackbar.TickFrequency = 5;
            this.RedTrackbar.Scroll += new System.EventHandler(this.RedTrackbar_Scroll);
            // 
            // Y_referenceTrackbar
            // 
            this.Y_referenceTrackbar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Y_referenceTrackbar.Cursor = System.Windows.Forms.Cursors.Default;
            this.Y_referenceTrackbar.Location = new System.Drawing.Point(18, 20);
            this.Y_referenceTrackbar.Maximum = 100;
            this.Y_referenceTrackbar.Name = "Y_referenceTrackbar";
            this.Y_referenceTrackbar.Size = new System.Drawing.Size(308, 45);
            this.Y_referenceTrackbar.SmallChange = 5;
            this.Y_referenceTrackbar.TabIndex = 0;
            this.Y_referenceTrackbar.TickFrequency = 5;
            this.Y_referenceTrackbar.Scroll += new System.EventHandler(this.Y_referenceTrackbar_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(532, 472);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "C# Serial Port App";
            ((System.ComponentModel.ISupportInitialize)(this.serialSettingsBindingSource)).EndInit();
            this.groupBox_settings.ResumeLayout(false);
            this.groupBox_settings.PerformLayout();
            this.groupBox_receive.ResumeLayout(false);
            this.groupBox_receive.PerformLayout();
            this.groupBox_transmit.ResumeLayout(false);
            this.groupBox_transmit.PerformLayout();
            this.groupBox_exceptions.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabSerialPort.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BlueTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_referenceTrackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource serialSettingsBindingSource;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox dataBitsComboBox;
        private System.Windows.Forms.ComboBox parityComboBox;
        private System.Windows.Forms.ComboBox portNameComboBox;
        private System.Windows.Forms.ComboBox stopBitsComboBox;
        private System.Windows.Forms.GroupBox groupBox_settings;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox tbDataReceive;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.Label portNameLabel;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.GroupBox groupBox_receive;
        private System.Windows.Forms.GroupBox groupBox_transmit;
        private System.Windows.Forms.TextBox tbDataTransmit;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.GroupBox groupBox_exceptions;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabSerialPort;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.TabPage tabControl;
        private System.Windows.Forms.CheckBox rxEnableCheckBox;
        private System.Windows.Forms.Button btnClearError;
        private System.Windows.Forms.TrackBar Y_referenceTrackbar;
        private System.Windows.Forms.TextBox BlueValue;
        private System.Windows.Forms.TextBox GreenValue;
        private System.Windows.Forms.TextBox RedValue;
        private System.Windows.Forms.TextBox Y_Value;
        private System.Windows.Forms.TrackBar BlueTrackbar;
        private System.Windows.Forms.TrackBar GreenTrackbar;
        private System.Windows.Forms.TrackBar RedTrackbar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_TurnON;
        private System.Windows.Forms.Button btn_TurnOFF;
    }
}

