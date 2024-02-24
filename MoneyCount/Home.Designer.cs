namespace MoneyCount
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btn200 = new Button();
            lbl200 = new Label();
            lblC200Cnt = new Label();
            lblC200Value = new Label();
            lblC100Value = new Label();
            lblC100Cnt = new Label();
            lbl100 = new Label();
            btn100 = new Button();
            lblC50Value = new Label();
            lblC50Cnt = new Label();
            lbl50 = new Label();
            btn50 = new Button();
            lblC20Value = new Label();
            lblC20Cnt = new Label();
            lbl20 = new Label();
            btn20 = new Button();
            lblC10Value = new Label();
            lblC10Cnt = new Label();
            lbl10 = new Label();
            btn10 = new Button();
            lblC5Value = new Label();
            lblC5Cnt = new Label();
            lbl5 = new Label();
            btn5 = new Button();
            lblC2Value = new Label();
            lblC2Cnt = new Label();
            lbl2 = new Label();
            btn2 = new Button();
            lblC1Value = new Label();
            lblC1Cnt = new Label();
            lbl1 = new Label();
            btn1 = new Button();
            btnAbout = new Button();
            btn200D = new Button();
            lblTotal = new Label();
            btn100D = new Button();
            btn50D = new Button();
            btn20D = new Button();
            btn10D = new Button();
            btn5D = new Button();
            btn2D = new Button();
            btn1D = new Button();
            tDown = new System.Windows.Forms.Timer(components);
            tWait = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn200
            // 
            resources.ApplyResources(btn200, "btn200");
            btn200.Name = "btn200";
            btn200.Tag = "C200";
            btn200.UseVisualStyleBackColor = true;
            btn200.Click += MoneyIncrement;
            btn200.MouseDown += QuickIncrementDown;
            btn200.MouseUp += QuickIncrementUp;
            // 
            // lbl200
            // 
            resources.ApplyResources(lbl200, "lbl200");
            lbl200.ForeColor = Color.FromArgb(59, 130, 246);
            lbl200.Name = "lbl200";
            // 
            // lblC200Cnt
            // 
            resources.ApplyResources(lblC200Cnt, "lblC200Cnt");
            lblC200Cnt.Name = "lblC200Cnt";
            // 
            // lblC200Value
            // 
            resources.ApplyResources(lblC200Value, "lblC200Value");
            lblC200Value.Name = "lblC200Value";
            lblC200Value.Tag = "2";
            // 
            // lblC100Value
            // 
            resources.ApplyResources(lblC100Value, "lblC100Value");
            lblC100Value.Name = "lblC100Value";
            lblC100Value.Tag = "1";
            // 
            // lblC100Cnt
            // 
            resources.ApplyResources(lblC100Cnt, "lblC100Cnt");
            lblC100Cnt.Name = "lblC100Cnt";
            // 
            // lbl100
            // 
            resources.ApplyResources(lbl100, "lbl100");
            lbl100.ForeColor = Color.FromArgb(20, 184, 166);
            lbl100.Name = "lbl100";
            // 
            // btn100
            // 
            resources.ApplyResources(btn100, "btn100");
            btn100.Name = "btn100";
            btn100.Tag = "C100";
            btn100.UseVisualStyleBackColor = true;
            btn100.Click += MoneyIncrement;
            btn100.MouseDown += QuickIncrementDown;
            btn100.MouseUp += QuickIncrementUp;
            // 
            // lblC50Value
            // 
            resources.ApplyResources(lblC50Value, "lblC50Value");
            lblC50Value.Name = "lblC50Value";
            lblC50Value.Tag = "0,5";
            // 
            // lblC50Cnt
            // 
            resources.ApplyResources(lblC50Cnt, "lblC50Cnt");
            lblC50Cnt.Name = "lblC50Cnt";
            // 
            // lbl50
            // 
            resources.ApplyResources(lbl50, "lbl50");
            lbl50.ForeColor = Color.FromArgb(34, 197, 94);
            lbl50.Name = "lbl50";
            // 
            // btn50
            // 
            resources.ApplyResources(btn50, "btn50");
            btn50.Name = "btn50";
            btn50.Tag = "C50";
            btn50.UseVisualStyleBackColor = true;
            btn50.Click += MoneyIncrement;
            btn50.MouseDown += QuickIncrementDown;
            btn50.MouseUp += QuickIncrementUp;
            // 
            // lblC20Value
            // 
            resources.ApplyResources(lblC20Value, "lblC20Value");
            lblC20Value.Name = "lblC20Value";
            lblC20Value.Tag = "0,2";
            // 
            // lblC20Cnt
            // 
            resources.ApplyResources(lblC20Cnt, "lblC20Cnt");
            lblC20Cnt.Name = "lblC20Cnt";
            // 
            // lbl20
            // 
            resources.ApplyResources(lbl20, "lbl20");
            lbl20.ForeColor = Color.FromArgb(234, 179, 8);
            lbl20.Name = "lbl20";
            // 
            // btn20
            // 
            resources.ApplyResources(btn20, "btn20");
            btn20.Name = "btn20";
            btn20.Tag = "C20";
            btn20.UseVisualStyleBackColor = true;
            btn20.Click += MoneyIncrement;
            btn20.MouseDown += QuickIncrementDown;
            btn20.MouseUp += QuickIncrementUp;
            // 
            // lblC10Value
            // 
            resources.ApplyResources(lblC10Value, "lblC10Value");
            lblC10Value.Name = "lblC10Value";
            lblC10Value.Tag = "0,1";
            // 
            // lblC10Cnt
            // 
            resources.ApplyResources(lblC10Cnt, "lblC10Cnt");
            lblC10Cnt.Name = "lblC10Cnt";
            // 
            // lbl10
            // 
            resources.ApplyResources(lbl10, "lbl10");
            lbl10.ForeColor = Color.FromArgb(249, 115, 22);
            lbl10.Name = "lbl10";
            // 
            // btn10
            // 
            resources.ApplyResources(btn10, "btn10");
            btn10.Name = "btn10";
            btn10.Tag = "C10";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += MoneyIncrement;
            btn10.MouseDown += QuickIncrementDown;
            btn10.MouseUp += QuickIncrementUp;
            // 
            // lblC5Value
            // 
            resources.ApplyResources(lblC5Value, "lblC5Value");
            lblC5Value.Name = "lblC5Value";
            lblC5Value.Tag = "0,05";
            // 
            // lblC5Cnt
            // 
            resources.ApplyResources(lblC5Cnt, "lblC5Cnt");
            lblC5Cnt.Name = "lblC5Cnt";
            // 
            // lbl5
            // 
            resources.ApplyResources(lbl5, "lbl5");
            lbl5.ForeColor = Color.FromArgb(239, 68, 68);
            lbl5.Name = "lbl5";
            // 
            // btn5
            // 
            resources.ApplyResources(btn5, "btn5");
            btn5.Name = "btn5";
            btn5.Tag = "C5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += MoneyIncrement;
            btn5.MouseDown += QuickIncrementDown;
            btn5.MouseUp += QuickIncrementUp;
            // 
            // lblC2Value
            // 
            resources.ApplyResources(lblC2Value, "lblC2Value");
            lblC2Value.Name = "lblC2Value";
            lblC2Value.Tag = "0,02";
            // 
            // lblC2Cnt
            // 
            resources.ApplyResources(lblC2Cnt, "lblC2Cnt");
            lblC2Cnt.Name = "lblC2Cnt";
            // 
            // lbl2
            // 
            resources.ApplyResources(lbl2, "lbl2");
            lbl2.ForeColor = Color.FromArgb(236, 72, 153);
            lbl2.Name = "lbl2";
            // 
            // btn2
            // 
            resources.ApplyResources(btn2, "btn2");
            btn2.Name = "btn2";
            btn2.Tag = "C2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += MoneyIncrement;
            btn2.MouseDown += QuickIncrementDown;
            btn2.MouseUp += QuickIncrementUp;
            // 
            // lblC1Value
            // 
            resources.ApplyResources(lblC1Value, "lblC1Value");
            lblC1Value.Name = "lblC1Value";
            lblC1Value.Tag = "0,01";
            // 
            // lblC1Cnt
            // 
            resources.ApplyResources(lblC1Cnt, "lblC1Cnt");
            lblC1Cnt.Name = "lblC1Cnt";
            // 
            // lbl1
            // 
            resources.ApplyResources(lbl1, "lbl1");
            lbl1.ForeColor = Color.FromArgb(168, 85, 247);
            lbl1.Name = "lbl1";
            // 
            // btn1
            // 
            resources.ApplyResources(btn1, "btn1");
            btn1.Name = "btn1";
            btn1.Tag = "C1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += MoneyIncrement;
            btn1.MouseDown += QuickIncrementDown;
            btn1.MouseUp += QuickIncrementUp;
            // 
            // btnAbout
            // 
            resources.ApplyResources(btnAbout, "btnAbout");
            btnAbout.Name = "btnAbout";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btn200D
            // 
            resources.ApplyResources(btn200D, "btn200D");
            btn200D.Name = "btn200D";
            btn200D.Tag = "C200";
            btn200D.UseVisualStyleBackColor = true;
            btn200D.Click += MoneyDecrement;
            btn200D.MouseDown += QuickDecrementDown;
            btn200D.MouseUp += QuickDecrementUp;
            // 
            // lblTotal
            // 
            resources.ApplyResources(lblTotal, "lblTotal");
            lblTotal.Name = "lblTotal";
            // 
            // btn100D
            // 
            resources.ApplyResources(btn100D, "btn100D");
            btn100D.Name = "btn100D";
            btn100D.Tag = "C100";
            btn100D.UseVisualStyleBackColor = true;
            btn100D.Click += MoneyDecrement;
            btn100D.MouseDown += QuickDecrementDown;
            btn100D.MouseUp += QuickDecrementUp;
            // 
            // btn50D
            // 
            resources.ApplyResources(btn50D, "btn50D");
            btn50D.Name = "btn50D";
            btn50D.Tag = "C50";
            btn50D.UseVisualStyleBackColor = true;
            btn50D.Click += MoneyDecrement;
            btn50D.MouseDown += QuickDecrementDown;
            btn50D.MouseUp += QuickDecrementUp;
            // 
            // btn20D
            // 
            resources.ApplyResources(btn20D, "btn20D");
            btn20D.Name = "btn20D";
            btn20D.Tag = "C20";
            btn20D.UseVisualStyleBackColor = true;
            btn20D.Click += MoneyDecrement;
            btn20D.MouseDown += QuickDecrementDown;
            btn20D.MouseUp += QuickDecrementUp;
            // 
            // btn10D
            // 
            resources.ApplyResources(btn10D, "btn10D");
            btn10D.Name = "btn10D";
            btn10D.Tag = "C10";
            btn10D.UseVisualStyleBackColor = true;
            btn10D.Click += MoneyDecrement;
            btn10D.MouseDown += QuickDecrementDown;
            btn10D.MouseUp += QuickDecrementUp;
            // 
            // btn5D
            // 
            resources.ApplyResources(btn5D, "btn5D");
            btn5D.Name = "btn5D";
            btn5D.Tag = "C5";
            btn5D.UseVisualStyleBackColor = true;
            btn5D.Click += MoneyDecrement;
            btn5D.MouseDown += QuickDecrementDown;
            btn5D.MouseUp += QuickDecrementUp;
            // 
            // btn2D
            // 
            resources.ApplyResources(btn2D, "btn2D");
            btn2D.Name = "btn2D";
            btn2D.Tag = "C2";
            btn2D.UseVisualStyleBackColor = true;
            btn2D.Click += MoneyDecrement;
            btn2D.MouseDown += QuickDecrementDown;
            btn2D.MouseUp += QuickDecrementUp;
            // 
            // btn1D
            // 
            resources.ApplyResources(btn1D, "btn1D");
            btn1D.Name = "btn1D";
            btn1D.Tag = "C1";
            btn1D.UseVisualStyleBackColor = true;
            btn1D.Click += MoneyDecrement;
            btn1D.MouseDown += QuickDecrementDown;
            btn1D.MouseUp += QuickDecrementUp;
            // 
            // tDown
            // 
            tDown.Interval = 80;
            // 
            // tWait
            // 
            tWait.Interval = 500;
            tWait.Tick += tWait_Tick;
            // 
            // Home
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn1D);
            Controls.Add(btn2D);
            Controls.Add(btn5D);
            Controls.Add(btn10D);
            Controls.Add(btn20D);
            Controls.Add(btn50D);
            Controls.Add(btn100D);
            Controls.Add(lblTotal);
            Controls.Add(btn200D);
            Controls.Add(btnAbout);
            Controls.Add(lblC1Value);
            Controls.Add(lblC1Cnt);
            Controls.Add(lbl1);
            Controls.Add(btn1);
            Controls.Add(lblC2Value);
            Controls.Add(lblC2Cnt);
            Controls.Add(lbl2);
            Controls.Add(btn2);
            Controls.Add(lblC5Value);
            Controls.Add(lblC5Cnt);
            Controls.Add(lbl5);
            Controls.Add(btn5);
            Controls.Add(lblC10Value);
            Controls.Add(lblC10Cnt);
            Controls.Add(lbl10);
            Controls.Add(btn10);
            Controls.Add(lblC20Value);
            Controls.Add(lblC20Cnt);
            Controls.Add(lbl20);
            Controls.Add(btn20);
            Controls.Add(lblC50Value);
            Controls.Add(lblC50Cnt);
            Controls.Add(lbl50);
            Controls.Add(btn50);
            Controls.Add(lblC100Value);
            Controls.Add(lblC100Cnt);
            Controls.Add(lbl100);
            Controls.Add(btn100);
            Controls.Add(lblC200Value);
            Controls.Add(lblC200Cnt);
            Controls.Add(lbl200);
            Controls.Add(btn200);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Home";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn200;
        private Label lbl200;
        private Label lblC200Cnt;
        private Label lblC200Value;
        private Label lblC100Value;
        private Label lblC100Cnt;
        private Label lbl100;
        private Button btn100;
        private Label lblC50Value;
        private Label lblC50Cnt;
        private Label lbl50;
        private Button btn50;
        private Label lblC20Value;
        private Label lblC20Cnt;
        private Label lbl20;
        private Button btn20;
        private Label lblC10Value;
        private Label lblC10Cnt;
        private Label lbl10;
        private Button btn10;
        private Label lblC5Value;
        private Label lblC5Cnt;
        private Label lbl5;
        private Button btn5;
        private Label lblC2Value;
        private Label lblC2Cnt;
        private Label lbl2;
        private Button btn2;
        private Label lblC1Value;
        private Label lblC1Cnt;
        private Label lbl1;
        private Button btn1;
        private Button btnAbout;
        private Button btn200D;
        private Label lblTotal;
        private Button btn100D;
        private Button btn50D;
        private Button btn20D;
        private Button btn10D;
        private Button btn5D;
        private Button btn2D;
        private Button btn1D;
        private System.Windows.Forms.Timer tDown;
        private System.Windows.Forms.Timer tWait;
    }
}