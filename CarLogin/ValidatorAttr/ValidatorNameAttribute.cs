﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =true,Inherited =true)]
  public  class ValidatorNameAttribute : Attribute
    {
    }
}
