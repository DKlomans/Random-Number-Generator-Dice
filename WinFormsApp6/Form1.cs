namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int N = 15;
            int[] A = new int[N];
            double sum = 0;

            txtResults.Clear();
            for (int k = 0; k < N; k++)
            {
                A[k] = random.Next(-10, 10);
                txtResults.AppendText(A[k] + Environment.NewLine);
                sum += A[k];
            }

            int min = A.Min();
            double average = sum / N;

            txtResults.AppendText("Min: " + min + Environment.NewLine);
            txtResults.AppendText("Average: " + average.ToString("F2") + Environment.NewLine);
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int die1 = random.Next(1, 7);  
            int die2 = random.Next(1, 7);  

            txtDiceResults.AppendText("Dice 1: " + die1 + ", Dice 2: " + die2 + Environment.NewLine);
        }

    }
}
