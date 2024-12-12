using System.Windows.Forms;

namespace Pharmacy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if ((textBox1.Text == "Db_User_AE" || textBox1.Text == "Db_User_RS" ||
                textBox1.Text == "Db_User_DV") && textBox2.Text == "12345")
            {
                DialogResult = DialogResult.OK;
            }
            else return;
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
