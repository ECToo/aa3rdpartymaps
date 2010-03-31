using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GSAdminC
{
    public partial class programSettings : Form
    {
        Properties.Settings settings = new Properties.Settings();
        Functions func = new Functions();
        public programSettings()
        {
            InitializeComponent();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            try
            {
                #region checkbeforesave
                if (chkStart.Checked)
                {
                    settings.startup = true;
                }
                else
                {
                    settings.startup = false;
                }

                if (chkAuto.Checked)
                {
                    settings.autorefresh = true;
                    settings.interval = Convert.ToInt32(numMin.Value) * 60;

                }
                else
                {
                    settings.autorefresh = false;
                    settings.interval = 0;
                }

                if (chkMinimize.Checked)
                {
                    settings.minimize = true;
                }
                else
                {
                    settings.minimize = false;
                }

                if (chkNotify.Checked)
                {
                    settings.notify = true;
                }
                else
                {
                    settings.notify = false;
                }

                if (chkBots.Checked)
                {
                    settings.showbots = true;
                }
                else
                {
                    settings.showbots = false;
                }

                if (chkJoin.Checked)
                {
                    if (txtLocation.Text == "")
                    {
                        throw new Exception("To enable join game, you must locate your installation of Alien Arena");
                    }
                    else
                    {
                        settings.enablejoin = true;
                        settings.aalocation = txtLocation.Text;
                        settings.playername = txtPlayer.Text;
                    }
                }
                else
                {
                    settings.enablejoin = false;
                    settings.aalocation = "";
                    settings.playername = "";
                }

                settings.Save();
                this.Close();
                #endregion
            }
            catch (Exception ex)
            {
                func.exceptionbox(ex.Message);
            }

        }

        private void programSettings_Load(object sender, EventArgs e)
        {
            #region loadsettings 
            settings.Reload();

            if(settings.startup){
                chkStart.Checked = true;
            }

            if(settings.autorefresh){
                chkAuto.Checked = true;
                if (settings.interval == 0)
                {
                    numMin.Value = 1;
                }
                else
                {
                    numMin.Value = settings.interval / 60;
                }
            }

            if(settings.minimize){
                chkMinimize.Checked = true;
            }

            if(settings.notify){
                chkMinimize.Checked = true;
            }

            if (settings.showbots)
            {
                chkBots.Checked = true;
            }
            
            if(settings.enablejoin){
                if(settings.aalocation != "" && settings.playername != ""){
                    chkJoin.Checked = true;
                    txtLocation.Text = settings.aalocation;
                    txtPlayer.Enabled = true;
                    txtPlayer.Text = settings.playername;
                }else{
                    chkJoin.Checked= false;
                    txtPlayer.Enabled = false;
                }
            }

            if (chkJoin.Checked)
            {
                btnBrowse.Enabled = true;
            }
            else
            {
                btnBrowse.Enabled = false;
            }
            

            #endregion
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult returned = new DialogResult();
            returned = gameBrowse.ShowDialog();
            //string location = gameBrowse.SelectedPath();
            try
            {
                if (returned == DialogResult.OK)
                {
                    if (!File.Exists(gameBrowse.SelectedPath + "\\crx.exe"))
                    {
                        txtLocation.Text = "";
                        txtPlayer.Enabled = false;
                        txtPlayer.Text = "";
                        throw new Exception("Alien Arena not found in " + gameBrowse.SelectedPath);
                    }
                    else
                    {
                        func.successbox("Alien Arena located");
                        txtPlayer.Enabled = true;
                        txtLocation.Text = Convert.ToString(gameBrowse.SelectedPath);
                    }
                }
                
            }
            catch(Exception ex)
            {
                func.exceptionbox(ex.Message);
            }
            

        }

        private void chkJoin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJoin.Checked)
            {
                btnBrowse.Enabled = true;
            }
            else
            {
                btnBrowse.Enabled = false;
            }
        }
    }
}
