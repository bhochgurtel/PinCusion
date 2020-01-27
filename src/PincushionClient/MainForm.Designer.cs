
/*
Copyright(c) 2019 bhochgurtel

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
namespace PinCushionClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSavedConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConnectionsToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openSavedCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveCommandsToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinCushionBlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearFieldsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.individualCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbServers = new System.Windows.Forms.ListBox();
            this.txtCommandOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnConnectExe = new System.Windows.Forms.Button();
            this.txtIndividualCommand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCommandHistory = new System.Windows.Forms.TextBox();
            this.txtCommandArea = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExecuteScript = new System.Windows.Forms.Button();
            this.btnExecuteCommand = new System.Windows.Forms.Button();
            this.btnExecuteAndSave = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.clearFieldsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addServerToolStripMenuItem,
            this.openSavedConnectionsToolStripMenuItem,
            this.saveConnectionsToFileToolStripMenuItem,
            this.openSavedCommandsToolStripMenuItem,
            this.saveCommandsToFileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addServerToolStripMenuItem
            // 
            this.addServerToolStripMenuItem.Name = "addServerToolStripMenuItem";
            this.addServerToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.addServerToolStripMenuItem.Text = "Add/Edit Device";
            this.addServerToolStripMenuItem.Click += new System.EventHandler(this.addServerToolStripMenuItem_Click);
            // 
            // openSavedConnectionsToolStripMenuItem
            // 
            this.openSavedConnectionsToolStripMenuItem.Name = "openSavedConnectionsToolStripMenuItem";
            this.openSavedConnectionsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.openSavedConnectionsToolStripMenuItem.Text = "Open Saved Connections";
            this.openSavedConnectionsToolStripMenuItem.Click += new System.EventHandler(this.openSavedConnectionsToolStripMenuItem_Click);
            // 
            // saveConnectionsToFileToolStripMenuItem
            // 
            this.saveConnectionsToFileToolStripMenuItem.Name = "saveConnectionsToFileToolStripMenuItem";
            this.saveConnectionsToFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.saveConnectionsToFileToolStripMenuItem.Text = "Save Connections To File";
            this.saveConnectionsToFileToolStripMenuItem.Click += new System.EventHandler(this.saveConnectionsToFileToolStripMenuItem_Click);
            // 
            // openSavedCommandsToolStripMenuItem
            // 
            this.openSavedCommandsToolStripMenuItem.Name = "openSavedCommandsToolStripMenuItem";
            this.openSavedCommandsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.openSavedCommandsToolStripMenuItem.Text = "Open Saved Commands";
            this.openSavedCommandsToolStripMenuItem.Click += new System.EventHandler(this.openSavedCommandsToolStripMenuItem_Click);
            // 
            // saveCommandsToFileToolStripMenuItem
            // 
            this.saveCommandsToFileToolStripMenuItem.Name = "saveCommandsToFileToolStripMenuItem";
            this.saveCommandsToFileToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.saveCommandsToFileToolStripMenuItem.Text = "Save Commands To File";
            this.saveCommandsToFileToolStripMenuItem.Click += new System.EventHandler(this.saveCommandsToFileToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
           
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
           
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.documentationToolStripMenuItem,
            this.pinCushionBlogToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // documentationToolStripMenuItem
            // 
            this.documentationToolStripMenuItem.Name = "documentationToolStripMenuItem";
            this.documentationToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.documentationToolStripMenuItem.Text = "Documentation";
            this.documentationToolStripMenuItem.Click += new System.EventHandler(this.documentationToolStripMenuItem_Click);
            // 
            // pinCushionBlogToolStripMenuItem
            // 
            this.pinCushionBlogToolStripMenuItem.Name = "pinCushionBlogToolStripMenuItem";
            this.pinCushionBlogToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.pinCushionBlogToolStripMenuItem.Text = "Pin Cushion Blog";
            this.pinCushionBlogToolStripMenuItem.Click += new System.EventHandler(this.blogToolStripMenuItem_Click);
            // 
            // clearFieldsToolStripMenuItem
            // 
            this.clearFieldsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commandOutputToolStripMenuItem,
            this.individualCommandToolStripMenuItem,
            this.commandScriptToolStripMenuItem,
            this.serversToolStripMenuItem});
            this.clearFieldsToolStripMenuItem.Name = "clearFieldsToolStripMenuItem";
            this.clearFieldsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.clearFieldsToolStripMenuItem.Text = "Clear Fields";
            // 
            // commandOutputToolStripMenuItem
            // 
            this.commandOutputToolStripMenuItem.Name = "commandOutputToolStripMenuItem";
            this.commandOutputToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.commandOutputToolStripMenuItem.Text = "Command Output";
            this.commandOutputToolStripMenuItem.Click += new System.EventHandler(this.commandOutputToolStripMenuItem_Click);
            // 
            // individualCommandToolStripMenuItem
            // 
            this.individualCommandToolStripMenuItem.Name = "individualCommandToolStripMenuItem";
            this.individualCommandToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.individualCommandToolStripMenuItem.Text = "Individual Command";
            this.individualCommandToolStripMenuItem.Click += new System.EventHandler(this.individualCommandToolStripMenuItem_Click);
            // 
            // commandScriptToolStripMenuItem
            // 
            this.commandScriptToolStripMenuItem.Name = "commandScriptToolStripMenuItem";
            this.commandScriptToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.commandScriptToolStripMenuItem.Text = "Command Script";
            this.commandScriptToolStripMenuItem.Click += new System.EventHandler(this.commandScriptToolStripMenuItem_Click);
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.serversToolStripMenuItem.Text = "Servers";
            this.serversToolStripMenuItem.Click += new System.EventHandler(this.serversToolStripMenuItem_Click);
            // 
            // lbServers
            // 
            this.lbServers.FormattingEnabled = true;
            this.lbServers.Location = new System.Drawing.Point(12, 53);
            this.lbServers.Name = "lbServers";
            this.lbServers.ScrollAlwaysVisible = true;
            this.lbServers.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbServers.Size = new System.Drawing.Size(139, 394);
            this.lbServers.TabIndex = 1;
            // 
            // txtCommandOutput
            // 
            this.txtCommandOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommandOutput.Location = new System.Drawing.Point(157, 53);
            this.txtCommandOutput.Multiline = true;
            this.txtCommandOutput.Name = "txtCommandOutput";
            this.txtCommandOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommandOutput.Size = new System.Drawing.Size(790, 293);
            this.txtCommandOutput.TabIndex = 2;
            this.txtCommandOutput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandOutputCopyPaste);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Devices:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Command Output:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(3, 37);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(127, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnConnectExe
            // 
            this.btnConnectExe.Location = new System.Drawing.Point(3, 66);
            this.btnConnectExe.Name = "btnConnectExe";
            this.btnConnectExe.Size = new System.Drawing.Size(127, 23);
            this.btnConnectExe.TabIndex = 6;
            this.btnConnectExe.Text = "Connect + Execute";
            this.btnConnectExe.UseVisualStyleBackColor = true;
            this.btnConnectExe.Click += new System.EventHandler(this.btnConnectExe_Click);
            // 
            // txtIndividualCommand
            // 
            this.txtIndividualCommand.Location = new System.Drawing.Point(157, 379);
            this.txtIndividualCommand.Name = "txtIndividualCommand";
            this.txtIndividualCommand.Size = new System.Drawing.Size(547, 20);
            this.txtIndividualCommand.TabIndex = 11;
            this.txtIndividualCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IndividualCommandCopyPaste);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Individual Command:";
            // 
            // txtCommandHistory
            // 
            this.txtCommandHistory.Location = new System.Drawing.Point(158, 428);
            this.txtCommandHistory.Multiline = true;
            this.txtCommandHistory.Name = "txtCommandHistory";
            this.txtCommandHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommandHistory.Size = new System.Drawing.Size(790, 149);
            this.txtCommandHistory.TabIndex = 13;
            this.txtCommandHistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandScriptCopyPaste);
            // 
            // txtCommandArea
            // 
            this.txtCommandArea.AutoSize = true;
            this.txtCommandArea.Location = new System.Drawing.Point(155, 412);
            this.txtCommandArea.Name = "txtCommandArea";
            this.txtCommandArea.Size = new System.Drawing.Size(87, 13);
            this.txtCommandArea.TabIndex = 14;
            this.txtCommandArea.Text = "Command Script:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConnectExe);
            this.panel1.Controls.Add(this.btnExecuteScript);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Location = new System.Drawing.Point(12, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 150);
            this.panel1.TabIndex = 16;
            // 
            // btnExecuteScript
            // 
            this.btnExecuteScript.ForeColor = System.Drawing.Color.Black;
            this.btnExecuteScript.Location = new System.Drawing.Point(3, 95);
            this.btnExecuteScript.Name = "btnExecuteScript";
            this.btnExecuteScript.Size = new System.Drawing.Size(128, 48);
            this.btnExecuteScript.TabIndex = 19;
            this.btnExecuteScript.Text = "Connect and Execute Complete Script";
            this.btnExecuteScript.UseVisualStyleBackColor = true;
            this.btnExecuteScript.Click += new System.EventHandler(this.btnExecuteScript_Click);
            // 
            // btnExecuteCommand
            // 
            this.btnExecuteCommand.Location = new System.Drawing.Point(710, 379);
            this.btnExecuteCommand.Name = "btnExecuteCommand";
            this.btnExecuteCommand.Size = new System.Drawing.Size(65, 23);
            this.btnExecuteCommand.TabIndex = 18;
            this.btnExecuteCommand.Text = "Execute";
            this.btnExecuteCommand.UseVisualStyleBackColor = true;
            this.btnExecuteCommand.Click += new System.EventHandler(this.btnExecuteCommand_Click);
            // 
            // btnExecuteAndSave
            // 
            this.btnExecuteAndSave.Location = new System.Drawing.Point(781, 379);
            this.btnExecuteAndSave.Name = "btnExecuteAndSave";
            this.btnExecuteAndSave.Size = new System.Drawing.Size(166, 23);
            this.btnExecuteAndSave.TabIndex = 20;
            this.btnExecuteAndSave.Text = "Execute And Save to Script";
            this.btnExecuteAndSave.UseVisualStyleBackColor = true;
            this.btnExecuteAndSave.Click += new System.EventHandler(this.btnExecuteAndSave_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 610);
            this.Controls.Add(this.btnExecuteAndSave);
            this.Controls.Add(this.btnExecuteCommand);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtCommandArea);
            this.Controls.Add(this.txtCommandHistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIndividualCommand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCommandOutput);
            this.Controls.Add(this.lbServers);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Pin Cushion";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox lbServers;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCommandOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnConnectExe;
        private System.Windows.Forms.TextBox txtIndividualCommand;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCommandHistory;
        private System.Windows.Forms.Label txtCommandArea;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem addServerToolStripMenuItem;
        private System.Windows.Forms.Button btnExecuteCommand;
        private System.Windows.Forms.ToolStripMenuItem openSavedConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveConnectionsToFileToolStripMenuItem;
        public System.Windows.Forms.Button btnExecuteScript;
        private System.Windows.Forms.ToolStripMenuItem openSavedCommandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveCommandsToFileToolStripMenuItem;
        private System.Windows.Forms.Button btnExecuteAndSave;
        private System.Windows.Forms.ToolStripMenuItem clearFieldsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandOutputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem individualCommandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinCushionBlogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    }
}

