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
            resources.ApplyResources(tlpAppInfo, "tlpAppInfo");
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
            tlpAppInfo.Name = "tlpAppInfo";
            // 
            // lblHUrl
            // 
            resources.ApplyResources(lblHUrl, "lblHUrl");
            lblHUrl.Name = "lblHUrl";
            // 
            // tlpBanner
            // 
            tlpBanner.BackColor = SystemColors.ControlLightLight;
            resources.ApplyResources(tlpBanner, "tlpBanner");
            tlpBanner.Controls.Add(pbLogo, 0, 0);
            tlpBanner.Name = "tlpBanner";
            tlpAppInfo.SetRowSpan(tlpBanner, 6);
            // 
            // pbLogo
            // 
            resources.ApplyResources(pbLogo, "pbLogo");
            pbLogo.Image = Properties.Resources.logo;
            pbLogo.Name = "pbLogo";
            pbLogo.TabStop = false;
            // 
            // lblHDescription
            // 
            resources.ApplyResources(lblHDescription, "lblHDescription");
            lblHDescription.Name = "lblHDescription";
            // 
            // lblHAuthor
            // 
            resources.ApplyResources(lblHAuthor, "lblHAuthor");
            lblHAuthor.Name = "lblHAuthor";
            // 
            // lblHVersion
            // 
            resources.ApplyResources(lblHVersion, "lblHVersion");
            lblHVersion.Name = "lblHVersion";
            // 
            // lblHName
            // 
            resources.ApplyResources(lblHName, "lblHName");
            lblHName.Name = "lblHName";
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.Name = "lblName";
            // 
            // lblVersion
            // 
            resources.ApplyResources(lblVersion, "lblVersion");
            lblVersion.Name = "lblVersion";
            // 
            // lblAuthor
            // 
            resources.ApplyResources(lblAuthor, "lblAuthor");
            lblAuthor.Name = "lblAuthor";
            // 
            // textBoxDescription
            // 
            resources.ApplyResources(textBoxDescription, "textBoxDescription");
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.TabStop = false;
            // 
            // btnOK
            // 
            resources.ApplyResources(btnOK, "btnOK");
            btnOK.DialogResult = DialogResult.Cancel;
            btnOK.Name = "btnOK";
            // 
            // llblUrl
            // 
            llblUrl.ActiveLinkColor = Color.FromArgb(239, 68, 68);
            resources.ApplyResources(llblUrl, "llblUrl");
            llblUrl.DisabledLinkColor = Color.FromArgb(115, 115, 115);
            llblUrl.LinkColor = Color.FromArgb(59, 130, 246);
            llblUrl.Name = "llblUrl";
            llblUrl.TabStop = true;
            llblUrl.VisitedLinkColor = Color.FromArgb(139, 92, 246);
            llblUrl.LinkClicked += llblUrl_LinkClicked;
            // 
            // About
            // 
            AcceptButton = btnOK;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpAppInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "About";
            ShowInTaskbar = false;
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
