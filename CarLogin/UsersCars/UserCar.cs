using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin.UsersCars
{
  public  class UserCar
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string City { get; set; }
        public string Prize { get; set; }
        public string Year { get; set; }
        public string Desicription { get; set; }
        public string Photo { get; set; }
        public string Currency { get; set; }
        public int UserId { get; set; }
    }

}
