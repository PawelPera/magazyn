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
    public partial class frmUsers : Form
    {
        MagazynEntities context = new MagazynEntities();
        public frmUsers()
        {
            InitializeComponent();
            dataGridView.DataSource = context.Users.ToList();
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].HeaderText = "Nazwa użytkownika";
            dataGridView.Columns[2].Visible = false;
            dataGridView.Columns[3].HeaderText = "Imię";
            dataGridView.Columns[4].HeaderText = "Nazwisko";
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Czy jesteś pewien że chcesz usunąć użytkownika?", "Uwaga", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int rows = dataGridView.RowCount - 1;
                    for (int i = rows; i >= 0; i--)
                    {
                        if (dataGridView.Rows[i].Selected)
                        {
                            context.Users.Remove(dataGridView.Rows[i].DataBoundItem as Users);
                            context.SaveChanges();
                        }
                    }
                    dataGridView.DataSource = context.Users.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshData_Click(object sender, EventArgs e)
        {
            MagazynEntities tmpContext = new MagazynEntities();
            dataGridView.DataSource = tmpContext.Users.ToList();
            tmpContext.Dispose();
        }

        private void modyfiUser_Click(object sender, EventArgs e)
        {
            int rows = dataGridView.RowCount - 1;
            for (int i = rows; i >= 0; i--)
            {
                if (dataGridView.Rows[i].Selected)
                {
                    Users temp = new Users();
                    temp = dataGridView.Rows[i].DataBoundItem as Users;
                    frmModyfiUser modyfiUser = new frmModyfiUser(temp);
                    modyfiUser.Show();
                    return;
                }
            }
        }

        private void addUser_Click(object sender, EventArgs e)
        {
            frmAddUser addUsers = new frmAddUser();
            addUsers.Show();
        }



    }
}
