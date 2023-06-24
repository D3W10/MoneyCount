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
            btn200.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn200.Location = new Point(140, 25);
            btn200.Name = "btn200";
            btn200.Size = new Size(55, 55);
            btn200.TabIndex = 0;
            btn200.Tag = "C200";
            btn200.Text = "+1";
            btn200.UseVisualStyleBackColor = true;
            btn200.Click += MoneyIncrement;
            btn200.MouseDown += QuickIncrementDown;
            btn200.MouseUp += QuickIncrementUp;
            // 
            // lbl200
            // 
            lbl200.AutoSize = true;
            lbl200.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl200.ForeColor = Color.FromArgb(59, 130, 246);
            lbl200.Location = new Point(30, 32);
            lbl200.Name = "lbl200";
            lbl200.Size = new Size(95, 37);
            lbl200.TabIndex = 1;
            lbl200.Text = "2,00 €";
            lbl200.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC200Cnt
            // 
            lblC200Cnt.AutoSize = true;
            lblC200Cnt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC200Cnt.Location = new Point(215, 28);
            lblC200Cnt.Name = "lblC200Cnt";
            lblC200Cnt.Size = new Size(19, 21);
            lblC200Cnt.TabIndex = 2;
            lblC200Cnt.Text = "0";
            lblC200Cnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC200Value
            // 
            lblC200Value.AutoSize = true;
            lblC200Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC200Value.Location = new Point(215, 56);
            lblC200Value.Name = "lblC200Value";
            lblC200Value.Size = new Size(54, 21);
            lblC200Value.TabIndex = 3;
            lblC200Value.Tag = "2";
            lblC200Value.Text = "0,00 €";
            lblC200Value.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC100Value
            // 
            lblC100Value.AutoSize = true;
            lblC100Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC100Value.Location = new Point(215, 131);
            lblC100Value.Name = "lblC100Value";
            lblC100Value.Size = new Size(54, 21);
            lblC100Value.TabIndex = 7;
            lblC100Value.Tag = "1";
            lblC100Value.Text = "0,00 €";
            lblC100Value.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC100Cnt
            // 
            lblC100Cnt.AutoSize = true;
            lblC100Cnt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC100Cnt.Location = new Point(215, 103);
            lblC100Cnt.Name = "lblC100Cnt";
            lblC100Cnt.Size = new Size(19, 21);
            lblC100Cnt.TabIndex = 6;
            lblC100Cnt.Text = "0";
            lblC100Cnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl100
            // 
            lbl100.AutoSize = true;
            lbl100.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl100.ForeColor = Color.FromArgb(20, 184, 166);
            lbl100.Location = new Point(30, 107);
            lbl100.Name = "lbl100";
            lbl100.Size = new Size(95, 37);
            lbl100.TabIndex = 5;
            lbl100.Text = "1,00 €";
            lbl100.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn100
            // 
            btn100.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn100.Location = new Point(140, 100);
            btn100.Name = "btn100";
            btn100.Size = new Size(55, 55);
            btn100.TabIndex = 4;
            btn100.Tag = "C100";
            btn100.Text = "+1";
            btn100.UseVisualStyleBackColor = true;
            btn100.Click += MoneyIncrement;
            btn100.MouseDown += QuickIncrementDown;
            btn100.MouseUp += QuickIncrementUp;
            // 
            // lblC50Value
            // 
            lblC50Value.AutoSize = true;
            lblC50Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC50Value.Location = new Point(215, 206);
            lblC50Value.Name = "lblC50Value";
            lblC50Value.Size = new Size(54, 21);
            lblC50Value.TabIndex = 11;
            lblC50Value.Tag = "0,5";
            lblC50Value.Text = "0,00 €";
            lblC50Value.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC50Cnt
            // 
            lblC50Cnt.AutoSize = true;
            lblC50Cnt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC50Cnt.Location = new Point(215, 178);
            lblC50Cnt.Name = "lblC50Cnt";
            lblC50Cnt.Size = new Size(19, 21);
            lblC50Cnt.TabIndex = 10;
            lblC50Cnt.Text = "0";
            lblC50Cnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl50
            // 
            lbl50.AutoSize = true;
            lbl50.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl50.ForeColor = Color.FromArgb(34, 197, 94);
            lbl50.Location = new Point(30, 182);
            lbl50.Name = "lbl50";
            lbl50.Size = new Size(95, 37);
            lbl50.TabIndex = 9;
            lbl50.Text = "0,50 €";
            lbl50.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn50
            // 
            btn50.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn50.Location = new Point(140, 175);
            btn50.Name = "btn50";
            btn50.Size = new Size(55, 55);
            btn50.TabIndex = 8;
            btn50.Tag = "C50";
            btn50.Text = "+1";
            btn50.UseVisualStyleBackColor = true;
            btn50.Click += MoneyIncrement;
            btn50.MouseDown += QuickIncrementDown;
            btn50.MouseUp += QuickIncrementUp;
            // 
            // lblC20Value
            // 
            lblC20Value.AutoSize = true;
            lblC20Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC20Value.Location = new Point(215, 281);
            lblC20Value.Name = "lblC20Value";
            lblC20Value.Size = new Size(54, 21);
            lblC20Value.TabIndex = 15;
            lblC20Value.Tag = "0,2";
            lblC20Value.Text = "0,00 €";
            lblC20Value.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC20Cnt
            // 
            lblC20Cnt.AutoSize = true;
            lblC20Cnt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC20Cnt.Location = new Point(215, 253);
            lblC20Cnt.Name = "lblC20Cnt";
            lblC20Cnt.Size = new Size(19, 21);
            lblC20Cnt.TabIndex = 14;
            lblC20Cnt.Text = "0";
            lblC20Cnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl20
            // 
            lbl20.AutoSize = true;
            lbl20.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl20.ForeColor = Color.FromArgb(234, 179, 8);
            lbl20.Location = new Point(30, 257);
            lbl20.Name = "lbl20";
            lbl20.Size = new Size(95, 37);
            lbl20.TabIndex = 13;
            lbl20.Text = "0,20 €";
            lbl20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn20
            // 
            btn20.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn20.Location = new Point(140, 250);
            btn20.Name = "btn20";
            btn20.Size = new Size(55, 55);
            btn20.TabIndex = 12;
            btn20.Tag = "C20";
            btn20.Text = "+1";
            btn20.UseVisualStyleBackColor = true;
            btn20.Click += MoneyIncrement;
            btn20.MouseDown += QuickIncrementDown;
            btn20.MouseUp += QuickIncrementUp;
            // 
            // lblC10Value
            // 
            lblC10Value.AutoSize = true;
            lblC10Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC10Value.Location = new Point(620, 57);
            lblC10Value.Name = "lblC10Value";
            lblC10Value.Size = new Size(54, 21);
            lblC10Value.TabIndex = 19;
            lblC10Value.Tag = "0,1";
            lblC10Value.Text = "0,00 €";
            lblC10Value.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC10Cnt
            // 
            lblC10Cnt.AutoSize = true;
            lblC10Cnt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC10Cnt.Location = new Point(620, 29);
            lblC10Cnt.Name = "lblC10Cnt";
            lblC10Cnt.Size = new Size(19, 21);
            lblC10Cnt.TabIndex = 18;
            lblC10Cnt.Text = "0";
            lblC10Cnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl10
            // 
            lbl10.AutoSize = true;
            lbl10.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl10.ForeColor = Color.FromArgb(249, 115, 22);
            lbl10.Location = new Point(435, 32);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(95, 37);
            lbl10.TabIndex = 17;
            lbl10.Text = "0,10 €";
            lbl10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn10
            // 
            btn10.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn10.Location = new Point(545, 25);
            btn10.Name = "btn10";
            btn10.Size = new Size(55, 55);
            btn10.TabIndex = 16;
            btn10.Tag = "C10";
            btn10.Text = "+1";
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += MoneyIncrement;
            btn10.MouseDown += QuickIncrementDown;
            btn10.MouseUp += QuickIncrementUp;
            // 
            // lblC5Value
            // 
            lblC5Value.AutoSize = true;
            lblC5Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC5Value.Location = new Point(620, 131);
            lblC5Value.Name = "lblC5Value";
            lblC5Value.Size = new Size(54, 21);
            lblC5Value.TabIndex = 23;
            lblC5Value.Tag = "0,05";
            lblC5Value.Text = "0,00 €";
            lblC5Value.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC5Cnt
            // 
            lblC5Cnt.AutoSize = true;
            lblC5Cnt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC5Cnt.Location = new Point(620, 103);
            lblC5Cnt.Name = "lblC5Cnt";
            lblC5Cnt.Size = new Size(19, 21);
            lblC5Cnt.TabIndex = 22;
            lblC5Cnt.Text = "0";
            lblC5Cnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl5.ForeColor = Color.FromArgb(239, 68, 68);
            lbl5.Location = new Point(435, 107);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(95, 37);
            lbl5.TabIndex = 21;
            lbl5.Text = "0,05 €";
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(545, 100);
            btn5.Name = "btn5";
            btn5.Size = new Size(55, 55);
            btn5.TabIndex = 20;
            btn5.Tag = "C5";
            btn5.Text = "+1";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += MoneyIncrement;
            btn5.MouseDown += QuickIncrementDown;
            btn5.MouseUp += QuickIncrementUp;
            // 
            // lblC2Value
            // 
            lblC2Value.AutoSize = true;
            lblC2Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC2Value.Location = new Point(620, 206);
            lblC2Value.Name = "lblC2Value";
            lblC2Value.Size = new Size(54, 21);
            lblC2Value.TabIndex = 27;
            lblC2Value.Tag = "0,02";
            lblC2Value.Text = "0,00 €";
            lblC2Value.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC2Cnt
            // 
            lblC2Cnt.AutoSize = true;
            lblC2Cnt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC2Cnt.Location = new Point(620, 178);
            lblC2Cnt.Name = "lblC2Cnt";
            lblC2Cnt.Size = new Size(19, 21);
            lblC2Cnt.TabIndex = 26;
            lblC2Cnt.Text = "0";
            lblC2Cnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl2.ForeColor = Color.FromArgb(236, 72, 153);
            lbl2.Location = new Point(435, 182);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(95, 37);
            lbl2.TabIndex = 25;
            lbl2.Text = "0,02 €";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(545, 175);
            btn2.Name = "btn2";
            btn2.Size = new Size(55, 55);
            btn2.TabIndex = 24;
            btn2.Tag = "C2";
            btn2.Text = "+1";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += MoneyIncrement;
            btn2.MouseDown += QuickIncrementDown;
            btn2.MouseUp += QuickIncrementUp;
            // 
            // lblC1Value
            // 
            lblC1Value.AutoSize = true;
            lblC1Value.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC1Value.Location = new Point(620, 281);
            lblC1Value.Name = "lblC1Value";
            lblC1Value.Size = new Size(54, 21);
            lblC1Value.TabIndex = 31;
            lblC1Value.Tag = "0,01";
            lblC1Value.Text = "0,00 €";
            lblC1Value.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblC1Cnt
            // 
            lblC1Cnt.AutoSize = true;
            lblC1Cnt.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblC1Cnt.Location = new Point(620, 253);
            lblC1Cnt.Name = "lblC1Cnt";
            lblC1Cnt.Size = new Size(19, 21);
            lblC1Cnt.TabIndex = 30;
            lblC1Cnt.Text = "0";
            lblC1Cnt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl1.ForeColor = Color.FromArgb(168, 85, 247);
            lbl1.Location = new Point(435, 257);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(95, 37);
            lbl1.TabIndex = 29;
            lbl1.Text = "0,01 €";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(545, 250);
            btn1.Name = "btn1";
            btn1.Size = new Size(55, 55);
            btn1.TabIndex = 28;
            btn1.Tag = "C1";
            btn1.Text = "+1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += MoneyIncrement;
            btn1.MouseDown += QuickIncrementDown;
            btn1.MouseUp += QuickIncrementUp;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(12, 362);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(85, 27);
            btnAbout.TabIndex = 32;
            btnAbout.Text = "&Sobre";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btn200D
            // 
            btn200D.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn200D.Location = new Point(305, 35);
            btn200D.Name = "btn200D";
            btn200D.Size = new Size(35, 35);
            btn200D.TabIndex = 33;
            btn200D.Tag = "C200";
            btn200D.Text = "🡄";
            btn200D.UseVisualStyleBackColor = true;
            btn200D.Click += MoneyDecrement;
            btn200D.MouseDown += QuickDecrementDown;
            btn200D.MouseUp += QuickDecrementUp;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(445, 327);
            lblTotal.Margin = new Padding(0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(337, 65);
            lblTotal.TabIndex = 34;
            lblTotal.Text = "0,00 €";
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btn100D
            // 
            btn100D.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn100D.Location = new Point(305, 110);
            btn100D.Name = "btn100D";
            btn100D.Size = new Size(35, 35);
            btn100D.TabIndex = 35;
            btn100D.Tag = "C100";
            btn100D.Text = "🡄";
            btn100D.UseVisualStyleBackColor = true;
            btn100D.Click += MoneyDecrement;
            btn100D.MouseDown += QuickDecrementDown;
            btn100D.MouseUp += QuickDecrementUp;
            // 
            // btn50D
            // 
            btn50D.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn50D.Location = new Point(305, 185);
            btn50D.Name = "btn50D";
            btn50D.Size = new Size(35, 35);
            btn50D.TabIndex = 36;
            btn50D.Tag = "C50";
            btn50D.Text = "🡄";
            btn50D.UseVisualStyleBackColor = true;
            btn50D.Click += MoneyDecrement;
            btn50D.MouseDown += QuickDecrementDown;
            btn50D.MouseUp += QuickDecrementUp;
            // 
            // btn20D
            // 
            btn20D.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn20D.Location = new Point(305, 260);
            btn20D.Name = "btn20D";
            btn20D.Size = new Size(35, 35);
            btn20D.TabIndex = 37;
            btn20D.Tag = "C20";
            btn20D.Text = "🡄";
            btn20D.UseVisualStyleBackColor = true;
            btn20D.Click += MoneyDecrement;
            btn20D.MouseDown += QuickDecrementDown;
            btn20D.MouseUp += QuickDecrementUp;
            // 
            // btn10D
            // 
            btn10D.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn10D.Location = new Point(710, 36);
            btn10D.Name = "btn10D";
            btn10D.Size = new Size(35, 35);
            btn10D.TabIndex = 38;
            btn10D.Tag = "C10";
            btn10D.Text = "🡄";
            btn10D.UseVisualStyleBackColor = true;
            btn10D.Click += MoneyDecrement;
            btn10D.MouseDown += QuickDecrementDown;
            btn10D.MouseUp += QuickDecrementUp;
            // 
            // btn5D
            // 
            btn5D.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn5D.Location = new Point(710, 110);
            btn5D.Name = "btn5D";
            btn5D.Size = new Size(35, 35);
            btn5D.TabIndex = 39;
            btn5D.Tag = "C5";
            btn5D.Text = "🡄";
            btn5D.UseVisualStyleBackColor = true;
            btn5D.Click += MoneyDecrement;
            btn5D.MouseDown += QuickDecrementDown;
            btn5D.MouseUp += QuickDecrementUp;
            // 
            // btn2D
            // 
            btn2D.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn2D.Location = new Point(710, 185);
            btn2D.Name = "btn2D";
            btn2D.Size = new Size(35, 35);
            btn2D.TabIndex = 40;
            btn2D.Tag = "C2";
            btn2D.Text = "🡄";
            btn2D.UseVisualStyleBackColor = true;
            btn2D.Click += MoneyDecrement;
            btn2D.MouseDown += QuickDecrementDown;
            btn2D.MouseUp += QuickDecrementUp;
            // 
            // btn1D
            // 
            btn1D.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn1D.Location = new Point(710, 260);
            btn1D.Name = "btn1D";
            btn1D.Size = new Size(35, 35);
            btn1D.TabIndex = 41;
            btn1D.Tag = "C1";
            btn1D.Text = "🡄";
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 401);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            Text = "MoneyCount";
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