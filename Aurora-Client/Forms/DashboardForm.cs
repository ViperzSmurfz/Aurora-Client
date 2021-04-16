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
        public string ClientURL = Program.ClientURL;
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
                //User is valid.
                    //Send data from mojang auth to database.
                    //loop pull data from database to client.
                    //pull protected webserver file using database token to read from.
                    //When user logs out, send data to database, close database connection.
                            
        }
    }
}
