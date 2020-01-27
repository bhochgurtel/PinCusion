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

using System;
using System.Collections.Generic;

namespace PinCushion.Library
{

    public sealed class Connections
    {
        private static Dictionary<string,Connection> ConnectionsDict = new Dictionary<string, Connection>();

        public static Connection RetriveConnection(string ConnectionName)
        {
            if (ConnectionsDict.Count > 0)
                return ConnectionsDict[ConnectionName];
            else
                throw new Exception("Must Have Connections before you retrieve them");
        }

        public static Dictionary<string,Connection> RetrieveDictionary()
        {
            return ConnectionsDict;
        }

        public static void SaveDictionary(Dictionary<string,Connection> LocalConnections)
        {
            ConnectionsDict = LocalConnections;
        }


        public static void AddConnection(Connection connection)
        {
            //if this fails, go ahead and add
            if (!ConnectionExists(connection.ConnectionName))
                ConnectionsDict.Add(connection.ConnectionName, connection);
            else
                throw new Exception("Connection already exists. Please use a unique connection name.");
        }

        public static bool ConnectionExists(string name)
        {

            try
            {
                if ( ConnectionsDict.Count >0 )
                    return ConnectionsDict[name].Equals(name);
                else 
                    return false;
            } catch (Exception e)
            { 
                return false;
            }
            
        }

        public static void RemoveConnection(string name)
        {
            ConnectionsDict.Remove(name);
        }

        public static Connection RetrieveSpecificConnection(string ConnectionName)
        {
            return ConnectionsDict[ConnectionName];
        }

        public static String[] RetrieveConnectionNames()
        {
            String[] names = new String[ConnectionsDict.Count];
            int i = 0;

            foreach(var item in ConnectionsDict)
            {
                names[i] = item.Key;
                i++;
            }

            return names;
        }
    }
}
