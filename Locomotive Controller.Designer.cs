
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
            this.PowerBox = new System.Windows.Forms.GroupBox();
            this.PowerActivibility = new System.Windows.Forms.Label();
            this.DirectionLock = new System.Windows.Forms.Label();
            this.PowerLock = new System.Windows.Forms.Label();
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
            this.DirectionActivibility = new System.Windows.Forms.Label();
            this.BrakeBox = new System.Windows.Forms.GroupBox();
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
            this.AutoActivibility = new System.Windows.Forms.Label();
            this.IndeActivibility = new System.Windows.Forms.Label();
            this.SCC = new System.Windows.Forms.Label();
            this.SCing = new System.Windows.Forms.Label();
            this.SCC_Cover = new System.Windows.Forms.RichTextBox();
            this.PowerNum = new System.Windows.Forms.RichTextBox();
            this.LblPowerLevel = new System.Windows.Forms.Label();
            this.BaudList = new System.Windows.Forms.ComboBox();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.LinkStart = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.LblCE = new System.Windows.Forms.Label();
            this.EBrake = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanDOWN = new System.Windows.Forms.Button();
            this.PanUP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BreakerOFF = new System.Windows.Forms.Button();
            this.BreakerON = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PowerBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Direction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).BeginInit();
            this.BrakeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoBrake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndeBrake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBrake)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // PowerBox
            // 
            this.PowerBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PowerBox.Controls.Add(this.PowerActivibility);
            this.PowerBox.Controls.Add(this.DirectionLock);
            this.PowerBox.Controls.Add(this.PowerLock);
            this.PowerBox.Controls.Add(this.B1);
            this.PowerBox.Controls.Add(this.B2);
            this.PowerBox.Controls.Add(this.P5);
            this.PowerBox.Controls.Add(this.P4);
            this.PowerBox.Controls.Add(this.B3);
            this.PowerBox.Controls.Add(this.P3);
            this.PowerBox.Controls.Add(this.P2);
            this.PowerBox.Controls.Add(this.B4);
            this.PowerBox.Controls.Add(this.P1);
            this.PowerBox.Controls.Add(this.B5);
            this.PowerBox.Controls.Add(this.progressBar2);
            this.PowerBox.Controls.Add(this.progressBar1);
            this.PowerBox.Controls.Add(this.DYNAMICBRAKE);
            this.PowerBox.Controls.Add(this.FULLTHROTTLE);
            this.PowerBox.Controls.Add(this.IDLE);
            this.PowerBox.Controls.Add(this.ReverseR);
            this.PowerBox.Controls.Add(this.ReverseL);
            this.PowerBox.Controls.Add(this.NeutralR);
            this.PowerBox.Controls.Add(this.NeutralL);
            this.PowerBox.Controls.Add(this.ForwardR);
            this.PowerBox.Controls.Add(this.ForwardL);
            this.PowerBox.Controls.Add(this.Direction);
            this.PowerBox.Controls.Add(this.Power);
            this.PowerBox.Controls.Add(this.DirectionActivibility);
            this.PowerBox.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PowerBox.Location = new System.Drawing.Point(80, 217);
            this.PowerBox.Name = "PowerBox";
            this.PowerBox.Size = new System.Drawing.Size(461, 452);
            this.PowerBox.TabIndex = 4;
            this.PowerBox.TabStop = false;
            this.PowerBox.Text = "Power Combined";
            // 
            // PowerActivibility
            // 
            this.PowerActivibility.AutoSize = true;
            this.PowerActivibility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PowerActivibility.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PowerActivibility.Location = new System.Drawing.Point(277, 420);
            this.PowerActivibility.Name = "PowerActivibility";
            this.PowerActivibility.Size = new System.Drawing.Size(66, 22);
            this.PowerActivibility.TabIndex = 1;
            this.PowerActivibility.Text = "Active";
            this.PowerActivibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PowerActivibility.Click += new System.EventHandler(this.PowerActivibility_Click);
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
            this.PowerLock.Location = new System.Drawing.Point(389, 221);
            this.PowerLock.Name = "PowerLock";
            this.PowerLock.Padding = new System.Windows.Forms.Padding(0, 4, 0, 3);
            this.PowerLock.Size = new System.Drawing.Size(69, 32);
            this.PowerLock.TabIndex = 16;
            this.PowerLock.Text = "LOCK";
            this.PowerLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.DYNAMICBRAKE.Location = new System.Drawing.Point(333, 369);
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
            this.FULLTHROTTLE.Location = new System.Drawing.Point(333, 54);
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
            this.IDLE.Location = new System.Drawing.Point(335, 221);
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
            // DirectionActivibility
            // 
            this.DirectionActivibility.AutoSize = true;
            this.DirectionActivibility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.DirectionActivibility.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DirectionActivibility.Location = new System.Drawing.Point(82, 420);
            this.DirectionActivibility.Name = "DirectionActivibility";
            this.DirectionActivibility.Size = new System.Drawing.Size(66, 22);
            this.DirectionActivibility.TabIndex = 0;
            this.DirectionActivibility.Text = "Active";
            this.DirectionActivibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DirectionActivibility.Click += new System.EventHandler(this.DirectionActivibility_Click);
            // 
            // BrakeBox
            // 
            this.BrakeBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BrakeBox.Controls.Add(this.IndeApp);
            this.BrakeBox.Controls.Add(this.AutoApp);
            this.BrakeBox.Controls.Add(this.IFR);
            this.BrakeBox.Controls.Add(this.AFR);
            this.BrakeBox.Controls.Add(this.IHR);
            this.BrakeBox.Controls.Add(this.AHR);
            this.BrakeBox.Controls.Add(this.IFL);
            this.BrakeBox.Controls.Add(this.IHL);
            this.BrakeBox.Controls.Add(this.AFL);
            this.BrakeBox.Controls.Add(this.AHL);
            this.BrakeBox.Controls.Add(this.LblInde);
            this.BrakeBox.Controls.Add(this.LblAuto);
            this.BrakeBox.Controls.Add(this.IFull);
            this.BrakeBox.Controls.Add(this.AFull);
            this.BrakeBox.Controls.Add(this.IHalf);
            this.BrakeBox.Controls.Add(this.AHalf);
            this.BrakeBox.Controls.Add(this.IRelease);
            this.BrakeBox.Controls.Add(this.ARelease);
            this.BrakeBox.Controls.Add(this.AutoBrake);
            this.BrakeBox.Controls.Add(this.IndeBrake);
            this.BrakeBox.Controls.Add(this.AutoActivibility);
            this.BrakeBox.Controls.Add(this.IndeActivibility);
            this.BrakeBox.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BrakeBox.Location = new System.Drawing.Point(743, 217);
            this.BrakeBox.Name = "BrakeBox";
            this.BrakeBox.Size = new System.Drawing.Size(461, 452);
            this.BrakeBox.TabIndex = 5;
            this.BrakeBox.TabStop = false;
            this.BrakeBox.Text = "Brake System";
            // 
            // IndeApp
            // 
            this.IndeApp.AutoSize = true;
            this.IndeApp.BackColor = System.Drawing.Color.DarkOrange;
            this.IndeApp.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IndeApp.Location = new System.Drawing.Point(238, 31);
            this.IndeApp.Name = "IndeApp";
            this.IndeApp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IndeApp.Size = new System.Drawing.Size(78, 27);
            this.IndeApp.TabIndex = 23;
            this.IndeApp.Text = "Applied";
            this.IndeApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoApp
            // 
            this.AutoApp.AutoSize = true;
            this.AutoApp.BackColor = System.Drawing.Color.DarkOrange;
            this.AutoApp.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AutoApp.Location = new System.Drawing.Point(142, 31);
            this.AutoApp.Name = "AutoApp";
            this.AutoApp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AutoApp.Size = new System.Drawing.Size(78, 27);
            this.AutoApp.TabIndex = 22;
            this.AutoApp.Text = "Applied";
            this.AutoApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IFR
            // 
            this.IFR.BackColor = System.Drawing.SystemColors.Control;
            this.IFR.Location = new System.Drawing.Point(267, 88);
            this.IFR.Name = "IFR";
            this.IFR.Size = new System.Drawing.Size(14, 139);
            this.IFR.TabIndex = 21;
            this.IFR.Click += new System.EventHandler(this.IFR_Click);
            // 
            // AFR
            // 
            this.AFR.BackColor = System.Drawing.SystemColors.Control;
            this.AFR.Location = new System.Drawing.Point(200, 87);
            this.AFR.Name = "AFR";
            this.AFR.Size = new System.Drawing.Size(14, 139);
            this.AFR.TabIndex = 17;
            this.AFR.Click += new System.EventHandler(this.AFR_Click);
            // 
            // IHR
            // 
            this.IHR.BackColor = System.Drawing.SystemColors.Control;
            this.IHR.Location = new System.Drawing.Point(267, 244);
            this.IHR.Name = "IHR";
            this.IHR.Size = new System.Drawing.Size(14, 141);
            this.IHR.TabIndex = 19;
            this.IHR.Click += new System.EventHandler(this.IHR_Click);
            // 
            // AHR
            // 
            this.AHR.BackColor = System.Drawing.SystemColors.Control;
            this.AHR.Location = new System.Drawing.Point(200, 244);
            this.AHR.Name = "AHR";
            this.AHR.Size = new System.Drawing.Size(14, 141);
            this.AHR.TabIndex = 15;
            this.AHR.Click += new System.EventHandler(this.AHR_Click);
            // 
            // IFL
            // 
            this.IFL.BackColor = System.Drawing.SystemColors.Control;
            this.IFL.Location = new System.Drawing.Point(246, 88);
            this.IFL.Name = "IFL";
            this.IFL.Size = new System.Drawing.Size(13, 139);
            this.IFL.TabIndex = 20;
            this.IFL.Click += new System.EventHandler(this.IFL_Click);
            // 
            // IHL
            // 
            this.IHL.BackColor = System.Drawing.SystemColors.Control;
            this.IHL.Location = new System.Drawing.Point(246, 244);
            this.IHL.Name = "IHL";
            this.IHL.Size = new System.Drawing.Size(13, 141);
            this.IHL.TabIndex = 18;
            this.IHL.Click += new System.EventHandler(this.IHL_Click);
            // 
            // AFL
            // 
            this.AFL.BackColor = System.Drawing.SystemColors.Control;
            this.AFL.Location = new System.Drawing.Point(179, 87);
            this.AFL.Name = "AFL";
            this.AFL.Size = new System.Drawing.Size(13, 139);
            this.AFL.TabIndex = 16;
            this.AFL.Click += new System.EventHandler(this.AFL_Click);
            // 
            // AHL
            // 
            this.AHL.BackColor = System.Drawing.SystemColors.Control;
            this.AHL.Location = new System.Drawing.Point(179, 244);
            this.AHL.Name = "AHL";
            this.AHL.Size = new System.Drawing.Size(13, 141);
            this.AHL.TabIndex = 14;
            this.AHL.Click += new System.EventHandler(this.AHL_Click);
            // 
            // LblInde
            // 
            this.LblInde.AutoSize = true;
            this.LblInde.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblInde.Location = new System.Drawing.Point(388, 92);
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
            this.LblAuto.Location = new System.Drawing.Point(52, 151);
            this.LblAuto.Name = "LblAuto";
            this.LblAuto.Size = new System.Drawing.Size(20, 170);
            this.LblAuto.TabIndex = 10;
            this.LblAuto.Text = "A\r\nU\r\nT\r\nO\r\n\r\nB\r\nR\r\nA\r\nK\r\nE";
            this.LblAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IFull
            // 
            this.IFull.AutoSize = true;
            this.IFull.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IFull.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IFull.Location = new System.Drawing.Point(291, 65);
            this.IFull.Name = "IFull";
            this.IFull.Padding = new System.Windows.Forms.Padding(3);
            this.IFull.Size = new System.Drawing.Size(48, 28);
            this.IFull.TabIndex = 9;
            this.IFull.Text = "Full";
            // 
            // AFull
            // 
            this.AFull.AutoSize = true;
            this.AFull.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AFull.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AFull.Location = new System.Drawing.Point(123, 65);
            this.AFull.Name = "AFull";
            this.AFull.Padding = new System.Windows.Forms.Padding(3);
            this.AFull.Size = new System.Drawing.Size(48, 28);
            this.AFull.TabIndex = 8;
            this.AFull.Text = "Full";
            // 
            // IHalf
            // 
            this.IHalf.AutoSize = true;
            this.IHalf.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IHalf.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IHalf.Location = new System.Drawing.Point(291, 223);
            this.IHalf.Name = "IHalf";
            this.IHalf.Padding = new System.Windows.Forms.Padding(3);
            this.IHalf.Size = new System.Drawing.Size(53, 28);
            this.IHalf.TabIndex = 7;
            this.IHalf.Text = "Half";
            // 
            // AHalf
            // 
            this.AHalf.AutoSize = true;
            this.AHalf.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AHalf.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AHalf.Location = new System.Drawing.Point(118, 223);
            this.AHalf.Name = "AHalf";
            this.AHalf.Padding = new System.Windows.Forms.Padding(3);
            this.AHalf.Size = new System.Drawing.Size(53, 28);
            this.AHalf.TabIndex = 6;
            this.AHalf.Text = "Half";
            // 
            // IRelease
            // 
            this.IRelease.AutoSize = true;
            this.IRelease.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IRelease.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IRelease.Location = new System.Drawing.Point(291, 380);
            this.IRelease.Name = "IRelease";
            this.IRelease.Padding = new System.Windows.Forms.Padding(3);
            this.IRelease.Size = new System.Drawing.Size(86, 28);
            this.IRelease.TabIndex = 5;
            this.IRelease.Text = "Release";
            // 
            // ARelease
            // 
            this.ARelease.AutoSize = true;
            this.ARelease.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ARelease.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ARelease.Location = new System.Drawing.Point(85, 380);
            this.ARelease.Name = "ARelease";
            this.ARelease.Padding = new System.Windows.Forms.Padding(3);
            this.ARelease.Size = new System.Drawing.Size(86, 28);
            this.ARelease.TabIndex = 4;
            this.ARelease.Text = "Release";
            // 
            // AutoBrake
            // 
            this.AutoBrake.BackColor = System.Drawing.SystemColors.Control;
            this.AutoBrake.LargeChange = 0;
            this.AutoBrake.Location = new System.Drawing.Point(175, 66);
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
            this.IndeBrake.Location = new System.Drawing.Point(242, 66);
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
            // AutoActivibility
            // 
            this.AutoActivibility.AutoSize = true;
            this.AutoActivibility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AutoActivibility.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AutoActivibility.Location = new System.Drawing.Point(165, 420);
            this.AutoActivibility.Name = "AutoActivibility";
            this.AutoActivibility.Size = new System.Drawing.Size(66, 22);
            this.AutoActivibility.TabIndex = 2;
            this.AutoActivibility.Text = "Active";
            this.AutoActivibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AutoActivibility.Click += new System.EventHandler(this.AutoActivibility_Click);
            // 
            // IndeActivibility
            // 
            this.IndeActivibility.AutoSize = true;
            this.IndeActivibility.BackColor = System.Drawing.SystemColors.ControlLight;
            this.IndeActivibility.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IndeActivibility.Location = new System.Drawing.Point(234, 420);
            this.IndeActivibility.Name = "IndeActivibility";
            this.IndeActivibility.Size = new System.Drawing.Size(66, 22);
            this.IndeActivibility.TabIndex = 3;
            this.IndeActivibility.Text = "Active";
            this.IndeActivibility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IndeActivibility.Click += new System.EventHandler(this.IndeActivibility_Click);
            // 
            // SCC
            // 
            this.SCC.AutoSize = true;
            this.SCC.Font = new System.Drawing.Font("等线", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SCC.Location = new System.Drawing.Point(494, 675);
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
            this.SCing.Location = new System.Drawing.Point(543, 675);
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
            this.SCC_Cover.Location = new System.Drawing.Point(497, 675);
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
            this.PowerNum.Location = new System.Drawing.Point(589, 252);
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
            this.LblPowerLevel.Location = new System.Drawing.Point(582, 400);
            this.LblPowerLevel.Name = "LblPowerLevel";
            this.LblPowerLevel.Size = new System.Drawing.Size(120, 22);
            this.LblPowerLevel.TabIndex = 13;
            this.LblPowerLevel.Text = "Power Level";
            // 
            // BaudList
            // 
            this.BaudList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaudList.FormattingEnabled = true;
            this.BaudList.Location = new System.Drawing.Point(161, 680);
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
            this.LinkStart.Location = new System.Drawing.Point(306, 680);
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
            // LblCE
            // 
            this.LblCE.AutoSize = true;
            this.LblCE.BackColor = System.Drawing.Color.Orange;
            this.LblCE.Font = new System.Drawing.Font("等线", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LblCE.Location = new System.Drawing.Point(473, 670);
            this.LblCE.Name = "LblCE";
            this.LblCE.Padding = new System.Windows.Forms.Padding(3);
            this.LblCE.Size = new System.Drawing.Size(339, 39);
            this.LblCE.TabIndex = 18;
            this.LblCE.Text = "Connection Established";
            this.LblCE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCE.Visible = false;
            // 
            // EBrake
            // 
            this.EBrake.BackColor = System.Drawing.SystemColors.Control;
            this.EBrake.Enabled = false;
            this.EBrake.ErrorImage = null;
            this.EBrake.Image = ((System.Drawing.Image)(resources.GetObject("EBrake.Image")));
            this.EBrake.InitialImage = ((System.Drawing.Image)(resources.GetObject("EBrake.InitialImage")));
            this.EBrake.Location = new System.Drawing.Point(548, 481);
            this.EBrake.Name = "EBrake";
            this.EBrake.Size = new System.Drawing.Size(188, 143);
            this.EBrake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EBrake.TabIndex = 17;
            this.EBrake.TabStop = false;
            this.EBrake.WaitOnLoad = true;
            this.EBrake.Click += new System.EventHandler(this.EBrake_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PanDOWN);
            this.groupBox1.Controls.Add(this.PanUP);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 158);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pantograph";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOWN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanDOWN
            // 
            this.PanDOWN.Location = new System.Drawing.Point(6, 110);
            this.PanDOWN.Margin = new System.Windows.Forms.Padding(4);
            this.PanDOWN.Name = "PanDOWN";
            this.PanDOWN.Size = new System.Drawing.Size(118, 35);
            this.PanDOWN.TabIndex = 2;
            this.PanDOWN.TabStop = false;
            this.PanDOWN.Text = "LOWER";
            this.PanDOWN.UseVisualStyleBackColor = true;
            // 
            // PanUP
            // 
            this.PanUP.Location = new System.Drawing.Point(6, 67);
            this.PanUP.Margin = new System.Windows.Forms.Padding(4);
            this.PanUP.Name = "PanUP";
            this.PanUP.Size = new System.Drawing.Size(118, 35);
            this.PanUP.TabIndex = 1;
            this.PanUP.TabStop = false;
            this.PanUP.Text = "RAISE";
            this.PanUP.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BreakerOFF);
            this.groupBox2.Controls.Add(this.BreakerON);
            this.groupBox2.Location = new System.Drawing.Point(170, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 158);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Main Breaker";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "POWER OFF";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BreakerOFF
            // 
            this.BreakerOFF.Location = new System.Drawing.Point(6, 110);
            this.BreakerOFF.Margin = new System.Windows.Forms.Padding(4);
            this.BreakerOFF.Name = "BreakerOFF";
            this.BreakerOFF.Size = new System.Drawing.Size(118, 35);
            this.BreakerOFF.TabIndex = 5;
            this.BreakerOFF.TabStop = false;
            this.BreakerOFF.Text = "BREAK DOWN";
            this.BreakerOFF.UseVisualStyleBackColor = true;
            // 
            // BreakerON
            // 
            this.BreakerON.Location = new System.Drawing.Point(6, 67);
            this.BreakerON.Margin = new System.Windows.Forms.Padding(4);
            this.BreakerON.Name = "BreakerON";
            this.BreakerON.Size = new System.Drawing.Size(118, 35);
            this.BreakerON.TabIndex = 4;
            this.BreakerON.TabStop = false;
            this.BreakerON.Text = "CLOSE UP";
            this.BreakerON.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(312, 24);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(324, 158);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Main Signal";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(648, 24);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(324, 158);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Distant Signal";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(984, 24);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 158);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Switch";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(1126, 24);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(130, 158);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Warnings";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Arial", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(112, 125);
            this.label3.TabIndex = 0;
            this.label3.Text = "X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.MediumOrchid;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(12, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Battery Low";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkOrange;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(12, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pantograph";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(12, 72);
            this.label6.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Force Stop";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Olive;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(12, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Step Lost";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkCyan;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Ivory;
            this.label8.Location = new System.Drawing.Point(12, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Signal Lost";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EBrake);
            this.Controls.Add(this.LinkStart);
            this.Controls.Add(this.PortList);
            this.Controls.Add(this.BaudList);
            this.Controls.Add(this.LblPowerLevel);
            this.Controls.Add(this.PowerNum);
            this.Controls.Add(this.PowerBox);
            this.Controls.Add(this.BrakeBox);
            this.Controls.Add(this.LblCE);
            this.Controls.Add(this.SCing);
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
            this.PowerBox.ResumeLayout(false);
            this.PowerBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Direction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).EndInit();
            this.BrakeBox.ResumeLayout(false);
            this.BrakeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoBrake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndeBrake)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EBrake)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TrackBarNoBorder Direction;
        private TrackBarNoBorder Power;
        private TrackBarNoBorder AutoBrake;
        private TrackBarNoBorder IndeBrake;
        private System.Windows.Forms.GroupBox PowerBox;
        private System.Windows.Forms.GroupBox BrakeBox;
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
        private System.Windows.Forms.Label DirectionActivibility;
        private System.Windows.Forms.Label PowerActivibility;
        private System.Windows.Forms.Label AutoActivibility;
        private System.Windows.Forms.Label IndeActivibility;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button PanDOWN;
        private System.Windows.Forms.Button PanUP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BreakerOFF;
        private System.Windows.Forms.Button BreakerON;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

