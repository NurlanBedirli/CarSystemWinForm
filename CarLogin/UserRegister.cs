using CarLogin.CarRegister;
using CarLogin.DataBase;
using CarLogin.UserModel;
using CarLogin.ValidatorAttr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLogin
{
    public partial class UserRegister : Form
    {
        DbContext dbContext = new DbContext("CarDb");

        public UserRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmptyString();
            Users user = new Users();
            user.Name = text_reg_name.Text;
            user.Surname = text_reg_surname.Text;
            user.Email = text_reg_email.Text;
            user.Password = text_reg_password.Text;
            UserValidator validator = new UserValidator();
            if(!validator.Valid<Users>(user))
            {
                dbContext.GetAllData(user.GetType());
                Table<Users> table = dbContext.userData;
                if (!DbExtensions.HasUserByEmail(table, user.Email))
                {
                    dbContext.InsertCommand(user.GetType(), user.Name, user.Surname, user.Email, user.Password);
                }
                else
                {
                    MessageBox.Show("Bele bir User Artiq Movcuddur");
                }
            }
            else
            {
                   var keyValues = validator.GetAllData();
                
             foreach(var ss in keyValues)
                {
                    if(ss.Key == 1)
                    {
                        text_errorName.Text = ss.Value;
                    }
                    if(ss.Key == 2)
                    {
                        text_errorSurname.Text = ss.Value;
                    }
                    if(ss.Key == 3)
                    {
                        text_errorEmail.Text = ss.Value;
                    }
                    if(ss.Key == 4)
                    {
                        text_errorPassword.Text = ss.Value;
                    }
                }
            }
        }

        private void EmptyString()
        {
            text_errorName.Text = "";
            text_errorSurname.Text = "";
            text_errorEmail.Text = "";
            text_errorPassword.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserSignIn userSignIn = new UserSignIn();
            this.Hide();
            userSignIn.ShowDialog();
        }
    }
}
