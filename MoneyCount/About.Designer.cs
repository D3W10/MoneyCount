namespace MoneyCount
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            tlpAppInfo = new TableLayoutPanel();
            lblHUrl = new Label();
            tlpBanner = new TableLayoutPanel();
            pbLogo = new PictureBox();
            lblHDescription = new Label();
            lblHAuthor = new Label();
            lblHVersion = new Label();
            lblHName = new Label();
            lblName = new Label();
            lblVersion = new Label();
            lblAuthor = new Label();
            textBoxDescription = new TextBox();
            btnOK = new Button();
            llblUrl = new LinkLabel();
            tlpAppInfo.SuspendLayout();
            tlpBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // tlpAppInfo
            // 
            tlpAppInfo.ColumnCount = 3;
            tlpAppInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.3776855F));
            tlpAppInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.62232F));
            tlpAppInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 254F));
            tlpAppInfo.Controls.Add(lblHUrl, 0, 3);
            tlpAppInfo.Controls.Add(tlpBanner, 0, 0);
            tlpAppInfo.Controls.Add(lblHDescription, 1, 4);
            tlpAppInfo.Controls.Add(lblHAuthor, 1, 2);
            tlpAppInfo.Controls.Add(lblHVersion, 1, 1);
            tlpAppInfo.Controls.Add(lblHName, 1, 0);
            tlpAppInfo.Controls.Add(lblName, 2, 0);
            tlpAppInfo.Controls.Add(lblVersion, 2, 1);
            tlpAppInfo.Controls.Add(lblAuthor, 2, 2);
            tlpAppInfo.Controls.Add(textBoxDescription, 2, 4);
            tlpAppInfo.Controls.Add(btnOK, 2, 5);
            tlpAppInfo.Controls.Add(llblUrl, 2, 3);
            tlpAppInfo.Dock = DockStyle.Fill;
            tlpAppInfo.Location = new Point(10, 10);
            tlpAppInfo.Margin = new Padding(0);
            tlpAppInfo.Name = "tlpAppInfo";
            tlpAppInfo.RowCount = 6;
            tlpAppInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpAppInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpAppInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpAppInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpAppInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpAppInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpAppInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAppInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpAppInfo.Size = new Size(487, 307);
            tlpAppInfo.TabIndex = 0;
            // 
            // lblHUrl
            // 
            lblHUrl.AutoSize = true;
            lblHUrl.Dock = DockStyle.Fill;
            lblHUrl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHUrl.Location = new Point(157, 90);
            lblHUrl.Margin = new Padding(7, 0, 4, 0);
            lblHUrl.MaximumSize = new Size(0, 20);
            lblHUrl.Name = "lblHUrl";
            lblHUrl.Size = new Size(72, 20);
            lblHUrl.TabIndex = 0;
            lblHUrl.Text = "URL:";
            lblHUrl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tlpBanner
            // 
            tlpBanner.BackColor = SystemColors.ControlLightLight;
            tlpBanner.ColumnCount = 1;
            tlpBanner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpBanner.Controls.Add(pbLogo, 0, 0);
            tlpBanner.Dock = DockStyle.Fill;
            tlpBanner.Location = new Point(0, 0);
            tlpBanner.Margin = new Padding(0);
            tlpBanner.Name = "tlpBanner";
            tlpBanner.RowCount = 1;
            tlpAppInfo.SetRowSpan(tlpBanner, 6);
            tlpBanner.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBanner.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBanner.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBanner.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBanner.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBanner.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpBanner.Size = new Size(150, 307);
            tlpBanner.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.Location = new Point(22, 96);
            pbLogo.Margin = new Padding(0, 0, 5, 15);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(100, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 12;
            pbLogo.TabStop = false;
            // 
            // lblHDescription
            // 
            lblHDescription.AutoSize = true;
            lblHDescription.Dock = DockStyle.Fill;
            lblHDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHDescription.Location = new Point(157, 120);
            lblHDescription.Margin = new Padding(7, 0, 4, 0);
            lblHDescription.MaximumSize = new Size(0, 20);
            lblHDescription.Name = "lblHDescription";
            lblHDescription.Size = new Size(72, 20);
            lblHDescription.TabIndex = 0;
            lblHDescription.Text = "Descrição:";
            lblHDescription.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHAuthor
            // 
            lblHAuthor.AutoSize = true;
            lblHAuthor.Dock = DockStyle.Fill;
            lblHAuthor.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHAuthor.Location = new Point(157, 60);
            lblHAuthor.Margin = new Padding(7, 0, 4, 0);
            lblHAuthor.MaximumSize = new Size(0, 20);
            lblHAuthor.Name = "lblHAuthor";
            lblHAuthor.Size = new Size(72, 20);
            lblHAuthor.TabIndex = 0;
            lblHAuthor.Text = "Autor:";
            lblHAuthor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHVersion
            // 
            lblHVersion.AutoSize = true;
            lblHVersion.Dock = DockStyle.Fill;
            lblHVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHVersion.Location = new Point(157, 30);
            lblHVersion.Margin = new Padding(7, 0, 4, 0);
            lblHVersion.MaximumSize = new Size(0, 20);
            lblHVersion.Name = "lblHVersion";
            lblHVersion.Size = new Size(72, 20);
            lblHVersion.TabIndex = 0;
            lblHVersion.Text = "Versão:";
            lblHVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblHName
            // 
            lblHName.AutoSize = true;
            lblHName.Dock = DockStyle.Fill;
            lblHName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHName.Location = new Point(157, 0);
            lblHName.Margin = new Padding(7, 0, 4, 0);
            lblHName.MaximumSize = new Size(0, 20);
            lblHName.Name = "lblHName";
            lblHName.Size = new Size(72, 20);
            lblHName.TabIndex = 0;
            lblHName.Text = "Nome:";
            lblHName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(240, 0);
            lblName.Margin = new Padding(7, 0, 4, 0);
            lblName.MaximumSize = new Size(0, 20);
            lblName.Name = "lblName";
            lblName.Size = new Size(243, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblVersion
            // 
            lblVersion.Dock = DockStyle.Fill;
            lblVersion.Location = new Point(240, 30);
            lblVersion.Margin = new Padding(7, 0, 4, 0);
            lblVersion.MaximumSize = new Size(0, 20);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(243, 20);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Version";
            lblVersion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblAuthor
            // 
            lblAuthor.Dock = DockStyle.Fill;
            lblAuthor.Location = new Point(240, 60);
            lblAuthor.Margin = new Padding(7, 0, 4, 0);
            lblAuthor.MaximumSize = new Size(0, 20);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(243, 20);
            lblAuthor.TabIndex = 0;
            lblAuthor.Text = "Author";
            lblAuthor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(240, 123);
            textBoxDescription.Margin = new Padding(7, 3, 4, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(243, 147);
            textBoxDescription.TabIndex = 0;
            textBoxDescription.TabStop = false;
            textBoxDescription.Text = "Description";
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.DialogResult = DialogResult.Cancel;
            btnOK.Location = new Point(398, 280);
            btnOK.Margin = new Padding(4, 3, 4, 3);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(85, 24);
            btnOK.TabIndex = 1;
            btnOK.Text = "&OK";
            // 
            // llblUrl
            // 
            llblUrl.ActiveLinkColor = Color.FromArgb(239, 68, 68);
            llblUrl.AutoSize = true;
            llblUrl.DisabledLinkColor = Color.FromArgb(115, 115, 115);
            llblUrl.Dock = DockStyle.Fill;
            llblUrl.LinkColor = Color.FromArgb(59, 130, 246);
            llblUrl.Location = new Point(240, 90);
            llblUrl.Margin = new Padding(7, 0, 4, 0);
            llblUrl.MaximumSize = new Size(0, 20);
            llblUrl.Name = "llblUrl";
            llblUrl.Size = new Size(243, 20);
            llblUrl.TabIndex = 0;
            llblUrl.TabStop = true;
            llblUrl.Text = "GitHub";
            llblUrl.TextAlign = ContentAlignment.MiddleLeft;
            llblUrl.VisitedLinkColor = Color.FromArgb(139, 92, 246);
            llblUrl.LinkClicked += llblUrl_LinkClicked;
            // 
            // About
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 327);
            Controls.Add(tlpAppInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            Padding = new Padding(10);
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sobre";
            tlpAppInfo.ResumeLayout(false);
            tlpAppInfo.PerformLayout();
            tlpBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpAppInfo;
        private PictureBox pbLogo;
        private Label lblName;
        private Label lblVersion;
        private Label lblAuthor;
        private TextBox textBoxDescription;
        private Button btnOK;
        private Label lblHName;
        private Label lblHVersion;
        private Label lblHAuthor;
        private Label lblHDescription;
        private TableLayoutPanel tlpBanner;
        private Label lblHUrl;
        private LinkLabel llblUrl;
    }
}
