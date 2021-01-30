
namespace ControlArduinoByInventorModel
{
    partial class ArduinoControl
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
            this.positionXLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.baudRateTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPortcomboBox1 = new System.Windows.Forms.ComboBox();
            this.ConnectSerialPort = new System.Windows.Forms.Button();
            this.positionYLabel = new System.Windows.Forms.Label();
            this.isConnectLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // positionXLabel
            // 
            this.positionXLabel.AutoSize = true;
            this.positionXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.positionXLabel.Location = new System.Drawing.Point(12, 132);
            this.positionXLabel.Name = "positionXLabel";
            this.positionXLabel.Size = new System.Drawing.Size(347, 91);
            this.positionXLabel.TabIndex = 0;
            this.positionXLabel.Text = "POSX: 0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baudRateTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.serialPortcomboBox1);
            this.groupBox2.Controls.Add(this.ConnectSerialPort);
            this.groupBox2.Location = new System.Drawing.Point(12, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(572, 71);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial Connection";
            // 
            // baudRateTextBox
            // 
            this.baudRateTextBox.Location = new System.Drawing.Point(408, 39);
            this.baudRateTextBox.Name = "baudRateTextBox";
            this.baudRateTextBox.Size = new System.Drawing.Size(100, 22);
            this.baudRateTextBox.TabIndex = 3;
            this.baudRateTextBox.Text = "9600";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate:";
            // 
            // serialPortcomboBox1
            // 
            this.serialPortcomboBox1.FormattingEnabled = true;
            this.serialPortcomboBox1.Location = new System.Drawing.Point(160, 37);
            this.serialPortcomboBox1.Name = "serialPortcomboBox1";
            this.serialPortcomboBox1.Size = new System.Drawing.Size(136, 24);
            this.serialPortcomboBox1.TabIndex = 1;
            // 
            // ConnectSerialPort
            // 
            this.ConnectSerialPort.Location = new System.Drawing.Point(8, 31);
            this.ConnectSerialPort.Name = "ConnectSerialPort";
            this.ConnectSerialPort.Size = new System.Drawing.Size(136, 34);
            this.ConnectSerialPort.TabIndex = 0;
            this.ConnectSerialPort.Text = "Connect";
            this.ConnectSerialPort.UseVisualStyleBackColor = true;
            this.ConnectSerialPort.Click += new System.EventHandler(this.ConnectToArduino_Click);
            // 
            // positionYLabel
            // 
            this.positionYLabel.AutoSize = true;
            this.positionYLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.positionYLabel.Location = new System.Drawing.Point(12, 257);
            this.positionYLabel.Name = "positionYLabel";
            this.positionYLabel.Size = new System.Drawing.Size(347, 91);
            this.positionYLabel.TabIndex = 11;
            this.positionYLabel.Text = "POSY: 0";
            // 
            // isConnectLabel
            // 
            this.isConnectLabel.AutoSize = true;
            this.isConnectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.isConnectLabel.Location = new System.Drawing.Point(604, 51);
            this.isConnectLabel.Name = "isConnectLabel";
            this.isConnectLabel.Size = new System.Drawing.Size(174, 29);
            this.isConnectLabel.TabIndex = 12;
            this.isConnectLabel.Text = "Not Connected";
            // 
            // ArduinoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.isConnectLabel);
            this.Controls.Add(this.positionYLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.positionXLabel);
            this.Name = "ArduinoControl";
            this.Text = "ArduinoControl";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label positionXLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox baudRateTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox serialPortcomboBox1;
        private System.Windows.Forms.Button ConnectSerialPort;
        private System.Windows.Forms.Label positionYLabel;
        private System.Windows.Forms.Label isConnectLabel;
    }
}

