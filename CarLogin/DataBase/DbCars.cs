using CarLogin.CarModel;
using CarLogin.CityModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarLogin.DataBase
{
   public class DbCars
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public Table<CarMarka> marka;
        public Table<CarsModel> model;
        public List<CarsModel> models;
        public List<City> cities;
        public List<CarYear> carYears;

        public DbCars(string ConfigName)
        {
            sqlConnection = new SqlConnection(ConfigConnection(ConfigName));
            sqlConnection.Open();
            marka = new Table<CarMarka>();
            model = new Table<CarsModel>();
            models = new List<CarsModel>();
            cities = new List<City>();
            carYears = new List<CarYear>();
        }

        public string ConfigConnection(string ConfigName)
        {
            string connectionConfig = ConfigurationManager.ConnectionStrings[ConfigName].ConnectionString;
            return connectionConfig;
        }

        public void GetCarsMarka()
        {
            using (sqlCommand = new SqlCommand("Select *From CarsMarka", sqlConnection))
            {
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        marka.Add(new CarMarka
                        {
                         MarkaId = Convert.ToInt32(dataReader["MarkaId"]),
                         Markas = dataReader["Marka"].ToString(),
                        });
                    }
                }
            }
        }

        public void GetYear()
        {
            using (sqlCommand = new SqlCommand("Select *From Year", sqlConnection))
            {
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        carYears.Add(new CarYear
                        {
                            Id = Convert.ToInt32(dataReader["YearId"]),
                            Year = Convert.ToInt32(dataReader["YearName"])
                        });
                    }
                }
            }
        }


        public void GetCarsModel()
        {
            using (sqlCommand = new SqlCommand("Select *From CarsModel", sqlConnection))
            {
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        model.Add(new CarsModel
                        {
                            Id = Convert.ToInt32(dataReader["ModelId"]),
                            Model = dataReader["Model"].ToString(),
                            MarkaId = Convert.ToInt32(dataReader["MarkaId"])
                        });
                    }
                }
            }
        }



        public void GetCity()
        {
            using (sqlCommand = new SqlCommand("Select *From City", sqlConnection))
            {
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        cities.Add(new City
                        {
                            CityId = Convert.ToInt32(dataReader["CityId"]),
                            CityName = dataReader["CityName"].ToString()
                        });
                    }
                }
            }
        }



        public void FillId(int id,ComboBox comboBox)
        {
            models.Clear();
            using (sqlCommand = new SqlCommand($"SELECT * FROM CarsModel WHERE MarkaId = {id}", sqlConnection))
            {
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        models.Add(new CarsModel
                        {
                            Id = Convert.ToInt32(dataReader["ModelId"]),
                            Model = dataReader["Model"].ToString(),
                            MarkaId = Convert.ToInt32(dataReader["MarkaId"])
                        });
                    }
                }
            }
            comboBox.DataSource = new BindingSource(models, null);
            comboBox.DisplayMember = "Model";
        }




    }
}
