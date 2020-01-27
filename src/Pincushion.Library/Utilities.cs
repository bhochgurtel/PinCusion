

using System.Collections.Generic;
using System.Windows.Forms;

namespace PinCushion.Library
{
    public class Utilities
    {
        private static string message;

        public static void loadConnectionsToEdit(ref ComboBox localCombo, Dictionary<string, Connection> myDictOfConnections)
        {
            List<string> _items = new List<string>();
            int i = 0;
            
            if(message.Length>0)
            {
                _items.Add(message);
            }

            if (myDictOfConnections.Count > 0)
            {
                if (i == 0)
                {
                    foreach (KeyValuePair<string, Connection> entry in myDictOfConnections)
                    {
                        _items.Add(entry.Key);
                    }
                }
                else
                {
                    _items.Add("Please select a connection to edit");
                }
                
            }
            localCombo.DataSource = _items;
        }

        public static void loadConnectionsToEdit(ref ComboBox localCombo, Dictionary<string, Connection> myDictOfConnections, string defaultMessage)
        {
            message = defaultMessage;
            loadConnectionsToEdit(ref localCombo, myDictOfConnections);
        }
    }
}
