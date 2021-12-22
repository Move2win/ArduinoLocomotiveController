
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.IndeActivibility = new System.Windows.Forms.TextBox();
            this.AutoActivibility = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Direction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Power)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoBrake)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IndeBrake)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
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
            this.DYNAMICBRAKE.Location = new System.Drawing.Point(332, 368);
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
            this.FULLTHROTTLE.Location = new System.Drawing.Point(332, 53);
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
            this.IDLE.Location = new System.Drawing.Point(338, 224);
            this.IDLE.Name = "IDLE";
            this.IDLE.Size = new System.Drawing.Size(58, 25);
            this.IDLE.TabIndex = 8;
            this.IDLE.Text = "IDLE";
            // 
            // ReverseR
            // 
            this.ReverseR.AutoSize = true;
            this.ReverseR.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReverseR.Location = new System.Drawing.Point(138, 385);
            this.ReverseR.Name = "ReverseR";
            this.ReverseR.Size = new System.Drawing.Size(73, 19);
            this.ReverseR.TabIndex = 7;
            this.ReverseR.Text = "Reverse";
            // 
            // ReverseL
            // 
            this.ReverseL.AutoSize = true;
            this.ReverseL.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReverseL.Location = new System.Drawing.Point(17, 385);
            this.ReverseL.Name = "ReverseL";
            this.ReverseL.Size = new System.Drawing.Size(73, 19);
            this.ReverseL.TabIndex = 6;
            this.ReverseL.Text = "Reverse";
            // 
            // NeutralR
            // 
            this.NeutralR.AutoSize = true;
            this.NeutralR.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NeutralR.Location = new System.Drawing.Point(138, 228);
            this.NeutralR.Name = "NeutralR";
            this.NeutralR.Size = new System.Drawing.Size(69, 19);
            this.NeutralR.TabIndex = 5;
            this.NeutralR.Text = "Neutral";
            // 
            // NeutralL
            // 
            this.NeutralL.AutoSize = true;
            this.NeutralL.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NeutralL.Location = new System.Drawing.Point(21, 228);
            this.NeutralL.Name = "NeutralL";
            this.NeutralL.Size = new System.Drawing.Size(69, 19);
            this.NeutralL.TabIndex = 4;
            this.NeutralL.Text = "Neutral";
            // 
            // ForwardR
            // 
            this.ForwardR.AutoSize = true;
            this.ForwardR.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForwardR.Location = new System.Drawing.Point(138, 70);
            this.ForwardR.Name = "ForwardR";
            this.ForwardR.Size = new System.Drawing.Size(75, 19);
            this.ForwardR.TabIndex = 3;
            this.ForwardR.Text = "Forward";
            // 
            // ForwardL
            // 
            this.ForwardL.AutoSize = true;
            this.ForwardL.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ForwardL.Font = new System.Drawing.Font("等线", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForwardL.Location = new System.Drawing.Point(15, 70);
            this.ForwardL.Name = "ForwardL";
            this.ForwardL.Size = new System.Drawing.Size(75, 19);
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
            this.groupBox2.Controls.Add(this.IndeActivibility);
            this.groupBox2.Controls.Add(this.AutoActivibility);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.IFull);
            this.groupBox2.Controls.Add(this.AFull);
            this.groupBox2.Controls.Add(this.IHalf);
            this.groupBox2.Controls.Add(this.AHalf);
            this.groupBox2.Controls.Add(this.IRelease);
            this.groupBox2.Controls.Add(this.ARelease);
            this.groupBox2.Controls.Add(this.AutoBrake);
            this.groupBox2.Controls.Add(this.IndeBrake);
            this.groupBox2.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(745, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 452);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Brake System";
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
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(385, 92);
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
            this.label16.Location = new System.Drawing.Point(49, 151);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(20, 170);
            this.label16.TabIndex = 10;
            this.label16.Text = "A\r\nU\r\nT\r\nO\r\n\r\nB\r\nR\r\nA\r\nK\r\nE";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.SCC.Location = new System.Drawing.Point(496, 672);
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
            this.SCing.Location = new System.Drawing.Point(546, 672);
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
            this.PowerNum.Cursor = System.Windows.Forms.Cursors.Default;
            this.PowerNum.Font = new System.Drawing.Font("DigifaceWide", 75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerNum.ForeColor = System.Drawing.SystemColors.Info;
            this.PowerNum.Location = new System.Drawing.Point(594, 252);
            this.PowerNum.Multiline = false;
            this.PowerNum.Name = "PowerNum";
            this.PowerNum.ReadOnly = true;
            this.PowerNum.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PowerNum.ShortcutsEnabled = false;
            this.PowerNum.Size = new System.Drawing.Size(104, 136);
            this.PowerNum.TabIndex = 12;
            this.PowerNum.TabStop = false;
            this.PowerNum.Text = "8";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("等线", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(587, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Power Level";
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1284, 711);
            this.Controls.Add(this.label1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locomotive Controller";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TrackBarNoBorder Direction;
        private TrackBarNoBorder Power;
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label IFull;
        private System.Windows.Forms.Label AFull;
        private System.Windows.Forms.Label IHalf;
        private System.Windows.Forms.Label AHalf;
        private System.Windows.Forms.Label IRelease;
        private System.Windows.Forms.Label ARelease;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel P1;
        private System.Windows.Forms.Panel P5;
        private System.Windows.Forms.Panel P4;
        private System.Windows.Forms.Panel P3;
        private System.Windows.Forms.Panel P2;
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
        private TrackBarNoBorder AutoBrake;
        private TrackBarNoBorder IndeBrake;
        private System.Windows.Forms.Label SCing;
        private System.Windows.Forms.RichTextBox SCC_Cover;
        private System.Windows.Forms.RichTextBox PowerNum;
        private System.Windows.Forms.Label label1;
    }
}

