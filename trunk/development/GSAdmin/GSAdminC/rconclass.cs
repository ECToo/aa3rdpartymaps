using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace GSAdminC
{
    public class RCON
    {
        private string ip;
        private int port;
        private string password;

        /// <summary>
        /// Initializes a server for sending command
        /// </summary>
        /// <param name="IP">String IP Address</param>
        /// <param name="Port">Integer Port Number</param>
        /// <param name="Password">String Password</param>
        /// <returns>Boolean</returns>
        public bool initServer(string IP, int Port, string Password)
        {
            try
            {
                IPAddress.Parse(IP);
                ip = IP;
                port = Port;
                password = Password;
                return true;
            }
            catch 
            {
                return false;
            }


        }
        /// <summary>
        /// Sends the Command that has been defined
        /// </summary>
        /// <returns>String response from server.</returns>
        public string sendCommand(string rconcommand)
        {

            try
            {

                //connecting to server
                Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                client.Connect(IPAddress.Parse(ip), port);

                string command;
                string returned;
                string cleanstring;
                command = "rcon " + password + " " + rconcommand;
                byte[] bufferTemp = Encoding.ASCII.GetBytes(command);
                byte[] bufferSend = new byte[bufferTemp.Length + 5];

                //intial 5 characters as per standard
                bufferSend[0] = byte.Parse("255");
                bufferSend[1] = byte.Parse("255");
                bufferSend[2] = byte.Parse("255");
                bufferSend[3] = byte.Parse("255");
                bufferSend[4] = byte.Parse("02");
                int j = 5;

                for (int i = 0; i < bufferTemp.Length; i++)
                {
                    bufferSend[j++] = bufferTemp[i];
                }

                //send rcon command and get response
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
                client.Send(bufferSend, SocketFlags.None);

                //big enough to receive response
                byte[] bufferRec = new byte[65000];
                client.Receive(bufferRec);

                //remove sucky chars.
                returned = Encoding.ASCII.GetString(bufferRec);
                cleanstring = returned.Replace("????", "");
                return cleanstring.Replace("\n", "\r\n");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            
        }
    }
}