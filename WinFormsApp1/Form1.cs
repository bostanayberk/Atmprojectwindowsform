using System.Runtime.ExceptionServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string password = "123";
        string customerName = "Eray";


        private void button1_Click(object sender, EventArgs e)
        {
            string inPassword = textBox1.Text;
            string inCustomerName = textBox2.Text;

            if (inCustomerName == customerName && inPassword == password)
            {

            }


            // first comment 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
