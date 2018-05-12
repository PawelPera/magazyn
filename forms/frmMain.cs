using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazyn
{
    public partial class frmMain : Form
    {
        Users user;
        public frmMain(Users user)
        {
            InitializeComponent();
            this.user = user;
            if (user.Admin == 1)
            {
                administratorToolStripMenuItem.Visible = true;
            }

            labelWelcome.Text = "Witaj, " + user.Name + " " + user.Surname;

        }
        private void ZarzadzajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmUsers userPanel = new frmUsers();
            //userPanel.Show();
        }

        private void zamknijSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zmienHasloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPassChange passChange = new frmPassChange(user);
            passChange.Show();
            return;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ZarządzajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers userPanel = new frmUsers();
            userPanel.Show();
        }
    }
}
