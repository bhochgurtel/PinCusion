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
using System.IO;
using System.Diagnostics;



namespace PinCushionClient
{
    public sealed partial class MainForm : Form
    {
        private static bool reloadServersListbox = false;
     

        public static bool ReloadServersListbox
        {
            get { return MainForm.reloadServersListbox; }
            set { MainForm.reloadServersListbox = value; }
        }

        public MainForm()
        {
            InitializeComponent();
            Application.Run(new GlobalPasswordForm());
            PinCusionClient.Properties.Settings settings = new PinCusionClient.Properties.Settings();
            
            
            if (settings.ConnectionsFile.Length>0)
               ExtractConnections(settings.ConnectionsFile);

            if (settings.CommandsFile.Length > 0)
                extractCommandFile(settings.CommandsFile); 
        }

        public void loadConnectionsToListBox()
        {
            Dictionary<string, Connection> myDictOfConnections = Connections.RetrieveDictionary();
            List<string> _items = new List<string>();

            if (myDictOfConnections.Count > 0)
            {
                foreach (KeyValuePair<string, Connection> entry in myDictOfConnections)
                {
                    _items.Add(entry.Key);
                }
            }
            lbServers.DataSource = _items;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(lbServers.Items.Count==0 || reloadServersListbox)
            {
                loadConnectionsToListBox();
            }
           
        }

        private void addServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PinCushionClient.AddServers myNewAddServer = new PinCushionClient.AddServers(this);
            myNewAddServer.Show();
        }

