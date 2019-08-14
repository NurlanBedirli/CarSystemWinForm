using CarLogin.CarModel;
using CarLogin.CarRegister;
using CarLogin.CityModel;
using CarLogin.DataBase;
using CarLogin.UsersCars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLogin
{
    public partial class AddCAR : Form
    {
        DbCars dbCars = new DbCars("CarDb");
        DbContext dbContext = new DbContext("CarDb");
        Users users = new Users();
        OpenFileDialog openFile = new OpenFileDialog();
        string imageLoading = "";
        private string valyuta;

        public AddCAR(string email)
        {
            InitializeComponent();
            Welcome(email);
            CarMarka();
            City();
            Year();
        }

        public void CarMarka()
        {
            CarList<CarMarka> cars = new CarList<CarMarka>();
            dbCars.GetCarsMarka();
            Table<CarMarka> marka = dbCars.marka;
            foreach (CarMarka marka1 in marka)
            {
                cars.Add(marka1);
            }
            cmbx_marka.DataSource = cars.GettAllData();
            cmbx_marka.DisplayMember = "Markas";
        }
        public void City()
        {
            CarList<City> cities = new CarList<City>();
            dbCars.GetCity();
          foreach(City cc in dbCars.cities)
            {
                cities.Add(cc);
            }
            cmbx_city.DataSource = cities.GettAllData();
            cmbx_city.DisplayMember = "CityName";
        }
        public void Year()
        {
            List<CarYear> year = new List<CarYear>();
            dbCars.GetYear();
          foreach(CarYear carYear in dbCars.carYears)
            {
                year.Add(carYear);
            }
            cmbx_year.DataSource = year;
            cmbx_year.DisplayMember = "Year";
        }

        public void Welcome(string email)
        {
            dbContext.GetAllData(users.GetType());
            Table<Users> data = dbContext.userData;
            foreach (Users users in data)
            {
                if (users.Email == email)
                {
                    label8.Text = users.Email;
                }
            }
        }


        


        private void button2_Click(object sender, EventArgs e)
        {
            txbx_image1.Visible = true;
            openFile.Filter = "jpg files (*.jpg)|*.jpg| PNG files(*.png)|*.png| ALL Files (*.*)|*.*" ;
            if (openFile.ShowDialog() == DialogResult.OK)
                imageLoading = openFile.FileName;
            txbx_image1.ImageLocation = imageLoading;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(openFile.FileName);
                UserCar userCar = new UserCar();
                userCar.Marka = cmbx_marka.Text;
                userCar.Model = cmbx_model.Text;
                userCar.City = cmbx_city.Text;
                userCar.Year = cmbx_year.Text;
                userCar.Desicription = txbx_desc.Text;
                userCar.Prize = txbx_prize.Text;
                userCar.Photo = fileInfo.Name;
                userCar.Currency = valyuta;
                userCar.UserId = DbExtensions.UserId(dbContext, users, label8.Text);


                string photoPath = ConfigurationManager.AppSettings["Path"].ToString();
                string fullPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\", photoPath, userCar.Photo));
                byte[] array = null;
                using (FileStream fileStream = File.Open(openFile.FileName, FileMode.Open))
                {
                    array = new byte[fileStream.Length];
                    fileStream.Read(array, 0, array.Length);
                }

                using (FileStream fileStream = File.Create(fullPath))
                {
                    fileStream.Write(array, 0, array.Length);
                }

                dbContext.InsertCommandUserCars(userCar.GetType(), userCar.Marka, userCar.Model, userCar.City, userCar.Year, userCar.Desicription, userCar.Prize, userCar.Photo, userCar.UserId, userCar.Currency);
                txbx_excPhoto.Text = "Elaniniz Ugurla Yerlesdirildi";
            }
            catch(Exception ex)
            {
               txbx_excPhoto.Text =  ex.Source = "Zehmet Olmasa Photonu Secin";
                string str = ex.Message;
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbx_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarMarka car = (CarMarka)cmbx_marka.SelectedItem;
            dbCars.FillId(car.MarkaId, cmbx_model);
        }

        private void cmbx_model_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            this.Hide();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CarSearch carSearch = new CarSearch(label8.Text);
            this.Hide();
            carSearch.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            valyuta = "Azn";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            valyuta = "$";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            valyuta = "Euro";
        }
    }
}
