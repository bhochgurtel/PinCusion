using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PinCushion.Library;


namespace PinCushionClient
{
    public partial class AddServers : Form
    {
        private MainForm mainForm = null;
        private static bool loadEdit = false;

        public AddServers()
        {
            InitializeComponent();
            
        }

        public AddServers(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            this.txtConName.Text = this.txtIpAdd.Text = this.txtPassword.Text = this.txtServerName.Text = this.txtUserName.Text = string.Empty;
            loadEdit = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Validate();
            if(loadEdit)
            {
                Connections.RemoveConnection(cbListOfExistingConnections.SelectedValue.ToString());
                cbListOfExistingConnections.SelectedIndex = 0;
            }
            Connection myConn = new Connection(txtConName.Text, txtServerName.Text, txtIpAdd.Text, txtUserName.Text, txtPassword.Text, GlobalPassword.Password);
            Connections.AddConnection(myConn);
            txtClear_Click(sender, e);
            mainForm.loadConnectionsToListBox();
        }

        private void Validate()
        {
            
            
        }

        private void AddServers_Load(object sender, EventArgs e)
        {
            Utilities.loadConnectionsToEdit(ref cbListOfExistingConnections, Connections.RetrieveDictionary(), "Select a connection to edit");
        }

        private void Load_Device(object sender, EventArgs e)
        {
            if (cbListOfExistingConnections.SelectedIndex > 0)
            {
                Connection myConn = Connections.RetriveConnection(cbListOfExistingConnections.SelectedValue.ToString());
                txtConName.Text = myConn.ConnectionName;
                txtPassword.Text = myConn.DecriptPassword(GlobalPassword.Password);
                txtServerName.Text = myConn.Server;
                txtIpAdd.Text = myConn.Ipaddress;
                txtUserName.Text = myConn.Username;
                loadEdit = true;
            }
        }

      
    }
}
