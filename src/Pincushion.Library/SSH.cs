/*
MIT License
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

/*
This code is based on Renci SSH.
https://github.com/sshnet/SSH.NET
*/


using System;
using System.Text;
using Renci.SshNet;
using System.Threading;

namespace PinCushion.Library
{
    public class SSH
    {
        protected SshClient client = null;
        protected SshCommand command = null;
        protected ConnectionInfo connectionInfo = null;
        string username = string.Empty;
        string password = string.Empty;
        string server = string.Empty;
        StringBuilder completeLog = new StringBuilder();
        String lastActionLog;

        public SSH(string UserName, string Password,string Server,int port=22,bool keyboard=true)
        {
            username = UserName;
            password = Password;
            server = Server;
            if(keyboard)
              handleKeyBoardSetup(port);
        }

        public void handleKeyBoardSetup(int port=22,string localServer="")
        {
            if (localServer=="")
            {
                localServer = server;
            }
            KeyboardInteractiveAuthenticationMethod kauth = new KeyboardInteractiveAuthenticationMethod(username);
            PasswordAuthenticationMethod pauth = new PasswordAuthenticationMethod(username, password);
            kauth.AuthenticationPrompt += new EventHandler<Renci.SshNet.Common.AuthenticationPromptEventArgs>(HandleKeyEvent);
            connectionInfo = new ConnectionInfo(localServer, port, username, pauth, kauth);
            client = new SshClient(connectionInfo);
        }

        public void handleConnection(string command)
        {
            using (var localclient = new SshClient(server, username, password))
            {
                localclient.Connect();
                SshCommand mySsh = localclient.RunCommand(command);
     
                 LogEvent(mySsh.Result);

                localclient.Disconnect();
            }
        }

        public void HandleKeyEvent(Object sender, Renci.SshNet.Common.AuthenticationPromptEventArgs e)
        {
            foreach (Renci.SshNet.Common.AuthenticationPrompt prompt in e.Prompts)
            {
                if (prompt.Request.IndexOf("Password:", StringComparison.InvariantCultureIgnoreCase) != -1)
                {
                    prompt.Response = password;
                }
            }
        }

        public void AttemptConnection (int maxTries=3)
        {
            int attempt = 0;
            
            while (!client.IsConnected && attempt <= maxTries)
            {
                client.Connect();
                if (!client.IsConnected)
                {
                    LogEvent( "Sleeping 6 seconds to retry connection.\r\n");
                    Thread.Sleep(6000);
                }
            }

            LogEvent("Successfully connected to:" + this.server + "\r\n" + client.CreateCommand("pwd").Execute() + "\r\n");
        }

        public void ExecuteCommand(string command)
        {
            using (var cmd = client.CreateCommand(command))
            {
                cmd.Execute();
                LogEvent(cmd.Result.Replace("\n", "\r\n"));
            }
        }

        public void Disconnect()
        {
            client.Disconnect();
            LogEvent("Disconnected from " + this.server + "\r\n");
        }

        public void LogEvent(string localEvent)
        {
            this.completeLog.Append(localEvent);
            this.lastActionLog = localEvent;
        }

        public string GetLastAction()
        {
            return lastActionLog;
        }

        public string GetCompleteLog()
        {
            return completeLog.ToString();
        }


    }
}
