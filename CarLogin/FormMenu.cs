using CarLogin.CarRegister;
using CarLogin.DataBase;
using CarLogin.UserModel;
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
    public partial class FormMenu : Form
    {
        DbContext dbContext = new DbContext("CarDb");
        private readonly string email;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Panel(Control btn)
        {
            panel_slider.Width = btn.Width;
            panel_slider.Left = btn.Left;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel(button1);
            UserSignIn userSign = new UserSignIn();
            this.Hide();
            userSign.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Panel(button2);
            UserRegister register = new UserRegister();
            this.Hide();
            register.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Panel(button3);
            panel4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Panel(button4);
            AllData data = new AllData();
            this.Hide();
            data.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Panel(button5);
            CarSearch carSearch = new CarSearch(email);
            this.Hide();
            carSearch.ShowDialog();

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            //panel4.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            //panel4.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            UserSignInModel userSignIn = new UserSignInModel();
            userSignIn.Email = txbx_email.Text;
            userSignIn.Password = txbx_password.Text;
            dbContext.GetAllData(users.GetType());
            Table<Users> data = dbContext.userData;
            if (DbExtensions.HasUserByEmail(data, userSignIn.Email) && DbExtensions.HasUserByPassword(data, userSignIn.Password))
            {
                AddCAR addCAR = new AddCAR(userSignIn.Email);
                this.Hide();
                addCAR.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bele Bir User Qeydiyyatdan Kecmeyib");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
