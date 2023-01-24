namespace uprajnenie_we
{
    public partial class Form1 : Form
    {
        public static string name = "Admin";
        public static string password = "Admin1";
        public static string user = "User";
        public static string PasswordUser = "User1";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == name && textBox2.Text == password)
            {
                admin1.Show();
                client1.Hide();

            }
            else
                  if (textBox1.Text == user && textBox2.Text == PasswordUser)
            {
                admin1.Hide();
                client1.Show();

            }


        }

        private void client1_Load(object sender, EventArgs e)
        {

        }

        private void Ì‡˜‡ÎÓToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == name && textBox2.Text == password)
            {
                admin1.Hide();
                client1.Hide();

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
                admin1.Hide();
                client1.Hide();

            
        }
    }
}