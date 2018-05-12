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
    public partial class frmPassChange : Form
    {
        Users tmp;
        public frmPassChange(Users tmp)
        {
            InitializeComponent();
            this.tmp = tmp;
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
        private void buttonNewPass_Click(object sender, EventArgs e)
        {
            try
            {
                MagazynEntities context = new MagazynEntities();

                if (String.IsNullOrEmpty(textBoxPassword.Text) ||
                    String.IsNullOrEmpty(textBoxNewPassword.Text) ||
                    String.IsNullOrEmpty((textBoxNewPasswordVeryfi.Text)))
                {
                    throw new Exception("Wszystkie dane muszą być uzupełnione.");
                }
                if (String.Compare(textBoxNewPassword.Text, textBoxNewPasswordVeryfi.Text) == -1) throw new Exception("Wpisane hasła muszą być identycze.");

                var result = context.Users.SingleOrDefault(b => b.Username == tmp.Username);
                if (result != null && result.Password == CreateMD5(textBoxPassword.Text))
                {
                    result.Password = CreateMD5(textBoxNewPassword.Text);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Aktualne hasło jest nieprawidłowe.");
                }

                MessageBox.Show("Hasło zostało pomyślnie zmienione.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
