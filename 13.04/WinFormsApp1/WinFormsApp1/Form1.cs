using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
       
        bool isXTurn = true;
        int stepCount = 0;

       
        string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnRun_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int maxX = this.ClientSize.Width - btnRun.Width;
            int maxY = this.ClientSize.Height - btnRun.Height;

            btnRun.Location = new Point(random.Next(0, maxX), random.Next(0, maxY));
        }


   
        private void GameButtonClick(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            if (isXTurn)
                btn.Text = "X";
            else
                btn.Text = "O";

            isXTurn = !isXTurn;
            btn.Enabled = false;
            stepCount++;

            CheckWinner();
        }

        private void CheckWinner()
        {
            bool winnerFound = false;

        
            if ((button1.Text == button2.Text) && (button2.Text == button3.Text) && (!button1.Enabled)) winnerFound = true;
            else if ((button4.Text == button5.Text) && (button5.Text == button6.Text) && (!button4.Enabled)) winnerFound = true;
            else if ((button7.Text == button8.Text) && (button8.Text == button9.Text) && (!button7.Enabled)) winnerFound = true;
            else if ((button1.Text == button4.Text) && (button4.Text == button7.Text) && (!button1.Enabled)) winnerFound = true;
            else if ((button2.Text == button5.Text) && (button5.Text == button8.Text) && (!button2.Enabled)) winnerFound = true;
            else if ((button3.Text == button6.Text) && (button6.Text == button9.Text) && (!button3.Enabled)) winnerFound = true;
            else if ((button1.Text == button5.Text) && (button5.Text == button9.Text) && (!button1.Enabled)) winnerFound = true;
            else if ((button3.Text == button5.Text) && (button5.Text == button7.Text) && (!button3.Enabled)) winnerFound = true;

            if (winnerFound)
            {
                string finalWinner = isXTurn ? "O" : "X";
                MessageBox.Show("Переміг гравець: " + finalWinner, "Кінець гри!");
                ResetGame();
            }
            else if (stepCount == 9)
            {
                MessageBox.Show("Нічия!", "Кінець гри!");
                ResetGame();
            }
        }

        private void ResetGame()
        {
            isXTurn = true;
            stepCount = 0;
            button1.Text = ""; button1.Enabled = true;
            button2.Text = ""; button2.Enabled = true;
            button3.Text = ""; button3.Enabled = true;
            button4.Text = ""; button4.Enabled = true;
            button5.Text = ""; button5.Enabled = true;
            button6.Text = ""; button6.Enabled = true;
            button7.Text = ""; button7.Enabled = true;
            button8.Text = ""; button8.Enabled = true;
            button9.Text = ""; button9.Enabled = true;
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFile.FileName);
                currentFilePath = openFile.FileName;
                this.Text = "Файл: " + Path.GetFileName(currentFilePath);
            }
        }

       
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                File.WriteAllText(currentFilePath, textBox1.Text);
                MessageBox.Show("Зміни збережено!", "Успіх");
            }
            else
            {
                MessageBox.Show("Спочатку відкрийте файл через кнопку 'Open'");
            }
        }
    }
}