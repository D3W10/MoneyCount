namespace MoneyCount
{
    public partial class Home : Form
    {
        private bool holdFast;
        private Button? holdFastSender;
        private EventHandler? holdFastHandler;
        private Coins counter;

        public Home()
        {
            InitializeComponent();

            holdFast = false;
            counter = new Coins();
        }

        private void MoneyIncrement(object sender, EventArgs e)
        {
            string coinCode = (string)(!holdFast ? (Button)sender : holdFastSender!).Tag!;

            int currentCnt = Convert.ToInt32(counter.GetType().GetProperty(coinCode)!.GetValue(counter)), step = ModifierKeys == Keys.Shift ? 5 : 1;
            counter.GetType().GetProperty(coinCode)!.SetValue(counter, currentCnt + step);

            Label lblCnt = (Label)Controls.Find("lbl" + coinCode + "Cnt", true).FirstOrDefault()!;
            lblCnt.Text = (currentCnt + step).ToString();

            Label lblValue = (Label)Controls.Find("lbl" + coinCode + "Value", true).FirstOrDefault()!;
            lblValue.Text = ((currentCnt + step) * Convert.ToDecimal(lblValue.Tag)).ToString("0.00") + " €";

            lblTotal.Text = counter.GetTotal() + " €";
        }

        private void QuickIncrementDown(object sender, MouseEventArgs e)
        {
            tWait.Enabled = true;
            holdFastSender = (Button)sender;
            holdFastHandler = MoneyIncrement!;
        }

        private void QuickIncrementUp(object sender, MouseEventArgs e)
        {
            holdFastSender = null;
            tDown.Tick -= holdFastHandler;
            tDown.Enabled = holdFast = false;
        }

        private void MoneyDecrement(object sender, EventArgs e)
        {
            string coinCode = (string)(!holdFast ? (Button)sender : holdFastSender!).Tag!;

            int currentCnt = Convert.ToInt32(counter.GetType().GetProperty(coinCode)!.GetValue(counter)), step = ModifierKeys == Keys.Shift ? 5 : 1;
            if (currentCnt - step < 0)
                return;

            counter.GetType().GetProperty(coinCode)!.SetValue(counter, currentCnt - step);

            Label lblCnt = (Label)Controls.Find("lbl" + coinCode + "Cnt", true).FirstOrDefault()!;
            lblCnt.Text = (currentCnt - step).ToString();

            Label lblValue = (Label)Controls.Find("lbl" + coinCode + "Value", true).FirstOrDefault()!;
            lblValue.Text = ((currentCnt - step) * Convert.ToDecimal(lblValue.Tag)).ToString("0.00") + " €";

            lblTotal.Text = counter.GetTotal() + " €";
        }

        private void QuickDecrementDown(object sender, MouseEventArgs e)
        {
            tWait.Enabled = true;
            holdFastSender = (Button)sender;
            holdFastHandler = MoneyDecrement!;
        }

        private void QuickDecrementUp(object sender, MouseEventArgs e)
        {
            holdFastSender = null;
            tDown.Tick -= holdFastHandler;
            tDown.Enabled = holdFast = false;
        }

        private void tWait_Tick(object sender, EventArgs e)
        {
            tWait.Enabled = false;
            if (holdFastSender != null)
            {
                holdFast = true;

                tDown.Tick += holdFastHandler;
                tDown.Enabled = true;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}