using CarLogin.CarModel;
using CarLogin.CarRegister;
using CarLogin.CityModel;
using CarLogin.DataBase;
using CarLogin.SearchModel;
using CarLogin.Session;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CarLogin
{
    public partial class CarSearch : Form
    {
        DbCars dbCars = new DbCars("CarDb");
        DbContext dbContext = new DbContext("CarDb");
        Users users = new Users();
        AddCAR addCAR;
        public CarSearch(string email)
        {
            InitializeComponent();
            
            addCAR = new AddCAR(email);
            Welcome(email);
            CarMarka();
            City();
            Year();
           
        }


        public void Welcome(string email)
        {
            dbContext.GetAllData(users.GetType());
            Table<Users> data = dbContext.userData;
          foreach(Users users in data)
            {
                if(users.Email == email)
                {
                   if(users.Email != null)
                    {
                        Label label = new Label();
                        label.Text = " WELCOME ";
                        label.Size = new System.Drawing.Size(70, 15);
                        label.Location = new System.Drawing.Point(55, 15);
                        label.BackColor = System.Drawing.Color.Black;
                        label.ForeColor = System.Drawing.Color.Red;
                        Controls.Add(label);
                        txbx_welcome.Text = users.Name;
                        txbx_welcome2.Text = users.Email;
                    }
                   
                }
            }
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
            foreach (City cc in dbCars.cities)
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
            foreach (CarYear carYear in dbCars.carYears)
            {
                year.Add(carYear);
            }
            cmbx_year.DataSource = year;
            cmbx_year.DisplayMember = "Year";
        }



        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            addCAR.ShowDialog();
        }

        private void cmb_model_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb__SelectedIndexChanged(object sender, EventArgs e)
        {
            CarMarka car = (CarMarka)cmbx_marka.SelectedItem;
            dbCars.FillId(car.MarkaId, cmb_model);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchCar searchCar = new SearchCar();
            searchCar.City = cmbx_city.Text;
            searchCar.Model = cmb_model.Text;
            searchCar.Marka = cmbx_marka.Text;
            searchCar.Year = cmbx_year.Text;
            dbContext.SearchCar(searchCar.City, searchCar.Marka, searchCar.Model, searchCar.Year);
            var cars = dbContext.carsSearch;
            SessionDb.table = dbContext.carsSearch;
                if (cars.data.Count != 0)
                {
                    AllSearchCars allSearch = new AllSearchCars();
                    this.Hide();
                    allSearch.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bele Bir Masin Elani Yoxdur");
                }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu();
            this.Hide();
            form.ShowDialog();
        }
    }
}
