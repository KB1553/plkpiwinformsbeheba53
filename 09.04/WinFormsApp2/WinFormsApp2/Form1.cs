namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtLength.Text, out double length) &&
                double.TryParse(txtWidth.Text, out double width))
            {
                if (length > 0 && width > 0)
                {
                    double area = length * width;
                    double perimeter = 2 * (length + width);
                    lblResult.Text = $"Площа: {area} | Периметр: {perimeter}";
                }
                else
                {
                    MessageBox.Show("Числа мають бути додатними!", "Помилка");
                }
            }
            else
            {
                MessageBox.Show("Введіть коректні числові значення!", "Помилка");
            }
        }


        private void ColorButton_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            switch (btn.Name)
            {
                case "btnRed":
                    this.BackColor = Color.Red;
                    lblColorName.Text = "Обрано колір: Червоний";
                    break;
                case "btnGreen":
                    this.BackColor = Color.Green;
                    lblColorName.Text = "Обрано колір: Зелений";
                    break;
                case "btnBlue":
                    this.BackColor = Color.Blue;
                    lblColorName.Text = "Обрано колір: Синій";
                    break;
                case "btnYellow":
                    this.BackColor = Color.Yellow;
                    lblColorName.Text = "Обрано колір: Жовтий";
                    break;
            }
        }


        private void btnIncrement_Click(object sender, EventArgs e)
        {
            counter++;
            lblCount.Text = counter.ToString();
        }

        private void btnResetCounter_Click(object sender, EventArgs e)
        {
            counter = 0;
            lblCount.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}