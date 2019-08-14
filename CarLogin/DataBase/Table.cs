using CarLogin.CarRegister;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin.DataBase
{
  public class Table<T> : IEnumerable
    {
        public List<T> data;

        public Table()
        {
            data = new List<T>();
        }

        public void Add(T obj)
        {
            data.Add(obj);
        }

        public List<T> GetAllData()
        {
            return data;
        }

        public IEnumerator GetEnumerator()
        {
           return data.GetEnumerator();
        }
    }
}
