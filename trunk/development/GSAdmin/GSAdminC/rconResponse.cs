using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GSAdminC
{
    public partial class rconResponse : Form
    {
        public rconResponse()
        {
            InitializeComponent();
        }

        public void servername(string servername)
        {
            label1.Text = "Server: " + servername;
        }

        public void response(string data, bool newline){
            
            textBox1.AppendText(data);
            if (newline)
            {
                textBox1.AppendText(Environment.NewLine);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }

        private void rconResponse_Load(object sender, EventArgs e)
        {

        }
    }
}
