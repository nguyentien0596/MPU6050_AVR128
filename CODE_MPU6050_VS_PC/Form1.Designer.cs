namespace GiaoTiepMpu6050
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.ComBBaud = new System.Windows.Forms.ComboBox();
            this.ComBPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTKetNoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TexBTenfile = new System.Windows.Forms.TextBox();
            this.BTStart = new System.Windows.Forms.Button();
            this.ZedGraphGiaToc = new ZedGraph.ZedGraphControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComBchedo = new System.Windows.Forms.ComboBox();
            this.BtLoad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.dataReceive);
            // 
            // ComBBaud
            // 
            this.ComBBaud.FormattingEnabled = true;
            this.ComBBaud.Location = new System.Drawing.Point(74, 81);
            this.ComBBaud.Name = "ComBBaud";
            this.ComBBaud.Size = new System.Drawing.Size(137, 21);
            this.ComBBaud.TabIndex = 11;
            // 
            // ComBPort
            // 
            this.ComBPort.FormattingEnabled = true;
            this.ComBPort.Location = new System.Drawing.Point(74, 41);
            this.ComBPort.Name = "ComBPort";
            this.ComBPort.Size = new System.Drawing.Size(137, 21);
            this.ComBPort.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Baud rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cổng ";
            // 
            // BTKetNoi
            // 
            this.BTKetNoi.Location = new System.Drawing.Point(74, 128);
            this.BTKetNoi.Name = "BTKetNoi";
            this.BTKetNoi.Size = new System.Drawing.Size(93, 27);
            this.BTKetNoi.TabIndex = 8;
            this.BTKetNoi.Text = "Kết Nối";
            this.BTKetNoi.UseVisualStyleBackColor = true;
            this.BTKetNoi.Click += new System.EventHandler(this.BTKetNoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComBBaud);
            this.groupBox1.Controls.Add(this.ComBPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BTKetNoi);
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 178);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cài đặt";
            // 
            // TexBTenfile
            // 
            this.TexBTenfile.Location = new System.Drawing.Point(74, 48);
            this.TexBTenfile.Name = "TexBTenfile";
            this.TexBTenfile.Size = new System.Drawing.Size(137, 20);
            this.TexBTenfile.TabIndex = 14;
            // 
            // BTStart
            // 
            this.BTStart.Location = new System.Drawing.Point(133, 132);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(93, 27);
            this.BTStart.TabIndex = 8;
            this.BTStart.Text = "Bắt đầu";
            this.BTStart.UseVisualStyleBackColor = true;
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // ZedGraphGiaToc
            // 
            this.ZedGraphGiaToc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ZedGraphGiaToc.BackColor = System.Drawing.SystemColors.Control;
            this.ZedGraphGiaToc.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ZedGraphGiaToc.Location = new System.Drawing.Point(282, 21);
            this.ZedGraphGiaToc.Name = "ZedGraphGiaToc";
            this.ZedGraphGiaToc.ScrollGrace = 0D;
            this.ZedGraphGiaToc.ScrollMaxX = 0D;
            this.ZedGraphGiaToc.ScrollMaxY = 0D;
            this.ZedGraphGiaToc.ScrollMaxY2 = 0D;
            this.ZedGraphGiaToc.ScrollMinX = 0D;
            this.ZedGraphGiaToc.ScrollMinY = 0D;
            this.ZedGraphGiaToc.ScrollMinY2 = 0D;
            this.ZedGraphGiaToc.Size = new System.Drawing.Size(739, 400);
            this.ZedGraphGiaToc.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ComBchedo);
            this.groupBox3.Controls.Add(this.BtLoad);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TexBTenfile);
            this.groupBox3.Controls.Add(this.BTStart);
            this.groupBox3.Location = new System.Drawing.Point(19, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 197);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Chế độ";
            // 
            // ComBchedo
            // 
            this.ComBchedo.FormattingEnabled = true;
            this.ComBchedo.Location = new System.Drawing.Point(74, 74);
            this.ComBchedo.Name = "ComBchedo";
            this.ComBchedo.Size = new System.Drawing.Size(137, 21);
            this.ComBchedo.TabIndex = 20;
            // 
            // BtLoad
            // 
            this.BtLoad.Location = new System.Drawing.Point(27, 132);
            this.BtLoad.Name = "BtLoad";
            this.BtLoad.Size = new System.Drawing.Size(90, 27);
            this.BtLoad.TabIndex = 16;
            this.BtLoad.Text = "Load File";
            this.BtLoad.UseVisualStyleBackColor = true;
            this.BtLoad.Click += new System.EventHandler(this.BtLoad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tên File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1043, 446);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ZedGraphGiaToc);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Tiếp MPU6050";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox ComBBaud;
        private System.Windows.Forms.ComboBox ComBPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTKetNoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private ZedGraph.ZedGraphControl ZedGraphGiaToc;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button BTStart;
        private System.Windows.Forms.TextBox TexBTenfile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtLoad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComBchedo;
    }
}

