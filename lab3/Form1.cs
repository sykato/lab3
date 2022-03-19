namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            if (userName.Length < 3)
            {
                MessageBox.Show("Введите имя пользователя!");
            }
            else
            {
                MessageBox.Show ("Привет "+userName);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}