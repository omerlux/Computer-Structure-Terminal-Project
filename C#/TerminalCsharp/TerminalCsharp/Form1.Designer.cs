namespace TerminalCsharp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.BaudRateBox = new System.Windows.Forms.ComboBox();
            this.Baud = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StopBitBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ParityBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.COMbox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.TestConnection = new System.Windows.Forms.Button();
            this.GroupBoxConnection = new System.Windows.Forms.GroupBox();
            this.GroupBoxCommands = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CommandsBox = new System.Windows.Forms.TextBox();
            this.GroupBoxChat = new System.Windows.Forms.GroupBox();
            this.CountLabel = new System.Windows.Forms.Label();
            this.ChatBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.GroupBoxFile = new System.Windows.Forms.GroupBox();
            this.SendByte = new System.Windows.Forms.Button();
            this.ReciveButton = new System.Windows.Forms.Button();
            this.DisplayContext = new System.Windows.Forms.Button();
            this.SendFileButton = new System.Windows.Forms.Button();
            this.ChosenFileLabel = new System.Windows.Forms.Label();
            this.FilePicker = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBoxConnection.SuspendLayout();
            this.GroupBoxCommands.SuspendLayout();
            this.GroupBoxChat.SuspendLayout();
            this.GroupBoxFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Imprint MT Shadow", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(221, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 69);
            this.label3.TabIndex = 0;
            this.label3.Text = "Terminal Emmanuer";
            // 
            // BaudRateBox
            // 
            this.BaudRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudRateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BaudRateBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.BaudRateBox.FormattingEnabled = true;
            this.BaudRateBox.Items.AddRange(new object[] {
            "2400",
            "9600",
            "19200",
            "38400"});
            this.BaudRateBox.Location = new System.Drawing.Point(166, 53);
            this.BaudRateBox.Name = "BaudRateBox";
            this.BaudRateBox.Size = new System.Drawing.Size(121, 24);
            this.BaudRateBox.TabIndex = 1;
            this.BaudRateBox.SelectedIndexChanged += new System.EventHandler(this.BaudRateBox_SelectedIndexChanged);
            // 
            // Baud
            // 
            this.Baud.AccessibleName = "Baud Rate:";
            this.Baud.AutoSize = true;
            this.Baud.Cursor = System.Windows.Forms.Cursors.Default;
            this.Baud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Baud.ForeColor = System.Drawing.Color.Snow;
            this.Baud.Location = new System.Drawing.Point(6, 49);
            this.Baud.Name = "Baud";
            this.Baud.Size = new System.Drawing.Size(109, 25);
            this.Baud.TabIndex = 2;
            this.Baud.Text = "Baud Rate:";
            // 
            // label4
            // 
            this.label4.AccessibleName = "Baud Rate:";
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop bit:";
            // 
            // StopBitBox
            // 
            this.StopBitBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StopBitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StopBitBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.StopBitBox.FormattingEnabled = true;
            this.StopBitBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.StopBitBox.Location = new System.Drawing.Point(166, 80);
            this.StopBitBox.Name = "StopBitBox";
            this.StopBitBox.Size = new System.Drawing.Size(121, 24);
            this.StopBitBox.TabIndex = 4;
            this.StopBitBox.SelectedIndexChanged += new System.EventHandler(this.StopBitBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AccessibleName = "Baud Rate:";
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parity:";
            // 
            // ParityBox
            // 
            this.ParityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ParityBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.ParityBox.FormattingEnabled = true;
            this.ParityBox.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd"});
            this.ParityBox.Location = new System.Drawing.Point(166, 108);
            this.ParityBox.Name = "ParityBox";
            this.ParityBox.Size = new System.Drawing.Size(121, 24);
            this.ParityBox.TabIndex = 6;
            this.ParityBox.SelectedIndexChanged += new System.EventHandler(this.ParityBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AccessibleName = "Baud Rate:";
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(7, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "COM:";
            // 
            // COMbox
            // 
            this.COMbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.COMbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.COMbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.COMbox.FormattingEnabled = true;
            this.COMbox.Location = new System.Drawing.Point(166, 135);
            this.COMbox.Name = "COMbox";
            this.COMbox.Size = new System.Drawing.Size(121, 24);
            this.COMbox.TabIndex = 9;
            this.COMbox.SelectedIndexChanged += new System.EventHandler(this.COMbox_SelectedIndexChanged);
            this.COMbox.Click += new System.EventHandler(this.COMbox_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Enabled = false;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpdateButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.UpdateButton.Location = new System.Drawing.Point(11, 190);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(135, 23);
            this.UpdateButton.TabIndex = 10;
            this.UpdateButton.Text = "Update Connection";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TestConnection
            // 
            this.TestConnection.Enabled = false;
            this.TestConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TestConnection.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.TestConnection.Location = new System.Drawing.Point(166, 190);
            this.TestConnection.Name = "TestConnection";
            this.TestConnection.Size = new System.Drawing.Size(121, 23);
            this.TestConnection.TabIndex = 11;
            this.TestConnection.Text = "Test Connection";
            this.TestConnection.UseVisualStyleBackColor = true;
            this.TestConnection.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GroupBoxConnection
            // 
            this.GroupBoxConnection.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxConnection.Controls.Add(this.BaudRateBox);
            this.GroupBoxConnection.Controls.Add(this.TestConnection);
            this.GroupBoxConnection.Controls.Add(this.Baud);
            this.GroupBoxConnection.Controls.Add(this.label7);
            this.GroupBoxConnection.Controls.Add(this.UpdateButton);
            this.GroupBoxConnection.Controls.Add(this.label4);
            this.GroupBoxConnection.Controls.Add(this.COMbox);
            this.GroupBoxConnection.Controls.Add(this.StopBitBox);
            this.GroupBoxConnection.Controls.Add(this.label5);
            this.GroupBoxConnection.Controls.Add(this.ParityBox);
            this.GroupBoxConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GroupBoxConnection.ForeColor = System.Drawing.Color.Snow;
            this.GroupBoxConnection.Location = new System.Drawing.Point(12, 113);
            this.GroupBoxConnection.Name = "GroupBoxConnection";
            this.GroupBoxConnection.Size = new System.Drawing.Size(293, 241);
            this.GroupBoxConnection.TabIndex = 13;
            this.GroupBoxConnection.TabStop = false;
            this.GroupBoxConnection.Text = "Connection Setup";
            // 
            // GroupBoxCommands
            // 
            this.GroupBoxCommands.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxCommands.Controls.Add(this.label11);
            this.GroupBoxCommands.Controls.Add(this.label10);
            this.GroupBoxCommands.Controls.Add(this.label9);
            this.GroupBoxCommands.Controls.Add(this.label6);
            this.GroupBoxCommands.Controls.Add(this.CommandsBox);
            this.GroupBoxCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GroupBoxCommands.ForeColor = System.Drawing.Color.Snow;
            this.GroupBoxCommands.Location = new System.Drawing.Point(317, 162);
            this.GroupBoxCommands.Name = "GroupBoxCommands";
            this.GroupBoxCommands.Size = new System.Drawing.Size(293, 192);
            this.GroupBoxCommands.TabIndex = 15;
            this.GroupBoxCommands.TabStop = false;
            this.GroupBoxCommands.Text = "Commands";
            this.GroupBoxCommands.Visible = false;
            // 
            // label11
            // 
            this.label11.AccessibleName = "Baud Rate:";
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Snow;
            this.label11.Location = new System.Drawing.Point(72, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Press \'Enter\' to send.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.Snow;
            this.label10.Location = new System.Drawing.Point(172, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "• clear rgb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.Snow;
            this.label9.Location = new System.Drawing.Point(33, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 18);
            this.label9.TabIndex = 4;
            this.label9.Text = "• set #color#";
            // 
            // label6
            // 
            this.label6.AccessibleName = "Baud Rate:";
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Enter the following commands:";
            // 
            // CommandsBox
            // 
            this.CommandsBox.AcceptsReturn = true;
            this.CommandsBox.Location = new System.Drawing.Point(6, 97);
            this.CommandsBox.Name = "CommandsBox";
            this.CommandsBox.Size = new System.Drawing.Size(277, 41);
            this.CommandsBox.TabIndex = 0;
            this.CommandsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandsBox_KeyDown);
            // 
            // GroupBoxChat
            // 
            this.GroupBoxChat.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxChat.Controls.Add(this.CountLabel);
            this.GroupBoxChat.Controls.Add(this.ChatBox);
            this.GroupBoxChat.Controls.Add(this.label12);
            this.GroupBoxChat.Controls.Add(this.label15);
            this.GroupBoxChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GroupBoxChat.ForeColor = System.Drawing.Color.Snow;
            this.GroupBoxChat.Location = new System.Drawing.Point(317, 162);
            this.GroupBoxChat.Name = "GroupBoxChat";
            this.GroupBoxChat.Size = new System.Drawing.Size(293, 192);
            this.GroupBoxChat.TabIndex = 16;
            this.GroupBoxChat.TabStop = false;
            this.GroupBoxChat.Text = "Chat";
            this.GroupBoxChat.Visible = false;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CountLabel.Location = new System.Drawing.Point(131, 142);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(0, 13);
            this.CountLabel.TabIndex = 8;
            // 
            // ChatBox
            // 
            this.ChatBox.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ChatBox.Font = new System.Drawing.Font("Green Screen", 17.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChatBox.Location = new System.Drawing.Point(19, 71);
            this.ChatBox.MaxLength = 32;
            this.ChatBox.Name = "ChatBox";
            this.ChatBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ChatBox.Size = new System.Drawing.Size(259, 68);
            this.ChatBox.TabIndex = 7;
            this.ChatBox.Text = "";
            this.ChatBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChatBox_KeyDown);
            this.ChatBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChatBox_KeyUp);
            // 
            // label12
            // 
            this.label12.AccessibleName = "Baud Rate:";
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.Snow;
            this.label12.Location = new System.Drawing.Point(75, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 18);
            this.label12.TabIndex = 6;
            this.label12.Text = "Press \'Enter\' to send.";
            // 
            // label15
            // 
            this.label15.AccessibleName = "Baud Rate:";
            this.label15.AutoSize = true;
            this.label15.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.ForeColor = System.Drawing.Color.Snow;
            this.label15.Location = new System.Drawing.Point(14, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(264, 25);
            this.label15.TabIndex = 3;
            this.label15.Text = "Send a messege to the LCD!";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButton1.ForeColor = System.Drawing.Color.Snow;
            this.radioButton1.Location = new System.Drawing.Point(428, 128);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 19);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Chat";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButton2.ForeColor = System.Drawing.Color.Snow;
            this.radioButton2.Location = new System.Drawing.Point(317, 128);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 19);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Commands";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Enabled = false;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radioButton3.ForeColor = System.Drawing.Color.Snow;
            this.radioButton3.Location = new System.Drawing.Point(504, 128);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(106, 19);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "File Transfer";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
            // 
            // GroupBoxFile
            // 
            this.GroupBoxFile.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxFile.Controls.Add(this.SendByte);
            this.GroupBoxFile.Controls.Add(this.ReciveButton);
            this.GroupBoxFile.Controls.Add(this.DisplayContext);
            this.GroupBoxFile.Controls.Add(this.SendFileButton);
            this.GroupBoxFile.Controls.Add(this.ChosenFileLabel);
            this.GroupBoxFile.Controls.Add(this.FilePicker);
            this.GroupBoxFile.Controls.Add(this.label19);
            this.GroupBoxFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GroupBoxFile.ForeColor = System.Drawing.Color.Snow;
            this.GroupBoxFile.Location = new System.Drawing.Point(317, 162);
            this.GroupBoxFile.Name = "GroupBoxFile";
            this.GroupBoxFile.Size = new System.Drawing.Size(293, 192);
            this.GroupBoxFile.TabIndex = 20;
            this.GroupBoxFile.TabStop = false;
            this.GroupBoxFile.Text = "File Transfer";
            this.GroupBoxFile.Visible = false;
            // 
            // SendByte
            // 
            this.SendByte.Enabled = false;
            this.SendByte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SendByte.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.SendByte.Location = new System.Drawing.Point(15, 143);
            this.SendByte.Name = "SendByte";
            this.SendByte.Size = new System.Drawing.Size(132, 34);
            this.SendByte.TabIndex = 24;
            this.SendByte.TabStop = false;
            this.SendByte.Text = "Byte by Byte";
            this.SendByte.UseVisualStyleBackColor = true;
            this.SendByte.Click += new System.EventHandler(this.SendByte_Click);
            // 
            // ReciveButton
            // 
            this.ReciveButton.Enabled = false;
            this.ReciveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ReciveButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.ReciveButton.Location = new System.Drawing.Point(153, 143);
            this.ReciveButton.Name = "ReciveButton";
            this.ReciveButton.Size = new System.Drawing.Size(132, 34);
            this.ReciveButton.TabIndex = 23;
            this.ReciveButton.Text = "Recive File";
            this.ReciveButton.UseVisualStyleBackColor = true;
            this.ReciveButton.Click += new System.EventHandler(this.ReciveButton_Click);
            // 
            // DisplayContext
            // 
            this.DisplayContext.Enabled = false;
            this.DisplayContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DisplayContext.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.DisplayContext.Location = new System.Drawing.Point(153, 105);
            this.DisplayContext.Name = "DisplayContext";
            this.DisplayContext.Size = new System.Drawing.Size(132, 34);
            this.DisplayContext.TabIndex = 7;
            this.DisplayContext.Text = "Display";
            this.DisplayContext.UseVisualStyleBackColor = true;
            this.DisplayContext.Click += new System.EventHandler(this.DisplayContext_Click);
            // 
            // SendFileButton
            // 
            this.SendFileButton.Enabled = false;
            this.SendFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SendFileButton.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.SendFileButton.Location = new System.Drawing.Point(15, 105);
            this.SendFileButton.Name = "SendFileButton";
            this.SendFileButton.Size = new System.Drawing.Size(132, 34);
            this.SendFileButton.TabIndex = 6;
            this.SendFileButton.Text = "Send it!";
            this.SendFileButton.UseVisualStyleBackColor = true;
            this.SendFileButton.Click += new System.EventHandler(this.SendFileButton_Click);
            // 
            // ChosenFileLabel
            // 
            this.ChosenFileLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChosenFileLabel.Font = new System.Drawing.Font("Parchment", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ChosenFileLabel.ForeColor = System.Drawing.Color.Snow;
            this.ChosenFileLabel.Location = new System.Drawing.Point(11, 78);
            this.ChosenFileLabel.Name = "ChosenFileLabel";
            this.ChosenFileLabel.Size = new System.Drawing.Size(276, 24);
            this.ChosenFileLabel.TabIndex = 5;
            this.ChosenFileLabel.Text = "ChosenFileLabel";
            this.ChosenFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChosenFileLabel.Visible = false;
            // 
            // FilePicker
            // 
            this.FilePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FilePicker.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.FilePicker.FormattingEnabled = true;
            this.FilePicker.Items.AddRange(new object[] {
            "File1",
            "File2",
            "File3",
            "File4",
            "Doodle1",
            "Doodle2"});
            this.FilePicker.Location = new System.Drawing.Point(166, 47);
            this.FilePicker.Name = "FilePicker";
            this.FilePicker.Size = new System.Drawing.Size(121, 24);
            this.FilePicker.TabIndex = 4;
            this.FilePicker.SelectedIndexChanged += new System.EventHandler(this.FilePicker_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AccessibleName = "Baud Rate:";
            this.label19.AutoSize = true;
            this.label19.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label19.ForeColor = System.Drawing.Color.Snow;
            this.label19.Location = new System.Drawing.Point(6, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 25);
            this.label19.TabIndex = 3;
            this.label19.Text = "Upload a *.txt file:";
            // 
            // LogText
            // 
            this.LogText.BackColor = System.Drawing.Color.White;
            this.LogText.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LogText.ForeColor = System.Drawing.Color.Black;
            this.LogText.Location = new System.Drawing.Point(621, 128);
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            this.LogText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.LogText.Size = new System.Drawing.Size(293, 226);
            this.LogText.TabIndex = 22;
            this.LogText.Text = "";
            this.LogText.TextChanged += new System.EventHandler(this.LogText_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(205, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 83);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(926, 380);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LogText);
            this.Controls.Add(this.GroupBoxFile);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.GroupBoxChat);
            this.Controls.Add(this.GroupBoxCommands);
            this.Controls.Add(this.GroupBoxConnection);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBoxConnection.ResumeLayout(false);
            this.GroupBoxConnection.PerformLayout();
            this.GroupBoxCommands.ResumeLayout(false);
            this.GroupBoxCommands.PerformLayout();
            this.GroupBoxChat.ResumeLayout(false);
            this.GroupBoxChat.PerformLayout();
            this.GroupBoxFile.ResumeLayout(false);
            this.GroupBoxFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox BaudRateBox;
        private System.Windows.Forms.Label Baud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox StopBitBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ParityBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox COMbox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button TestConnection;
        private System.Windows.Forms.GroupBox GroupBoxConnection;
        private System.Windows.Forms.GroupBox GroupBoxCommands;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CommandsBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox GroupBoxChat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox GroupBoxFile;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox FilePicker;
        private System.Windows.Forms.Label ChosenFileLabel;
        private System.Windows.Forms.Button SendFileButton;
        private System.Windows.Forms.RichTextBox LogText;
        private System.Windows.Forms.RichTextBox ChatBox;
        private System.Windows.Forms.Button DisplayContext;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.Button ReciveButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SendByte;
    }
}

