using CarLogin.CarRegister;
using CarLogin.SearchModel;
using CarLogin.UsersCars;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin.DataBase
{
   public  class DbContext : IEnumerable
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        public Table<Users> userData;
        public Table<UserCar> usCars;
        public Table<SearchCar> carsSearch;

        public DbContext(string ConfigName)
        {
            sqlConnection = new SqlConnection(ConfigConnection(ConfigName));
            sqlConnection.Open();
            userData = new Table<Users>();
            usCars = new Table<UserCar>();
            carsSearch = new Table<SearchCar>();
        }

        public string ConfigConnection(string ConfigName)
        {
            string connectionConfig = ConfigurationManager.ConnectionStrings[ConfigName].ConnectionString;
            return connectionConfig;
        }

        public void InsertCommand(Type tableName, string text, string text1, string text2, string text3)
        {
            using (sqlCommand = new SqlCommand($"Insert Into {tableName.Name} (Name,Surname,Email,Password) Values ('{text}','{text1}','{text2}','{text3}')",sqlConnection))
            {
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    dataReader.Close();
                }
            }
        }

        public void InsertCommandUserCars(Type tableName, string text, string text1, string text2, string text3,string text4,string text5,string text6,int text7,string text8)
        {
            using (sqlCommand = new SqlCommand($"Insert Into {tableName.Name} (Model,Marka,City,Year,Desicription,Prize,Photo,UserId,Currency) Values ('{text}','{text1}','{text2}','{text3}','{text4}','{text5}','{text6}',{text7},'{text8}')", sqlConnection))
            {
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    dataReader.Close();
                }
            }
        }

        public void GetAllUserCars(Type tableName)
        {
            using (sqlCommand = new SqlCommand($"Select *From {tableName.Name}", sqlConnection))
            {
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        usCars.Add(new UserCar
                        {
                            Id = Convert.ToInt32(dataReader["Id"]),
                            Model = dataReader["Model"].ToString(),
                            Marka = dataReader["Marka"].ToString(),
                            City = dataReader["City"].ToString(),
                            Year = dataReader["Year"].ToString(),
                            Desicription = dataReader["Desicription"].ToString(),
                            Prize = dataReader["Prize"].ToString(),
                            Photo = dataReader["Photo"].ToString(),
                            UserId = Convert.ToInt32(dataReader["UserId"]),
                            Currency = dataReader["Currency"].ToString()
                        });
                    }
                }
            }
        }


        public void SearchCar(string text1,string text2,string text3,string text4)
        {
            string query = $"Select City,Model,Marka,Year,Prize,Photo,Currency From UserCar Where City like '%{text1}%' and Model like '%{text2}%' and Marka like '%{text3}%' and Year like '%{text4}%'";
            using (SqlCommand sqlCommand = new SqlCommand(query, sqlConnection))
            {
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        carsSearch.Add(new SearchCar
                        {
                            City = reader["City"].ToString(),
                            Model = reader["Model"].ToString(),
                            Marka = reader["Marka"].ToString(),
                            Year = reader["Year"].ToString(),
                            Prize = reader["Prize"].ToString(),
                            Photo = reader["Photo"].ToString(),
                            Currency = reader["Currency"].ToString()
                        });
                    }
                }
            }
        }

        public Table<SearchCar> AllCars()
        {
            return carsSearch;
        }

        public void GetAllData(Type tableName)
        {
            using (sqlCommand = new SqlCommand($"Select *From {tableName.Name}", sqlConnection))
            {
                using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                {
                    while(dataReader.Read())
                    {
                        userData.Add(new Users
                        {
                            Id = Convert.ToInt32(dataReader["UserId"]),
                            Name = dataReader["Name"].ToString(),
                            Surname = dataReader["Surname"].ToString(),
                            Email = dataReader["Email"].ToString(),
                            Password = dataReader["Password"].ToString()
                        });
                    }
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
           return usCars.GetEnumerator();
        }
    }
}
