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
    public partial class frmModyfiUser : Form
    {
        MagazynEntities context = new MagazynEntities();
        int admin = 0;
        public frmModyfiUser(Users temp)
        {
            InitializeComponent();
            textBoxUsername.Text = temp.Username;
            textBoxName.Text = temp.Name;
            textBoxSurname.Text = temp.Surname;
            if (temp.Admin == 0)
            {
                comboBoxAdmin.SelectedIndex = 0;
            }
            else
            {
                comboBoxAdmin.SelectedIndex = 1;
            }
        }

        public static string CreateMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBoxUsername.Text) ||
                    String.IsNullOrEmpty(textBoxName.Text) ||
                    String.IsNullOrEmpty(textBoxSurname.Text))
                {
                    throw new Exception("Wszystkie dane muszą być uzupełnione.");
                }

                if (comboBoxAdmin.SelectedIndex == 1) admin = 1;

                var result = context.Users.SingleOrDefault(b => b.Username == textBoxUsername.Text);
                if (result != null)
                {
                    result.Name = textBoxName.Text;
                    result.Surname = textBoxSurname.Text;
                    result.Admin = admin;
                    if (textBoxPassword.Text.Length != 0)
                    {
                        result.Password = CreateMD5(textBoxPassword.Text);
                    }
                    context.SaveChanges();
                }

                MessageBox.Show("Użytkownik został pomyślnie zmodyfikowany.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void newPass_Click(object sender, EventArgs e)
        {
            textBoxPassword.ReadOnly = false;
        }



    }
}
