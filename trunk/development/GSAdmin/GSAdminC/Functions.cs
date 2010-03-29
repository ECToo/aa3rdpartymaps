using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace GSAdminC
{
    class Functions
    {          

        public bool settingsexist()
        {
            if (Properties.Settings.Default.firstrun == false)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Validates an IP address.
        /// </summary>
        /// <param name="addr">IP Address to check.</param>
        /// <returns>Boolean</returns>
        public bool isValidIP(string addr)
        {
            //create our match pattern
            string strPattern = @"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            //create our Regular Expression object
            Regex check = new Regex(strPattern);
            //boolean variable to hold the status
            bool valid = false;
            valid = check.IsMatch(addr, 0);
            //return the results
            return valid;
        }

        public bool validatePort(string Port)
        {
            try
            {
                int port;
                try
                {
                    port = Convert.ToInt32(Port);
                }
                catch
                {
                    return false;
                }

                if (port > 65535 || port < 1)
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Simple text validation for null value.
        /// </summary>
        /// <param name="data">String to check</param>
        /// <returns>Boolean</returns>
        public bool validateText(string data)
        {
            if (string.IsNullOrEmpty(data) || data.Replace(" ","") == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public bool serverOffline(string Record)
        {
            string[] field;
            field = Record.Split('^');
            GameServerInfo.GameServer server = new GameServerInfo.GameServer(field[0], Convert.ToInt32(field[1]), GameServerInfo.GameType.Quake3);
            server.QueryServer();

            if (!server.IsOnline)
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }

        /// <summary>
        /// Adds a server to the string collection
        /// </summary>
        /// <param name="IPAddr">The server IP address</param>
        /// <param name="Port">The server Port number</param>
        /// <param name="Password">The server password</param>
        /// <param name="ServerName">The server display name</param>
        /// <returns>Boolean</returns>
        public bool addserver(string IPAddr, string Port, string Password, string ServerName)
        {
            try
            {
                Properties.Settings.Default.servers.Add(IPAddr + "^" + Port + "^" + Password + "^" + ServerName + "^" + "1");
                Properties.Settings.Default.Save();
                successbox("Server added successfully");
                return true;
            }
            catch
            {
                exceptionbox("Could not access settings database");
                return false;
            }
        }

        
        /// <summary>
        /// Shows a messagebox with Error icon.
        /// </summary>
        /// <param name="message">String message to display.</param>
        public void exceptionbox(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows a messagebox with information icon.
        /// </summary>
        /// <param name="message">String message to display.</param>
        public void successbox(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Shows a messagebox with question icon.
        /// </summary>
        /// <param name="message">String message to display.</param>
        public bool questionbox(string message)
        {
            DialogResult result;
            result = MessageBox.Show(message, "Question.", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks the success or failure of the rcon command response.
        /// </summary>
        /// <param name="Data">The response from the sendCommand.</param>
        /// <returns>True if valid, false if invalid.</returns>
        public bool cmdValid(string Data)
        {
            string data = Data.ToLower();
            bool valid = true;
            if (data.Contains("can't find"))
            {
                valid = false;
            }

            if (data.Contains("bad rcon"))
            {
                valid = false;
            }

            if (data.Contains("unknown"))
            {
                valid = false;
            }
            return valid;
        }

        /// <summary>
        /// This function intentionally left blank ;)
        /// </summary>
        public void showNothing()
        {
        }
        

    }
}
