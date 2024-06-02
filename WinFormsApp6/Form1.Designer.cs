namespace WinFormsApp6
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnGenerateNumbers;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.TextBox txtDiceResults;

        private void InitializeComponent()
        {
            this.btnGenerateNumbers = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.txtDiceResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // btnGenerateNumbers
            this.btnGenerateNumbers.Location = new System.Drawing.Point(12, 12);
            this.btnGenerateNumbers.Name = "btnGenerateNumbers";
            this.btnGenerateNumbers.Size = new System.Drawing.Size(150, 23);
            this.btnGenerateNumbers.Text = "Generate Numbers";
            this.btnGenerateNumbers.UseVisualStyleBackColor = true;
            this.btnGenerateNumbers.Click += new System.EventHandler(this.btnGenerateNumbers_Click);

            // txtResults
            this.txtResults.Location = new System.Drawing.Point(12, 41);
            this.txtResults.Multiline = true;
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(150, 400);

            // btnRollDice
            this.btnRollDice.Location = new System.Drawing.Point(172, 12);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(150, 23);
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);

            // txtDiceResults
            this.txtDiceResults.Location = new System.Drawing.Point(172, 41);
            this.txtDiceResults.Multiline = true;
            this.txtDiceResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiceResults.Size = new System.Drawing.Size(150, 400);

            // Form1
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.txtDiceResults);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnGenerateNumbers);
            this.Name = "Form1";
            this.Text = "Random Numbers and Dice";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }

}
