
namespace ArduinoLocomotiveController
{
    partial class ControlPanel
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        class CustomTBar : System.Windows.Forms.TrackBar
        {
            protected override bool ShowFocusCues
            {
                get
                {
                    return false;
                }
            }
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.Direction = new System.Windows.Forms.TrackBar();
            this.Power = new System.Windows.Forms.TrackBar();
            this.AutoBrake = new System.Windows.Forms.TrackBar();
            this.IndeBrake = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Direction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoBrake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndeBrake)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Direction
            // 
            this.Direction.LargeChange = 0;
            this.Direction.Location = new System.Drawing.Point(92, 66);
            this.Direction.Maximum = 1;
            this.Direction.Minimum = -1;
            this.Direction.Name = "Direction";
            this.Direction.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Direction.Size = new System.Drawing.Size(45, 341);
            this.Direction.SmallChange = 0;
            this.Direction.TabIndex = 0;
            this.Direction.TabStop = false;
            this.Direction.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // Power
            // 
            this.Power.LargeChange = 0;
            this.Power.Location = new System.Drawing.Point(256, 66);
            this.Power.Maximum = 5;
            this.Power.Minimum = -5;
            this.Power.Name = "Power";
            this.Power.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Power.Size = new System.Drawing.Size(45, 341);
            this.Power.SmallChange = 0;
            this.Power.TabIndex = 1;
            this.Power.TabStop = false;
            this.Power.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // AutoBrake
            // 
            this.AutoBrake.LargeChange = 0;
            this.AutoBrake.Location = new System.Drawing.Point(172, 63);
            this.AutoBrake.Maximum = 2;
            this.AutoBrake.Name = "AutoBrake";
            this.AutoBrake.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.AutoBrake.Size = new System.Drawing.Size(45, 341);
            this.AutoBrake.SmallChange = 0;
            this.AutoBrake.TabIndex = 2;
            this.AutoBrake.TabStop = false;
            this.AutoBrake.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // IndeBrake
            // 
            this.IndeBrake.LargeChange = 0;
            this.IndeBrake.Location = new System.Drawing.Point(239, 63);
            this.IndeBrake.Maximum = 2;
            this.IndeBrake.Name = "IndeBrake";
            this.IndeBrake.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.IndeBrake.Size = new System.Drawing.Size(45, 341);
            this.IndeBrake.SmallChange = 0;
            this.IndeBrake.TabIndex = 3;
            this.IndeBrake.TabStop = false;
            this.IndeBrake.TickStyle = System.Windows.Forms.TickStyle.Both;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Power);
            this.groupBox1.Controls.Add(this.Direction);
            this.groupBox1.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(99, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 436);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Power Combined";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(301, 368);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 50);
            this.label9.TabIndex = 10;
            this.label9.Text = "DYNAMIC\r\nBRAKE";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(301, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 50);
            this.label8.TabIndex = 9;
            this.label8.Text = "FULL\r\nTHROTTLE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(307, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "IDLE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(138, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Reverse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reverse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(138, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Neutral";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(21, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Neutral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(138, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forward";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Forward";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.IndeBrake);
            this.groupBox2.Controls.Add(this.AutoBrake);
            this.groupBox2.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(728, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 436);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brakes";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(385, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(20, 289);
            this.label17.TabIndex = 11;
            this.label17.Text = "I\r\nN\r\nD\r\nE\r\nP\r\nE\r\nN\r\nD\r\nE\r\nN\r\nT\r\n\r\nB\r\nR\r\nA\r\nK\r\nE";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(49, 148);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 170);
            this.label16.TabIndex = 10;
            this.label16.Text = "A\r\nU\r\nT\r\nO\r\n\r\nB\r\nR\r\nA\r\nK\r\nE";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(290, 65);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 22);
            this.label15.TabIndex = 9;
            this.label15.Text = "Full";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(124, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 22);
            this.label14.TabIndex = 8;
            this.label14.Text = "Full";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(290, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 22);
            this.label13.TabIndex = 7;
            this.label13.Text = "Half";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(119, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "Half";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(290, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Release";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(86, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Release";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControlPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locomotive Controller";
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Direction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AutoBrake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndeBrake)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar Direction;
        private System.Windows.Forms.TrackBar Power;
        private System.Windows.Forms.TrackBar AutoBrake;
        private System.Windows.Forms.TrackBar IndeBrake;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}

