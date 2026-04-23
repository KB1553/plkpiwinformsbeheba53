using System.Windows.Forms;

namespace WinFormsApp77
{
    public partial class Form1 : Form
    {
        private string[] memes = { "meme1.jpg", "meme2.jpg", "meme3.jpg" };
        private int currentIndex = 0;

        private const int size = 10;
        private const int bombCount = 10;
        private Button[,] cells = new Button[size, size];
        private bool[,] bombs = new bool[size, size];

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            UpdateGallery();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < memes.Length - 1)
            {
                currentIndex++;
                UpdateGallery();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                UpdateGallery();
            }
        }

        private void UpdateGallery()
        {
            try
            {
                pictureBox1.Image = Image.FromFile(memes[currentIndex]);
                this.Text = $"Meme {currentIndex + 1}/{memes.Length}";
            }
            catch
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btnStartSapper_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Width = 420;
            this.Height = 450;

            Random rnd = new Random();
            int planted = 0;
            while (planted < bombCount)
            {
                int x = rnd.Next(size);
                int y = rnd.Next(size);
                if (!bombs[x, y])
                {
                    bombs[x, y] = true;
                    planted++;
                }
            }

            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    Button btn = new Button
                    {
                        Size = new Size(40, 40),
                        Location = new Point(x * 40, y * 40),
                        Tag = new Point(x, y)
                    };
                    btn.Click += CellClick;
                    cells[x, y] = btn;
                    this.Controls.Add(btn);
                }
            }
        }

        private void CellClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Point p = (Point)btn.Tag;

            if (bombs[p.X, p.Y])
            {
                btn.Text = "💣";
                btn.BackColor = Color.Red;
                MessageBox.Show("Boom!");
                Application.Restart();
            }
            else
            {
                int count = CountNearby(p.X, p.Y);
                btn.Text = count > 0 ? count.ToString() : "";
                btn.Enabled = false;
                btn.BackColor = Color.LightGray;
            }
        }

        private int CountNearby(int x, int y)
        {
            int count = 0;
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    int nx = x + i, ny = y + j;
                    if (nx >= 0 && nx < size && ny >= 0 && ny < size && bombs[nx, ny])
                        count++;
                }
            }
            return count;
        }
    }
}