        private void openSavedConnectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PinCusionClient.Properties.Settings settings = new PinCusionClient.Properties.Settings();
            var FD = new System.Windows.Forms.OpenFileDialog();
           
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                settings.ConnectionsFile = FD.FileName;
                settings.Save();
                ExtractConnections(FD.FileName);
            }
           
            loadConnectionsToListBox();
        }

        private static void ExtractConnections(string fileToOpen)
        {
            System.IO.FileInfo FilePath = new System.IO.FileInfo(fileToOpen);
            ConnectionsStore myStore = new ConnectionsStore();
            myStore = SerializeFile.Deserialize(FilePath.FullName);
            Connections.SaveDictionary(myStore.LocalConnections);
        }

        private void saveConnectionsToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionsStore myStore = new ConnectionsStore();
            myStore.LocalConnections = Connections.RetrieveDictionary();
            SaveFileDialog saveFileDialog1 = new SaveFileDialog(); 
            saveFileDialog1.Filter = "cfp files | *.cfp|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();  

            if (saveFileDialog1.FileName != "")   
            {
                SerializeFile.Serialize(saveFileDialog1.FileName, myStore);    
            }

        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.executeSshSingleThreadedConnectionTest();
        }

       

      
        private void btnExecuteScript_Click(object sender, EventArgs e)
        {
            string[] myCommands = txtCommandHistory.Text.Split('\n');
            foreach (string command in myCommands)
            {
                this.executeSshSingleThreaded(command);
            }
        }

        private void btnExecuteAndSave_Click(object sender, EventArgs e)
        {
            executeSshSingleThreaded(this.txtIndividualCommand.Text);
            this.txtCommandHistory.AppendText(this.txtIndividualCommand.Text + " \n");
        }
        private void btnExecuteCommand_Click(object sender, EventArgs e)
        {
            this.executeSshSingleThreaded(txtIndividualCommand.Text);
        }

        private void executeSingleThreadConnection()
        {
            executeSshSingleThreaded(this.txtIndividualCommand.Text);
            this.txtCommandHistory.AppendText(this.txtIndividualCommand.Text);
        }

        private void executeSshSingleThreaded(string command)
        {
            StringBuilder response = new StringBuilder();
            SSH sshConnection = null;
            if (command.Length > 0)
            {
                foreach (var item in this.lbServers.SelectedItems)
                {
                    try
                    {
                        Connection localConnection = Connections.RetriveConnection(item.ToString());
                        sshConnection = new SSH(localConnection.Username, localConnection.DecriptPassword(GlobalPassword.Password), DNS.ReturnCorrectAddress(localConnection.Ipaddress));
                        sshConnection.AttemptConnection();
                        sshConnection.ExecuteCommand(command);
                        response.Append(connectionHeader(localConnection));
                        response.Append(sshConnection.GetLastAction());
                        this.txtCommandOutput.AppendText(response.ToString());
                        response.Clear();
                    }
                    catch (Exception e)
                    {
                        response.Append(LogError(item.ToString(), e, "This is a command execution error: "));
                    }
                    finally
                    {
                        sshConnection.Disconnect();
                        sshConnection = null;
                    }
                }

                WriteLog(response);
            }
        }

        private void WriteLog(StringBuilder response)
        {
            if (response.Length > 0)
                txtCommandHistory.Text = response.ToString();
        }

        private void executeSshSingleThreadedConnectionTest()
        {
            StringBuilder response = new StringBuilder();
            SSH sshConnection = null;
            foreach (var item in this.lbServers.SelectedItems)
            {
                try
                {
                    Connection localConnection = Connections.RetriveConnection(item.ToString());
                    sshConnection = new SSH(localConnection.Username, localConnection.DecriptPassword(GlobalPassword.Password),DNS.ReturnCorrectAddress(localConnection.Ipaddress));
                    sshConnection.AttemptConnection();
                    response.Append(connectionHeader(localConnection));
                    response.Append(sshConnection.GetLastAction());
                    this.txtCommandOutput.AppendText(response.ToString());
                    response.Clear();
                }
                catch (Exception e)
                {
                    response.Append(LogError(item.ToString(),e,"This is a connection test error: "));
                }
                finally
                {
                    if (sshConnection != null)
                       sshConnection.Disconnect();
                }

            }

            WriteLog(response);
        }

        private string connectionHeader(Connection localConnection)
        {
            StringBuilder response = new StringBuilder();
            response.Append("\r\n-----------------------------------\r\n");
            response.Append("Server: " + localConnection.Ipaddress + "\r\n");
            response.Append("Time: " + DateTime.Now +"\r\n");
            return response.ToString();
        }

        private string LogError(string server,Exception e,string message)
        {
            StringBuilder response = new StringBuilder();
            response.Append("\r\n#########Error#########\r\n");
            response.Append("Server:" + server + "\r\n");
            response.Append("Time:" + DateTime.Now + "\r\n");
            response.Append(message + e.ToString());
            response.Append("\r\n#########Error#########\r\n");
            return response.ToString();
        }


        private void btnConnectExe_Click(object sender, EventArgs e)
        {
            executeSingleThreadConnection();  
        }

  
        private List<string> generateServersArray()
        {
            List<string> _items = new List<string>();
            foreach (string item in lbServers.SelectedItems)
            {
                _items.Add(item);
            }

            return _items;
        }

        
        private void openSavedCommandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PinCusionClient.Properties.Settings settings = new PinCusionClient.Properties.Settings();
            txtCommandHistory.Text = "";
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                
                settings.CommandsFile = FD.FileName;
                settings.Save();
                
                string fileToOpen = FD.FileName;
                System.IO.FileInfo FilePath = new System.IO.FileInfo(FD.FileName);
                extractCommandFile(FilePath.FullName);
            }
        }

        private void extractCommandFile(string path)
        {
            StringBuilder sbCommands = new StringBuilder();
            using (FileStream fs = File.OpenRead(path))
            {
                byte[] bA = new byte[1024];
                UTF8Encoding fC = new UTF8Encoding(true);
                while (fs.Read(bA, 0, bA.Length) > 0)
                {
                    sbCommands.Append(fC.GetString(bA));
                }
            }

            txtCommandHistory.Text = sbCommands.ToString();
        }

        private void saveCommandsToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "cfd files | *.cfd|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                File.WriteAllText(saveFileDialog1.FileName, txtCommandHistory.Text);
            }

        }

        private void commandOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtCommandOutput.Text = "";
        }

        private void individualCommandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtIndividualCommand.Text = "";
        }

        private void commandScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtCommandHistory.Text = "";
        }

        private void serversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.lbServers.DataSource = null;
            this.lbServers.Items.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://pincusionsoftware.blogspot.com/p/pincushion-ssh-tutorial.html");
            Process.Start(sInfo);
        }

        private void blogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://pincusionsoftware.blogspot.com");
            Process.Start(sInfo);
        }

        public interface ICopyPasteable
        {
            void CopyToClipboard();
            void PasteFromClipboard();
        }

        private void copyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ICopyPasteable control = sender as ICopyPasteable;
            if (control != null)
            {
                control.CopyToClipboard();
            }
        }

        private void CommandOutputCopyPaste(object sender, KeyEventArgs e)
        {
            this.ClipboardTextBox(ref txtCommandOutput, e);
        }

        private void IndividualCommandCopyPaste(object sender, KeyEventArgs e)
        {
            this.ClipboardTextBox(ref txtIndividualCommand, e);
        }

        private void CommandScriptCopyPaste(object sender, KeyEventArgs e)
        {
            this.ClipboardTextBox(ref txtCommandHistory, e);
        }

        private void ClipboardTextBox(ref TextBox localTextBox, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                localTextBox.Copy();
            }
            else if (e.Control && e.KeyCode == Keys.C)
            {
                localTextBox.Text = Clipboard.GetText();
            }
        }

       

        


       

       

       
    }
}
