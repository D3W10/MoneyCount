using System.Diagnostics;
using System.Reflection;

namespace MoneyCount
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            Text += " " + Application.ProductName;
            lblName.Text = Application.ProductName;
            lblVersion.Text = Application.ProductVersion;
            lblAuthor.Text = Application.CompanyName;
            textBoxDescription.Text = AssemblyDescription;
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                    return "";

                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        private void llblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblUrl.LinkVisited = true;
            Process.Start(new ProcessStartInfo { FileName = "https://github.com/D3W10/MoneyCount", UseShellExecute = true });
        }
    }
}