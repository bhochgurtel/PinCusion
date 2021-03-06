﻿/*
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


using System;

namespace PinCushion.Library
{
    [Serializable]
    public sealed class Connection
    {
        private string server;
        private string ipaddress;
        private string username;
        private string password;
        private string connectionName;
        //private string passphrase;
        //private string passphrase2;

        public Connection(string ConnectionName,string Server, string IPAddress, string PassedUser,string Password,string Passphrase)
        {
            server = Server;
            ipaddress = IPAddress;
            username = PassedUser;
            password = EncryptDecrypt.Encrypt(Password,Passphrase);
            //passphrase = EncryptDecrypt.Encrypt(Passphrase,Passphrase);
            
            connectionName = ConnectionName;
        }

        public string ConnectionName
        {
            get { return connectionName; }
            set { connectionName = value; }
        }

        public string Server
        {
            get { return server; }
            set { server = value; }
        }
       
        public string Ipaddress
        {
            get { return ipaddress; }
            set { ipaddress = value; }
        }
        
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        /*
        public string Password
        {
            get {
                password = EncryptDecrypt.Decrypt(password, passphrase);
                return password; 
            }
            set { 
                password = EncryptDecrypt.Encrypt(value,passphrase);
                //passphrase = EncryptDecrypt.Encrypt(passphrase, passphrase);
            }
        }
         */
        
        public string DecriptPassword(string passphrase)
        {
            string localPassword = EncryptDecrypt.Decrypt(password, passphrase);
            return localPassword; 
        }
        

    }
         




}
