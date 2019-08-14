using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin.CarModel
{
  public  class CarList<T>
    {
        private List<T> data;

        public CarList()
        {
            data = new List<T>();
        }

        public void Add(T str)
        {
            data.Add(str);
        }

        public List<T> GettAllData()
        {
            return data;
        }
    }
}
