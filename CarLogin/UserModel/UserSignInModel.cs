using CarLogin.ValidatorAttr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin.UserModel
{
  public  class UserSignInModel
    {
        [ValidatorEmail]
        public string Email { get; set; }
        [ValidatorPassword]
        public string Password { get; set; }
    }
}
