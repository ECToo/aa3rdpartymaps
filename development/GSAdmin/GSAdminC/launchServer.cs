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
    public partial class launchServer : Form
    {
        public launchServer()
        {
            InitializeComponent();
        }

        public Int32 newflags;
        public Int32 oldflags;

        public void addFlags(Int32 number)
        {
            oldflags = Convert.ToInt32(txtDMFlags.Text);
            txtDMFlags.Text = Convert.ToString(oldflags + number);
        }

        public void removeFlags(Int32 number)
        {
            oldflags = Convert.ToInt32(txtDMFlags.Text);
            txtDMFlags.Text = Convert.ToString(oldflags - number);
        }



        private void cmbNoPowerups_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbNoPowerups.Checked)
            {

                addFlags(2);
            }
            else
            {
                removeFlags(2);
            }
        }

        private void cmbInstantPowerups_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbInstantPowerups.Checked)
            {

                addFlags(16);
            }
            else
            {
                removeFlags(16);
            }
        }

        private void cmbQuadDrop_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbQuadDrop.Checked)
            {

                addFlags(16384);
            }
            else
            {
                removeFlags(16384);
            }
        }

        private void cmbNoHealth_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbNoHealth.Checked)
            {
                addFlags(1);
            }
            else
            {
                removeFlags(1);
            }
        }

        private void cmbWeaponsStay_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbWeaponsStay.Checked)
            {
                addFlags(4);
            }
            else
            {
                removeFlags(4);
            }
        }

        private void cmbInfiniteAmmo_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbInfiniteAmmo.Checked)
            {
                addFlags(8192);
            }
            else
            {
                removeFlags(8192);
            }
        }

        private void cmbNoArmor_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbNoArmor.Checked)
            {
                addFlags(2048);
            }
            else
            {
                removeFlags(2048);
            }
        }

        private void cmbNoFriendlyFire_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbNoFriendlyFire.Checked)
            {
                addFlags(256);
            }
            else
            {
                removeFlags(256);
            }
        }

        private void cmbTeamsByModel_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbTeamsByModel.Checked)
            {
                addFlags(128);
            }
            else
            {
                removeFlags(128);
            }
        }

        private void cmbTeamsBySkin_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbTeamsBySkin.Checked)
            {
                addFlags(64);
            }
            else
            {
                removeFlags(64);
            }
        }

        private void cmbDisableBots_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbDisableBots.Checked)
            {
                addFlags(1048576);
            }
            else
            {
                removeFlags(1048576);
            }
        }

        private void cmbBotPerfectAim_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbBotPerfectAim.Checked)
            {
                addFlags(524288);
            }
            else
            {
                removeFlags(524288);
            }
        }

        private void cmbDisableBotChat_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbDisableBotChat.Checked)
            {
                addFlags(262144);
            }
            else
            {
                removeFlags(262144);
            }
        }

        private void cmbBotAutosaveNodes_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbBotAutosaveNodes.Checked)
            {
                addFlags(131072);
            }
            else
            {
                removeFlags(131072);
            }
        }

        private void cmbAdvanceLevel_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbAdvanceLevel.Checked)
            {
                addFlags(2097152);
            }
            else
            {
                removeFlags(2097152);
            }
        }

        private void cmbSameMap_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbSameMap.Checked)
            {
                addFlags(32);
            }
            else
            {
                removeFlags(32);
            }
        }

        private void cmbAllowExit_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbAllowExit.Checked)
            {
                addFlags(4096);
            }
            else
            {
                removeFlags(4096);
            }
        }

        private void cmbForceRespawn_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbForceRespawn.Checked)
            {
                addFlags(1024);
            }
            else
            {
                removeFlags(1024);
            }
        }

        private void cmbSpawnFarthest_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbSpawnFarthest.Checked)
            {
                addFlags(512);
            }
            else
            {
                removeFlags(512);
            }
        }

        private void cmbNoFallingDamage_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbNoFallingDamage.Checked)
            {
                addFlags(8);
            }
            else
            {
                removeFlags(8);
            }
        }

        private void cmbFixedFOV_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbFixedFOV.Checked)
            {
                addFlags(32768);
            }
            else
            {
                removeFlags(32768);
            }
        }

        private void launchServer_Load(object sender, EventArgs e)
        {
            cmbSkillLevel.SelectedIndex = 0;
            cmbGameType.SelectedIndex = 0;
        }

        private void chkPassworded_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassworded.Checked)
            {
                txtPassword.Text = "password";
                txtPassword.Visible = true;
            }
            else
            {
                txtPassword.Visible = false;
            }
        }
    }
}
