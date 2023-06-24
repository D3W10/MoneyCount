namespace MoneyCount
{
    public class Coins
    {
        public int C200 { get; set; }

        public int C100 { get; set; }

        public int C50 { get; set; }

        public int C20 { get; set; }

        public int C10 { get; set; }

        public int C5 { get; set; }

        public int C2 { get; set; }

        public int C1 { get; set; }

        public decimal GetTotal()
        {
            return C200 * 2m + C100 * 1m + C50 * 0.5m + C20 * 0.2m + C10 * 0.1m + C5 * 0.05m + C2 * 0.02m + C1 * 0.01m;
        }
    }
}