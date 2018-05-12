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
    public partial class frmAddUser : Form
    {
        MagazynEntities context = new MagazynEntities();
        public frmAddUser()
        {
            InitializeComponent();
            comboBoxAdmin.SelectedIndex = 0;
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
            int admin = 0;
            try
            {
                if (String.IsNullOrEmpty(textBoxUsername.Text) ||
                    String.IsNullOrEmpty(textBoxPass.Text) ||
                    String.IsNullOrEmpty(textBoxVeryfiPass.Text) ||
                    String.IsNullOrEmpty(textBoxName.Text) ||
                    String.IsNullOrEmpty(textBoxSurname.Text))
                {
                    throw new Exception("Wszystkie dane muszą być uzupełnione.");
                }

                if (comboBoxAdmin.SelectedIndex == 1) admin = 1;
                if (String.Compare(textBoxPass.Text, textBoxVeryfiPass.Text) == -1) throw new Exception("Wpisane hasła muszą być identycze.");

                foreach (var user in context.Users)
                {
                    if (user.Username == textBoxUsername.Text)
                    {
                        throw new Exception("Wskazany użytkownik już istnieje w bazie danych.\nProszę zmień nazwę użytkownika.");
                    }
                }

                context.Users.Add(new Users
                {
                    Username = textBoxUsername.Text,
                    Password = CreateMD5(textBoxPass.Text),
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Admin = admin
                });
                context.SaveChanges();

                MessageBox.Show("Użytkownik został pomyślnie dodany.");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
