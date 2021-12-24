
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DirectionLock = new System.Windows.Forms.Label();
            this.PowerLock = new System.Windows.Forms.Label();
            this.PowerActivibility = new System.Windows.Forms.TextBox();
            this.DirectionActivibility = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.Panel();
            this.B2 = new System.Windows.Forms.Panel();
            this.P5 = new System.Windows.Forms.Panel();
            this.P4 = new System.Windows.Forms.Panel();
            this.B3 = new System.Windows.Forms.Panel();
            this.P3 = new System.Windows.Forms.Panel();
            this.P2 = new System.Windows.Forms.Panel();
            this.B4 = new System.Windows.Forms.Panel();
            this.P1 = new System.Windows.Forms.Panel();
            this.B5 = new System.Windows.Forms.Panel();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.DYNAMICBRAKE = new System.Windows.Forms.Label();
            this.FULLTHROTTLE = new System.Windows.Forms.Label();
            this.IDLE = new System.Windows.Forms.Label();
            this.ReverseR = new System.Windows.Forms.Label();
            this.ReverseL = new System.Windows.Forms.Label();
            this.NeutralR = new System.Windows.Forms.Label();
            this.NeutralL = new System.Windows.Forms.Label();
            this.ForwardR = new System.Windows.Forms.Label();
            this.ForwardL = new System.Windows.Forms.Label();
            this.Direction = new ArduinoLocomotiveController.TrackBarNoBorder();
            this.Power = new ArduinoLocomotiveController.TrackBarNoBorder();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IndeApp = new System.Windows.Forms.Label();
            this.AutoApp = new System.Windows.Forms.Label();
            this.IFR = new System.Windows.Forms.Panel();
            this.AFR = new System.Windows.Forms.Panel();
            this.IHR = new System.Windows.Forms.Panel();
            this.AHR = new System.Windows.Forms.Panel();
            this.IFL = new System.Windows.Forms.Panel();
            this.IHL = new System.Windows.Forms.Panel();
            this.AFL = new System.Windows.Forms.Panel();
            this.AHL = new System.Windows.Forms.Panel();
            this.IndeActivibility = new System.Windows.Forms.TextBox();
            this.AutoActivibility = new System.Windows.Forms.TextBox();
            this.LblInde = new System.Windows.Forms.Label();
            this.LblAuto = new System.Windows.Forms.Label();
            this.IFull = new System.Windows.Forms.Label();
            this.AFull = new System.Windows.Forms.Label();
            this.IHalf = new System.Windows.Forms.Label();
            this.AHalf = new System.Windows.Forms.Label();
            this.IRelease = new System.Windows.Forms.Label();
            this.ARelease = new System.Windows.Forms.Label();
            this.AutoBrake = new ArduinoLocomotiveController.TrackBarNoBorder();
            this.IndeBrake = new ArduinoLocomotiveController.TrackBarNoBorder();
            this.SCC = new System.Windows.Forms.Label();
            this.SCing = new System.Windows.Forms.Label();
            this.SCC_Cover = new System.Windows.Forms.RichTextBox();
            this.PowerNum = new System.Windows.Forms.RichTextBox();
            this.LblPowerLevel = new System.Windows.Forms.Label();
            this.BaudList = new System.Windows.Forms.ComboBox();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.LinkStart = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.EBrake = new System.Windows.Forms.PictureBox();
            this.LblCE = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Direction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoBrake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndeBrake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBrake)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.DirectionLock);
            this.groupBox1.Controls.Add(this.PowerLock);
            this.groupBox1.Controls.Add(this.PowerActivibility);
            this.groupBox1.Controls.Add(this.DirectionActivibility);
            this.groupBox1.Controls.Add(this.B1);
            this.groupBox1.Controls.Add(this.B2);
            this.groupBox1.Controls.Add(this.P5);
            this.groupBox1.Controls.Add(this.P4);
            this.groupBox1.Controls.Add(this.B3);
            this.groupBox1.Controls.Add(this.P3);
            this.groupBox1.Controls.Add(this.P2);
            this.groupBox1.Controls.Add(this.B4);
            this.groupBox1.Controls.Add(this.P1);
            this.groupBox1.Controls.Add(this.B5);
            this.groupBox1.Controls.Add(this.progressBar2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.DYNAMICBRAKE);
            this.groupBox1.Controls.Add(this.FULLTHROTTLE);
            this.groupBox1.Controls.Add(this.IDLE);
            this.groupBox1.Controls.Add(this.ReverseR);
            this.groupBox1.Controls.Add(this.ReverseL);
            this.groupBox1.Controls.Add(this.NeutralR);
            this.groupBox1.Controls.Add(this.NeutralL);
            this.groupBox1.Controls.Add(this.ForwardR);
            this.groupBox1.Controls.Add(this.ForwardL);
            this.groupBox1.Controls.Add(this.Direction);
            this.groupBox1.Controls.Add(this.Power);
            this.groupBox1.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(85, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 452);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Power Combined";
            // 
            // DirectionLock
            // 
            this.DirectionLock.AutoSize = true;
            this.DirectionLock.BackColor = System.Drawing.Color.Green;
            this.DirectionLock.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DirectionLock.ForeColor = System.Drawing.Color.Yellow;
            this.DirectionLock.Location = new System.Drawing.Point(41, 29);
            this.DirectionLock.Name = "DirectionLock";
            this.DirectionLock.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.DirectionLock.Size = new System.Drawing.Size(153, 32);
            this.DirectionLock.TabIndex = 17;
            this.DirectionLock.Text = "Reverser Lock";
            this.DirectionLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PowerLock
            // 
            this.PowerLock.AutoSize = true;
            this.PowerLock.BackColor = System.Drawing.Color.Red;
            this.PowerLock.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PowerLock.ForeColor = System.Drawing.Color.Yellow;
            this.PowerLock.Location = new System.Drawing.Point(389, 220);
            this.PowerLock.Name = "PowerLock";
            this.PowerLock.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.PowerLock.Size = new System.Drawing.Size(69, 32);
            this.PowerLock.TabIndex = 16;
            this.PowerLock.Text = "LOCK";
            this.PowerLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PowerActivibility
            // 
            this.PowerActivibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PowerActivibility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PowerActivibility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PowerActivibility.Cursor = System.Windows.Forms.Cursors.Default;
            this.PowerActivibility.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PowerActivibility.ForeColor = System.Drawing.Color.Black;
            this.PowerActivibility.Location = new System.Drawing.Point(275, 420);
            this.PowerActivibility.Name = "PowerActivibility";
            this.PowerActivibility.ReadOnly = true;
            this.PowerActivibility.Size = new System.Drawing.Size(68, 22);
            this.PowerActivibility.TabIndex = 15;
            this.PowerActivibility.TabStop = false;
            this.PowerActivibility.Text = "Active";
            this.PowerActivibility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PowerActivibility.Click += new System.EventHandler(this.PowerActivibility_Click);
            // 
            // DirectionActivibility
            // 
            this.DirectionActivibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DirectionActivibility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DirectionActivibility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirectionActivibility.Cursor = System.Windows.Forms.Cursors.Default;
            this.DirectionActivibility.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DirectionActivibility.ForeColor = System.Drawing.Color.Black;
            this.DirectionActivibility.Location = new System.Drawing.Point(80, 420);
            this.DirectionActivibility.Name = "DirectionActivibility";
            this.DirectionActivibility.ReadOnly = true;
            this.DirectionActivibility.Size = new System.Drawing.Size(68, 22);
            this.DirectionActivibility.TabIndex = 14;
            this.DirectionActivibility.TabStop = false;
            this.DirectionActivibility.Text = "Active";
            this.DirectionActivibility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DirectionActivibility.Click += new System.EventHandler(this.DirectionActivibility_Click);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Gold;
            this.B1.Location = new System.Drawing.Point(256, 238);
            this.B1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.B1.Name = "B1";
            this.B1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.B1.Size = new System.Drawing.Size(20, 32);
            this.B1.TabIndex = 9;
            this.B1.Visible = false;
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Gold;
            this.B2.Location = new System.Drawing.Point(256, 270);
            this.B2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.B2.Name = "B2";
            this.B2.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.B2.Size = new System.Drawing.Size(20, 32);
            this.B2.TabIndex = 10;
            this.B2.Visible = false;
            // 
            // P5
            // 
            this.P5.BackColor = System.Drawing.Color.LimeGreen;
            this.P5.Location = new System.Drawing.Point(256, 75);
            this.P5.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.P5.Name = "P5";
            this.P5.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.P5.Size = new System.Drawing.Size(20, 32);
            this.P5.TabIndex = 7;
            this.P5.Visible = false;
            // 
            // P4
            // 
            this.P4.BackColor = System.Drawing.Color.LimeGreen;
            this.P4.Location = new System.Drawing.Point(256, 107);
            this.P4.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.P4.Name = "P4";
            this.P4.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.P4.Size = new System.Drawing.Size(20, 32);
            this.P4.TabIndex = 7;
            this.P4.Visible = false;
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Gold;
            this.B3.Location = new System.Drawing.Point(256, 302);
            this.B3.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.B3.Name = "B3";
            this.B3.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.B3.Size = new System.Drawing.Size(20, 32);
            this.B3.TabIndex = 11;
            this.B3.Visible = false;
            // 
            // P3
            // 
            this.P3.BackColor = System.Drawing.Color.LimeGreen;
            this.P3.Location = new System.Drawing.Point(256, 139);
            this.P3.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.P3.Name = "P3";
            this.P3.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.P3.Size = new System.Drawing.Size(20, 32);
            this.P3.TabIndex = 7;
            this.P3.Visible = false;
            // 
            // P2
            // 
            this.P2.BackColor = System.Drawing.Color.LimeGreen;
            this.P2.Location = new System.Drawing.Point(256, 171);
            this.P2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.P2.Name = "P2";
            this.P2.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.P2.Size = new System.Drawing.Size(20, 32);
            this.P2.TabIndex = 7;
            this.P2.Visible = false;
            // 
            // B4
            // 
            this.B4.BackColor = System.Drawing.Color.Gold;
            this.B4.Location = new System.Drawing.Point(256, 334);
            this.B4.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.B4.Name = "B4";
            this.B4.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.B4.Size = new System.Drawing.Size(20, 32);
            this.B4.TabIndex = 12;
            this.B4.Visible = false;
            // 
            // P1
            // 
            this.P1.BackColor = System.Drawing.Color.LimeGreen;
            this.P1.Location = new System.Drawing.Point(256, 203);
            this.P1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.P1.Name = "P1";
            this.P1.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.P1.Size = new System.Drawing.Size(20, 32);
            this.P1.TabIndex = 6;
            this.P1.Visible = false;
            // 
            // B5
            // 
            this.B5.BackColor = System.Drawing.Color.Gold;
            this.B5.Location = new System.Drawing.Point(256, 366);
            this.B5.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.B5.Name = "B5";
            this.B5.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.B5.Size = new System.Drawing.Size(20, 32);
            this.B5.TabIndex = 8;
            this.B5.Visible = false;
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(254, 236);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(24, 164);
            this.progressBar2.Step = 1;
            this.progressBar2.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(254, 73);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(24, 164);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 11;
            // 
            // DYNAMICBRAKE
            // 
            this.DYNAMICBRAKE.AutoSize = true;
            this.DYNAMICBRAKE.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DYNAMICBRAKE.ForeColor = System.Drawing.Color.Black;
            this.DYNAMICBRAKE.Location = new System.Drawing.Point(333, 368);
            this.DYNAMICBRAKE.Name = "DYNAMICBRAKE";
            this.DYNAMICBRAKE.Size = new System.Drawing.Size(116, 50);
            this.DYNAMICBRAKE.TabIndex = 10;
            this.DYNAMICBRAKE.Text = "DYNAMIC\r\nBRAKE";
            this.DYNAMICBRAKE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FULLTHROTTLE
            // 
            this.FULLTHROTTLE.AutoSize = true;
            this.FULLTHROTTLE.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FULLTHROTTLE.Location = new System.Drawing.Point(333, 53);
            this.FULLTHROTTLE.Name = "FULLTHROTTLE";
            this.FULLTHROTTLE.Size = new System.Drawing.Size(120, 50);
            this.FULLTHROTTLE.TabIndex = 9;
            this.FULLTHROTTLE.Text = "FULL\r\nTHROTTLE";
            this.FULLTHROTTLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IDLE
            // 
            this.IDLE.AutoSize = true;
            this.IDLE.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IDLE.Font = new System.Drawing.Font("等线", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IDLE.Location = new System.Drawing.Point(335, 220);
            this.IDLE.Name = "IDLE";
            this.IDLE.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.IDLE.Size = new System.Drawing.Size(58, 32);
            this.IDLE.TabIndex = 8;
            this.IDLE.Text = "IDLE";
            // 
            // ReverseR
            // 
            this.ReverseR.AutoSize = true;
            this.ReverseR.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReverseR.Location = new System.Drawing.Point(138, 382);
            this.ReverseR.Name = "ReverseR";
            this.ReverseR.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ReverseR.Size = new System.Drawing.Size(73, 25);
            this.ReverseR.TabIndex = 7;
            this.ReverseR.Text = "Reverse";
            // 
            // ReverseL
            // 
            this.ReverseL.AutoSize = true;
            this.ReverseL.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReverseL.Location = new System.Drawing.Point(17, 382);
            this.ReverseL.Name = "ReverseL";
            this.ReverseL.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ReverseL.Size = new System.Drawing.Size(73, 25);
            this.ReverseL.TabIndex = 6;
            this.ReverseL.Text = "Reverse";
            // 
            // NeutralR
            // 
            this.NeutralR.AutoSize = true;
            this.NeutralR.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NeutralR.Location = new System.Drawing.Point(138, 225);
            this.NeutralR.Name = "NeutralR";
            this.NeutralR.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.NeutralR.Size = new System.Drawing.Size(69, 25);
            this.NeutralR.TabIndex = 5;
            this.NeutralR.Text = "Neutral";
            // 
            // NeutralL
            // 
            this.NeutralL.AutoSize = true;
            this.NeutralL.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NeutralL.Location = new System.Drawing.Point(21, 225);
            this.NeutralL.Name = "NeutralL";
            this.NeutralL.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.NeutralL.Size = new System.Drawing.Size(69, 25);
            this.NeutralL.TabIndex = 4;
            this.NeutralL.Text = "Neutral";
            // 
            // ForwardR
            // 
            this.ForwardR.AutoSize = true;
            this.ForwardR.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForwardR.Location = new System.Drawing.Point(138, 67);
            this.ForwardR.Name = "ForwardR";
            this.ForwardR.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ForwardR.Size = new System.Drawing.Size(75, 25);
            this.ForwardR.TabIndex = 3;
            this.ForwardR.Text = "Forward";
            // 
            // ForwardL
            // 
            this.ForwardL.AutoSize = true;
            this.ForwardL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ForwardL.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForwardL.Location = new System.Drawing.Point(15, 67);
            this.ForwardL.Name = "ForwardL";
            this.ForwardL.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.ForwardL.Size = new System.Drawing.Size(75, 25);
            this.ForwardL.TabIndex = 2;
            this.ForwardL.Text = "Forward";
            // 
            // Direction
            // 
            this.Direction.BackColor = System.Drawing.SystemColors.Control;
            this.Direction.LargeChange = 0;
            this.Direction.Location = new System.Drawing.Point(92, 66);
            this.Direction.Maximum = 1;
            this.Direction.Minimum = -1;
            this.Direction.Name = "Direction";
            this.Direction.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Direction.Size = new System.Drawing.Size(45, 341);
            this.Direction.TabIndex = 0;
            this.Direction.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Direction.Scroll += new System.EventHandler(this.Direction_Scroll);
            this.Direction.Enter += new System.EventHandler(this.Direction_Enter);
            this.Direction.Leave += new System.EventHandler(this.Direction_Leave);
            // 
            // Power
            // 
            this.Power.BackColor = System.Drawing.SystemColors.Control;
            this.Power.LargeChange = 0;
            this.Power.Location = new System.Drawing.Point(287, 66);
            this.Power.Maximum = 5;
            this.Power.Minimum = -5;
            this.Power.Name = "Power";
            this.Power.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Power.Size = new System.Drawing.Size(45, 341);
            this.Power.TabIndex = 1;
            this.Power.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.Power.Scroll += new System.EventHandler(this.Power_Scroll);
            this.Power.Enter += new System.EventHandler(this.Power_Enter);
            this.Power.Leave += new System.EventHandler(this.Power_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.IndeApp);
            this.groupBox2.Controls.Add(this.AutoApp);
            this.groupBox2.Controls.Add(this.IFR);
            this.groupBox2.Controls.Add(this.AFR);
            this.groupBox2.Controls.Add(this.IHR);
            this.groupBox2.Controls.Add(this.AHR);
            this.groupBox2.Controls.Add(this.IFL);
            this.groupBox2.Controls.Add(this.IHL);
            this.groupBox2.Controls.Add(this.AFL);
            this.groupBox2.Controls.Add(this.AHL);
            this.groupBox2.Controls.Add(this.IndeActivibility);
            this.groupBox2.Controls.Add(this.AutoActivibility);
            this.groupBox2.Controls.Add(this.LblInde);
            this.groupBox2.Controls.Add(this.LblAuto);
            this.groupBox2.Controls.Add(this.IFull);
            this.groupBox2.Controls.Add(this.AFull);
            this.groupBox2.Controls.Add(this.IHalf);
            this.groupBox2.Controls.Add(this.AHalf);
            this.groupBox2.Controls.Add(this.IRelease);
            this.groupBox2.Controls.Add(this.ARelease);
            this.groupBox2.Controls.Add(this.AutoBrake);
            this.groupBox2.Controls.Add(this.IndeBrake);
            this.groupBox2.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(746, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 452);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brake System";
            // 
            // IndeApp
            // 
            this.IndeApp.AutoSize = true;
            this.IndeApp.BackColor = System.Drawing.Color.DarkOrange;
            this.IndeApp.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IndeApp.Location = new System.Drawing.Point(235, 31);
            this.IndeApp.Name = "IndeApp";
            this.IndeApp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IndeApp.Size = new System.Drawing.Size(78, 27);
            this.IndeApp.TabIndex = 23;
            this.IndeApp.Text = "Applied";
            // 
            // AutoApp
            // 
            this.AutoApp.AutoSize = true;
            this.AutoApp.BackColor = System.Drawing.Color.DarkOrange;
            this.AutoApp.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AutoApp.Location = new System.Drawing.Point(139, 31);
            this.AutoApp.Name = "AutoApp";
            this.AutoApp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoApp.Size = new System.Drawing.Size(78, 27);
            this.AutoApp.TabIndex = 22;
            this.AutoApp.Text = "Applied";
            // 
            // IFR
            // 
            this.IFR.BackColor = System.Drawing.SystemColors.Control;
            this.IFR.Location = new System.Drawing.Point(264, 88);
            this.IFR.Name = "IFR";
            this.IFR.Size = new System.Drawing.Size(14, 139);
            this.IFR.TabIndex = 21;
            // 
            // AFR
            // 
            this.AFR.BackColor = System.Drawing.SystemColors.Control;
            this.AFR.Location = new System.Drawing.Point(197, 87);
            this.AFR.Name = "AFR";
            this.AFR.Size = new System.Drawing.Size(14, 139);
            this.AFR.TabIndex = 17;
            // 
            // IHR
            // 
            this.IHR.BackColor = System.Drawing.SystemColors.Control;
            this.IHR.Location = new System.Drawing.Point(264, 244);
            this.IHR.Name = "IHR";
            this.IHR.Size = new System.Drawing.Size(14, 141);
            this.IHR.TabIndex = 19;
            // 
            // AHR
            // 
            this.AHR.BackColor = System.Drawing.SystemColors.Control;
            this.AHR.Location = new System.Drawing.Point(197, 244);
            this.AHR.Name = "AHR";
            this.AHR.Size = new System.Drawing.Size(14, 141);
            this.AHR.TabIndex = 15;
            // 
            // IFL
            // 
            this.IFL.BackColor = System.Drawing.SystemColors.Control;
            this.IFL.Location = new System.Drawing.Point(243, 88);
            this.IFL.Name = "IFL";
            this.IFL.Size = new System.Drawing.Size(13, 139);
            this.IFL.TabIndex = 20;
            // 
            // IHL
            // 
            this.IHL.BackColor = System.Drawing.SystemColors.Control;
            this.IHL.Location = new System.Drawing.Point(243, 244);
            this.IHL.Name = "IHL";
            this.IHL.Size = new System.Drawing.Size(13, 141);
            this.IHL.TabIndex = 18;
            // 
            // AFL
            // 
            this.AFL.BackColor = System.Drawing.SystemColors.Control;
            this.AFL.Location = new System.Drawing.Point(176, 87);
            this.AFL.Name = "AFL";
            this.AFL.Size = new System.Drawing.Size(13, 139);
            this.AFL.TabIndex = 16;
            // 
            // AHL
            // 
            this.AHL.BackColor = System.Drawing.SystemColors.Control;
            this.AHL.Location = new System.Drawing.Point(176, 244);
            this.AHL.Name = "AHL";
            this.AHL.Size = new System.Drawing.Size(13, 141);
            this.AHL.TabIndex = 14;
            // 
            // IndeActivibility
            // 
            this.IndeActivibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.IndeActivibility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IndeActivibility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IndeActivibility.Cursor = System.Windows.Forms.Cursors.Default;
            this.IndeActivibility.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IndeActivibility.ForeColor = System.Drawing.Color.Black;
            this.IndeActivibility.Location = new System.Drawing.Point(229, 420);
            this.IndeActivibility.Name = "IndeActivibility";
            this.IndeActivibility.ReadOnly = true;
            this.IndeActivibility.Size = new System.Drawing.Size(68, 22);
            this.IndeActivibility.TabIndex = 16;
            this.IndeActivibility.TabStop = false;
            this.IndeActivibility.Text = "Active";
            this.IndeActivibility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IndeActivibility.Click += new System.EventHandler(this.IndeActivibility_Click);
            // 
            // AutoActivibility
            // 
            this.AutoActivibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.AutoActivibility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AutoActivibility.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AutoActivibility.Cursor = System.Windows.Forms.Cursors.Default;
            this.AutoActivibility.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AutoActivibility.ForeColor = System.Drawing.Color.Black;
            this.AutoActivibility.Location = new System.Drawing.Point(160, 420);
            this.AutoActivibility.Name = "AutoActivibility";
            this.AutoActivibility.ReadOnly = true;
            this.AutoActivibility.Size = new System.Drawing.Size(68, 22);
            this.AutoActivibility.TabIndex = 15;
            this.AutoActivibility.TabStop = false;
            this.AutoActivibility.Text = "Active";
            this.AutoActivibility.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AutoActivibility.Click += new System.EventHandler(this.AutoActivibility_Click);
            // 
            // LblInde
            // 
            this.LblInde.AutoSize = true;
            this.LblInde.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblInde.Location = new System.Drawing.Point(385, 92);
            this.LblInde.Name = "LblInde";
            this.LblInde.Size = new System.Drawing.Size(20, 289);
            this.LblInde.TabIndex = 11;
            this.LblInde.Text = "I\r\nN\r\nD\r\nE\r\nP\r\nE\r\nN\r\nD\r\nE\r\nN\r\nT\r\n\r\nB\r\nR\r\nA\r\nK\r\nE";
            this.LblInde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblAuto
            // 
            this.LblAuto.AutoSize = true;
            this.LblAuto.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblAuto.Location = new System.Drawing.Point(49, 151);
            this.LblAuto.Name = "LblAuto";
            this.LblAuto.Size = new System.Drawing.Size(20, 170);
            this.LblAuto.TabIndex = 10;
            this.LblAuto.Text = "A\r\nU\r\nT\r\nO\r\n\r\nB\r\nR\r\nA\r\nK\r\nE";
            this.LblAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IFull
            // 
            this.IFull.AutoSize = true;
            this.IFull.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IFull.Location = new System.Drawing.Point(290, 68);
            this.IFull.Name = "IFull";
            this.IFull.Size = new System.Drawing.Size(42, 22);
            this.IFull.TabIndex = 9;
            this.IFull.Text = "Full";
            // 
            // AFull
            // 
            this.AFull.AutoSize = true;
            this.AFull.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AFull.Location = new System.Drawing.Point(124, 68);
            this.AFull.Name = "AFull";
            this.AFull.Size = new System.Drawing.Size(42, 22);
            this.AFull.TabIndex = 8;
            this.AFull.Text = "Full";
            // 
            // IHalf
            // 
            this.IHalf.AutoSize = true;
            this.IHalf.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IHalf.Location = new System.Drawing.Point(290, 224);
            this.IHalf.Name = "IHalf";
            this.IHalf.Size = new System.Drawing.Size(47, 22);
            this.IHalf.TabIndex = 7;
            this.IHalf.Text = "Half";
            // 
            // AHalf
            // 
            this.AHalf.AutoSize = true;
            this.AHalf.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AHalf.Location = new System.Drawing.Point(119, 224);
            this.AHalf.Name = "AHalf";
            this.AHalf.Size = new System.Drawing.Size(47, 22);
            this.AHalf.TabIndex = 6;
            this.AHalf.Text = "Half";
            // 
            // IRelease
            // 
            this.IRelease.AutoSize = true;
            this.IRelease.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IRelease.Location = new System.Drawing.Point(290, 382);
            this.IRelease.Name = "IRelease";
            this.IRelease.Size = new System.Drawing.Size(80, 22);
            this.IRelease.TabIndex = 5;
            this.IRelease.Text = "Release";
            // 
            // ARelease
            // 
            this.ARelease.AutoSize = true;
            this.ARelease.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ARelease.Location = new System.Drawing.Point(86, 382);
            this.ARelease.Name = "ARelease";
            this.ARelease.Size = new System.Drawing.Size(80, 22);
            this.ARelease.TabIndex = 4;
            this.ARelease.Text = "Release";
            // 
            // AutoBrake
            // 
            this.AutoBrake.BackColor = System.Drawing.SystemColors.Control;
            this.AutoBrake.LargeChange = 0;
            this.AutoBrake.Location = new System.Drawing.Point(172, 66);
            this.AutoBrake.Maximum = 2;
            this.AutoBrake.Name = "AutoBrake";
            this.AutoBrake.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.AutoBrake.Size = new System.Drawing.Size(45, 341);
            this.AutoBrake.TabIndex = 2;
            this.AutoBrake.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.AutoBrake.Scroll += new System.EventHandler(this.AutoBrake_Scroll);
            this.AutoBrake.Enter += new System.EventHandler(this.AutoBrake_Enter);
            this.AutoBrake.Leave += new System.EventHandler(this.AutoBrake_Leave);
            // 
            // IndeBrake
            // 
            this.IndeBrake.BackColor = System.Drawing.SystemColors.Control;
            this.IndeBrake.LargeChange = 0;
            this.IndeBrake.Location = new System.Drawing.Point(239, 66);
            this.IndeBrake.Maximum = 2;
            this.IndeBrake.Name = "IndeBrake";
            this.IndeBrake.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.IndeBrake.Size = new System.Drawing.Size(45, 341);
            this.IndeBrake.TabIndex = 3;
            this.IndeBrake.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.IndeBrake.Scroll += new System.EventHandler(this.IndeBrake_Scroll);
            this.IndeBrake.Enter += new System.EventHandler(this.IndeBrake_Enter);
            this.IndeBrake.Leave += new System.EventHandler(this.IndeBrake_Leave);
            // 
            // SCC
            // 
            this.SCC.AutoSize = true;
            this.SCC.Font = new System.Drawing.Font("等线", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SCC.Location = new System.Drawing.Point(496, 675);
            this.SCC.Name = "SCC";
            this.SCC.Size = new System.Drawing.Size(296, 33);
            this.SCC.TabIndex = 9;
            this.SCC.Text = "Self Check Complete";
            this.SCC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SCC.UseMnemonic = false;
            // 
            // SCing
            // 
            this.SCing.AutoSize = true;
            this.SCing.Font = new System.Drawing.Font("等线", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SCing.Location = new System.Drawing.Point(546, 675);
            this.SCing.Name = "SCing";
            this.SCing.Size = new System.Drawing.Size(198, 33);
            this.SCing.TabIndex = 10;
            this.SCing.Text = "Self Checking";
            this.SCing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SCing.UseMnemonic = false;
            // 
            // SCC_Cover
            // 
            this.SCC_Cover.BackColor = System.Drawing.SystemColors.Control;
            this.SCC_Cover.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SCC_Cover.Cursor = System.Windows.Forms.Cursors.Default;
            this.SCC_Cover.Location = new System.Drawing.Point(502, 675);
            this.SCC_Cover.Name = "SCC_Cover";
            this.SCC_Cover.ReadOnly = true;
            this.SCC_Cover.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.SCC_Cover.Size = new System.Drawing.Size(290, 30);
            this.SCC_Cover.TabIndex = 11;
            this.SCC_Cover.TabStop = false;
            this.SCC_Cover.Text = "";
            this.SCC_Cover.WordWrap = false;
            // 
            // PowerNum
            // 
            this.PowerNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PowerNum.CausesValidation = false;
            this.PowerNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.PowerNum.DetectUrls = false;
            this.PowerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerNum.ForeColor = System.Drawing.SystemColors.Info;
            this.PowerNum.HideSelection = false;
            this.PowerNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.PowerNum.Location = new System.Drawing.Point(594, 252);
            this.PowerNum.Multiline = false;
            this.PowerNum.Name = "PowerNum";
            this.PowerNum.ReadOnly = true;
            this.PowerNum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PowerNum.ShortcutsEnabled = false;
            this.PowerNum.Size = new System.Drawing.Size(106, 136);
            this.PowerNum.TabIndex = 12;
            this.PowerNum.TabStop = false;
            this.PowerNum.Text = "8";
            this.PowerNum.WordWrap = false;
            this.PowerNum.Enter += new System.EventHandler(this.PowerNum_Enter);
            // 
            // LblPowerLevel
            // 
            this.LblPowerLevel.AutoSize = true;
            this.LblPowerLevel.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblPowerLevel.Location = new System.Drawing.Point(587, 400);
            this.LblPowerLevel.Name = "LblPowerLevel";
            this.LblPowerLevel.Size = new System.Drawing.Size(120, 22);
            this.LblPowerLevel.TabIndex = 13;
            this.LblPowerLevel.Text = "Power Level";
            // 
            // BaudList
            // 
            this.BaudList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudList.FormattingEnabled = true;
            this.BaudList.Location = new System.Drawing.Point(162, 680);
            this.BaudList.Name = "BaudList";
            this.BaudList.Size = new System.Drawing.Size(121, 25);
            this.BaudList.TabIndex = 14;
            this.BaudList.TabStop = false;
            // 
            // PortList
            // 
            this.PortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(16, 680);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(121, 25);
            this.PortList.TabIndex = 15;
            this.PortList.TabStop = false;
            // 
            // LinkStart
            // 
            this.LinkStart.Location = new System.Drawing.Point(307, 680);
            this.LinkStart.Name = "LinkStart";
            this.LinkStart.Size = new System.Drawing.Size(121, 25);
            this.LinkStart.TabIndex = 16;
            this.LinkStart.TabStop = false;
            this.LinkStart.Text = "Connect";
            this.LinkStart.UseVisualStyleBackColor = true;
            this.LinkStart.Click += new System.EventHandler(this.LinkStart_Click);
            // 
            // serialPort
            // 
            this.serialPort.ReadTimeout = 2000;
            this.serialPort.WriteTimeout = 2000;
            // 
            // EBrake
            // 
            this.EBrake.BackColor = System.Drawing.SystemColors.Control;
            this.EBrake.Enabled = false;
            this.EBrake.ErrorImage = null;
            this.EBrake.Image = ((System.Drawing.Image)(resources.GetObject("EBrake.Image")));
            this.EBrake.InitialImage = ((System.Drawing.Image)(resources.GetObject("EBrake.InitialImage")));
            this.EBrake.Location = new System.Drawing.Point(552, 481);
            this.EBrake.Name = "EBrake";
            this.EBrake.Size = new System.Drawing.Size(188, 143);
            this.EBrake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EBrake.TabIndex = 17;
            this.EBrake.TabStop = false;
            this.EBrake.WaitOnLoad = true;
            this.EBrake.Click += new System.EventHandler(this.EBrake_Click);
            // 
            // LblCE
            // 
            this.LblCE.AutoSize = true;
            this.LblCE.BackColor = System.Drawing.Color.Orange;
            this.LblCE.Font = new System.Drawing.Font("等线", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblCE.Location = new System.Drawing.Point(474, 670);
            this.LblCE.Name = "LblCE";
            this.LblCE.Padding = new System.Windows.Forms.Padding(3);
            this.LblCE.Size = new System.Drawing.Size(339, 39);
            this.LblCE.TabIndex = 18;
            this.LblCE.Text = "Connection Established";
            this.LblCE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCE.Visible = false;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.LblCE);
            this.Controls.Add(this.EBrake);
            this.Controls.Add(this.LinkStart);
            this.Controls.Add(this.PortList);
            this.Controls.Add(this.BaudList);
            this.Controls.Add(this.LblPowerLevel);
            this.Controls.Add(this.PowerNum);
            this.Controls.Add(this.SCing);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SCC_Cover);
            this.Controls.Add(this.SCC);
            this.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ControlPanel";
            this.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locomotive Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlPanel_FormClosing);
            this.Load += new System.EventHandler(this.ControlPanel_Load);
            this.Shown += new System.EventHandler(this.ControlPanel_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Direction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoBrake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndeBrake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBrake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TrackBarNoBorder Direction;
        private TrackBarNoBorder Power;
        private TrackBarNoBorder AutoBrake;
        private TrackBarNoBorder IndeBrake;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ForwardL;
        private System.Windows.Forms.Label DYNAMICBRAKE;
        private System.Windows.Forms.Label FULLTHROTTLE;
        private System.Windows.Forms.Label IDLE;
        private System.Windows.Forms.Label ReverseR;
        private System.Windows.Forms.Label ReverseL;
        private System.Windows.Forms.Label NeutralR;
        private System.Windows.Forms.Label NeutralL;
        private System.Windows.Forms.Label ForwardR;
        private System.Windows.Forms.Label LblInde;
        private System.Windows.Forms.Label LblAuto;
        private System.Windows.Forms.Label IFull;
        private System.Windows.Forms.Label AFull;
        private System.Windows.Forms.Label IHalf;
        private System.Windows.Forms.Label AHalf;
        private System.Windows.Forms.Label IRelease;
        private System.Windows.Forms.Label ARelease;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel P5;
        private System.Windows.Forms.Panel P4;
        private System.Windows.Forms.Panel P3;
        private System.Windows.Forms.Panel P2;
        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Panel B1;
        private System.Windows.Forms.Panel B2;
        private System.Windows.Forms.Panel B3;
        private System.Windows.Forms.Panel B4;
        private System.Windows.Forms.Panel B5;
        private System.Windows.Forms.Label SCC;
        private System.Windows.Forms.TextBox DirectionActivibility;
        private System.Windows.Forms.TextBox PowerActivibility;
        private System.Windows.Forms.TextBox IndeActivibility;
        private System.Windows.Forms.TextBox AutoActivibility;
        private System.Windows.Forms.Label SCing;
        private System.Windows.Forms.RichTextBox SCC_Cover;
        private System.Windows.Forms.RichTextBox PowerNum;
        private System.Windows.Forms.Label LblPowerLevel;
        private System.Windows.Forms.Panel AHL;
        private System.Windows.Forms.Panel AFR;
        private System.Windows.Forms.Panel AHR;
        private System.Windows.Forms.Panel AFL;
        private System.Windows.Forms.Panel IFR;
        private System.Windows.Forms.Panel IHR;
        private System.Windows.Forms.Panel IFL;
        private System.Windows.Forms.Panel IHL;
        private System.Windows.Forms.Label IndeApp;
        private System.Windows.Forms.Label AutoApp;
        private System.Windows.Forms.Label PowerLock;
        private System.Windows.Forms.Label DirectionLock;
        private System.Windows.Forms.ComboBox BaudList;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.Button LinkStart;
        private System.Windows.Forms.PictureBox EBrake;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Label LblCE;
    }
}

