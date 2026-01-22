using Microsoft.EntityFrameworkCore.Storage;
using paaswordhash.Context;
using paaswordhash.Models;

namespace paaswordhash


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBemailRegi.Text) 
                && !string.IsNullOrEmpty(TBNicknameReg.Text)
                && !string.IsNullOrEmpty(TBPasswordReg.Text))
            {
                string name = TBNicknameReg.Text;
                string emial = TBemailRegi.Text;
                string passwordHash = LoginHelper.HashPassword(TBPasswordReg.Text);

                LoginUser newUser = new LoginUser
                {
                    NickName = name,
                    Email = emial,
                    PasswordHash = passwordHash,
                };
                Database.LoginUsers.Add(newUser);
                Database.SaveChanges();

            }
        }

        private void BTNlogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBNicknameLogin.Text) 
                && !string.IsNullOrEmpty(TBPasswordLogin.Text))
            {
                var user = Database.LoginUsers.FirstOrDefault(u => u.NickName == TBNicknameLogin.Text);
                if (user != null && LoginHelper.VerifyPassword(TBPasswordLogin.Text, user.PasswordHash))
                {
                    MessageBox.Show("Sikeres bejelentkezés");
                }
                else {
                    MessageBox.Show("Sikeres bejelentkezés");
                }
            }
        }
    }
}
