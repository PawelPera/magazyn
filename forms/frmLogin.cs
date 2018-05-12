using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Magazyn
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
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

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MagazynEntities context = new MagazynEntities();
            Users user = new Users();
            Users veryfiUser = new Users();
            user.Username = textBoxUsername.Text;
            user.Password = CreateMD5(textBoxPassword.Text);

            if (String.IsNullOrEmpty(user.Username) || String.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show("Nazwa użytkownika i hasło nie mogą być puste!");
                return;
            }
            else
            {

                veryfiUser = context.Users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
                if (veryfiUser == null)
                {
                    MessageBox.Show("Proszę podaj poprawną nazwe użytkownika lub hasło.");
                    return;
                }
            }

            if (user.Username == veryfiUser.Username)
            {
                if (user.Password == veryfiUser.Password)
                {
                    frmMain main = new frmMain(veryfiUser);
                    this.Hide();
                    main.Show();
                    return;
                }
                else
                {
                    MessageBox.Show("Proszę podaj poprawną nazwe użytkownika lub hasło.");
                    return;
                }
            }
        }


    }
}
