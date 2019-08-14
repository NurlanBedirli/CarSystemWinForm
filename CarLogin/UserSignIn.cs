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
    public partial class UserSignIn : Form
    {
        DbContext dbContext = new DbContext("CarDb");
        CarSearch carSearch;
        public UserSignIn()
        {
            InitializeComponent();
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            this.Hide();
            userRegister.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text_errorEmail.Text = "";
            text_errorPassword.Text = "";
            Users users = new Users();
            UserSignInModel signInModel = new UserSignInModel();
               signInModel.Email = text_sign_email.Text;
               signInModel.Password = text_sign_password.Text;
             UserValidator validator = new UserValidator();
            if(!validator.Valid<UserSignInModel>(signInModel))
            {
                carSearch = new CarSearch(signInModel.Email);
                dbContext.GetAllData(users.GetType());
               Table<Users> data = dbContext.userData;
               if(DbExtensions.HasUserByEmail(data,signInModel.Email) && DbExtensions.HasUserByPassword(data,signInModel.Password) )
                {
                    carSearch = new CarSearch(signInModel.Email);
                    this.Hide();
                    carSearch.ShowDialog();
                }
            }
            else
            {
                var errors = validator.GetAllData();
             foreach(var user in errors)
                {
                    if(user.Key == 3)
                    {
                        text_errorEmail.Text = user.Value;
                    }
                    if(user.Key == 4)
                    {
                        text_errorPassword.Text = user.Value;
                    }
                }
            }
        }
    }
}
