using CarLogin.ValidatorAttr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin.CarRegister
{
   public class Users
    {
        public int Id { get; set; }
        [ValidatorName]
        public string Name { get; set; }
        [ValidatorSurname]
        public string Surname { get; set; }
        [ValidatorEmail]
        public string Email { get; set; }
        [ValidatorPassword]
        public string Password { get; set; }
    }
}
