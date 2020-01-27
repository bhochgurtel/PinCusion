using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinCushionClient
{
    public partial class GlobalPasswordForm : Form
    {
        public GlobalPasswordForm()
        {
            InitializeComponent();
            if(GlobalPassword.Password != String.Empty)
            {
                txtPassword.Text = GlobalPassword.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GlobalPassword.Password = this.txtPassword.Text;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
