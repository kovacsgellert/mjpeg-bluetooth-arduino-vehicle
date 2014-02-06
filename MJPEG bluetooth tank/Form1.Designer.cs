namespace MJPEG_bluetooth_tank
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.arrowBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.MJPEGstartButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bluetoothBox = new System.Windows.Forms.ComboBox();
            this.BLUETOOTHstartButton = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.tBar = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.videoBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.MJPEGstopButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.arrowBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // arrowBox
            // 
            this.arrowBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.arrowBox.Image = global::MJPEG_bluetooth_tank.Properties.Resources.comm_stopped;
            this.arrowBox.Location = new System.Drawing.Point(663, 18);
            this.arrowBox.Name = "arrowBox";
            this.arrowBox.Size = new System.Drawing.Size(150, 150);
            this.arrowBox.TabIndex = 1;
            this.arrowBox.TabStop = false;
            this.toolTip1.SetToolTip(this.arrowBox, "Movement direction indicators");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 514);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MJPEG server IP adress: ";
            this.toolTip1.SetToolTip(this.label1, "Select the correct IP address, something like this: http://192.168.1.97/video.mjp" +
        "eg");
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(146, 511);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(287, 20);
            this.addressBox.TabIndex = 3;
            this.addressBox.Text = "http://192.168.10.105:8080/videofeed";
            this.toolTip1.SetToolTip(this.addressBox, "Select the correct IP address, something like this: http://192.168.1.97/video.mjp" +
        "eg  \\n Please hit Stop stream button before changing the IP address, if there is" +
        " already one stream running.");
            this.addressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBox_KeyDown);
            // 
            // MJPEGstartButton
            // 
            this.MJPEGstartButton.Location = new System.Drawing.Point(456, 507);
            this.MJPEGstartButton.Name = "MJPEGstartButton";
            this.MJPEGstartButton.Size = new System.Drawing.Size(95, 26);
            this.MJPEGstartButton.TabIndex = 4;
            this.MJPEGstartButton.Text = "Start stream";
            this.toolTip1.SetToolTip(this.MJPEGstartButton, "Start the MJPEG stream, please check if the IP address is correct.");
            this.MJPEGstartButton.UseVisualStyleBackColor = true;
            this.MJPEGstartButton.Click += new System.EventHandler(this.MJPEGstartButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Bluetooth COM port:";
            this.toolTip1.SetToolTip(this.label2, "Select the COM port to which the Bluetooth Serial is attached to");
            // 
            // bluetoothBox
            // 
            this.bluetoothBox.FormattingEnabled = true;
            this.bluetoothBox.Location = new System.Drawing.Point(663, 198);
            this.bluetoothBox.Name = "bluetoothBox";
            this.bluetoothBox.Size = new System.Drawing.Size(150, 21);
            this.bluetoothBox.TabIndex = 6;
            this.bluetoothBox.Text = "Choose one!";
            this.toolTip1.SetToolTip(this.bluetoothBox, "Select the COM port to which the Bluetooth Serial is attached to.");
            this.bluetoothBox.SelectedIndexChanged += new System.EventHandler(this.bluetoothBox_SelectedIndexChanged);
            this.bluetoothBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bluetoothBox_KeyDown);
            // 
            // BLUETOOTHstartButton
            // 
            this.BLUETOOTHstartButton.Location = new System.Drawing.Point(663, 225);
            this.BLUETOOTHstartButton.Name = "BLUETOOTHstartButton";
            this.BLUETOOTHstartButton.Size = new System.Drawing.Size(150, 23);
            this.BLUETOOTHstartButton.TabIndex = 7;
            this.BLUETOOTHstartButton.Text = "Start communication";
            this.toolTip1.SetToolTip(this.BLUETOOTHstartButton, "Start/end communication with with the vehicle through the selected COM port");
            this.BLUETOOTHstartButton.UseVisualStyleBackColor = true;
            this.BLUETOOTHstartButton.Click += new System.EventHandler(this.BLUETOOTHstartButton_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(663, 272);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(44, 13);
            this.labelSpeed.TabIndex = 8;
            this.labelSpeed.Text = "Speed: ";
            this.toolTip1.SetToolTip(this.labelSpeed, "Set speed of the vehicle on a scale of 1 to 9");
            // 
            // tBar
            // 
            this.tBar.LargeChange = 2;
            this.tBar.Location = new System.Drawing.Point(663, 288);
            this.tBar.Maximum = 9;
            this.tBar.Minimum = 1;
            this.tBar.Name = "tBar";
            this.tBar.Size = new System.Drawing.Size(150, 45);
            this.tBar.TabIndex = 9;
            this.toolTip1.SetToolTip(this.tBar, "Set speed of the vehicle on a scale of 1 to 9");
            this.tBar.Value = 7;
            this.tBar.ValueChanged += new System.EventHandler(this.tBar_ValueChanged);
            this.tBar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBar_KeyDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MJPEG_bluetooth_tank.Properties.Resources.KGP_logo;
            this.pictureBox1.Location = new System.Drawing.Point(670, 397);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Creator LOGO :)");
            // 
            // videoBox
            // 
            this.videoBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.videoBox.BackColor = System.Drawing.SystemColors.Control;
            this.videoBox.Image = global::MJPEG_bluetooth_tank.Properties.Resources.no_video;
            this.videoBox.Location = new System.Drawing.Point(14, 18);
            this.videoBox.Margin = new System.Windows.Forms.Padding(5);
            this.videoBox.Name = "videoBox";
            this.videoBox.Size = new System.Drawing.Size(640, 480);
            this.videoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.videoBox.TabIndex = 0;
            this.videoBox.TabStop = false;
            this.toolTip1.SetToolTip(this.videoBox, "Place of your MJPEG stream (if the IP adress is correct)");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kovács Gellért Pál - 2013";
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MJPEGstopButton
            // 
            this.MJPEGstopButton.Location = new System.Drawing.Point(557, 507);
            this.MJPEGstopButton.Name = "MJPEGstopButton";
            this.MJPEGstopButton.Size = new System.Drawing.Size(95, 26);
            this.MJPEGstopButton.TabIndex = 12;
            this.MJPEGstopButton.Text = "Stop stream";
            this.MJPEGstopButton.UseVisualStyleBackColor = true;
            this.MJPEGstopButton.Click += new System.EventHandler(this.MJPEGstopButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(670, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 51);
            this.button1.TabIndex = 13;
            this.button1.Text = "Help";
            this.toolTip1.SetToolTip(this.button1, "Opent the Help file of this application");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 541);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MJPEGstopButton);
            this.Controls.Add(this.videoBox);
            this.Controls.Add(this.tBar);
            this.Controls.Add(this.BLUETOOTHstartButton);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.bluetoothBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MJPEGstartButton);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arrowBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MJPEG RC TANK";
            ((System.ComponentModel.ISupportInitialize)(this.arrowBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arrowBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button MJPEGstartButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox bluetoothBox;
        private System.Windows.Forms.Button BLUETOOTHstartButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.TrackBar tBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox videoBox;
        private System.Windows.Forms.Button MJPEGstopButton;
        private System.Windows.Forms.Button button1;
    }
}

