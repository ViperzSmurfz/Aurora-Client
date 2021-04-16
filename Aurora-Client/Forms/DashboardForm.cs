using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aurora_Client
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Eye_ButtonClick(object sender, EventArgs e)
        {
            if(PasswordTxtBox.PasswordChar == Char.Parse("•"))
            {
                PasswordTxtBox.PasswordChar = Char.Parse("\0");
            }
            else
            {
                PasswordTxtBox.PasswordChar = Char.Parse("•");
            }
        }
        private void SigninBtn_Click(object sender, EventArgs e)
        {
            //Attempt to Log User In
        }
    }
}
