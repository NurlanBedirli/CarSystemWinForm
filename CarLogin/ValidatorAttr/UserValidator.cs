using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin.ValidatorAttr
{

   public class UserValidator
    {
        private Dictionary<int, string> errors;

       public UserValidator()
        {
            errors = new Dictionary<int, string>();
        }

        public bool Valid<T>(T type)
        {
             bool isvalid = false;
            PropertyInfo[] propertyinfos = type.GetType().GetProperties();
         foreach(PropertyInfo property in propertyinfos)
            {
                var attributes = property.GetCustomAttributes();
             foreach(Attribute attribute in attributes)
                {
                    if(attribute is ValidatorNameAttribute)
                    {
                        if(property.GetValue(type) is string value)
                        {
                           if(String.IsNullOrEmpty(value))
                            {
                                errors.Add(1, "Name Hissesi Bosdur");
                                isvalid = true;
                            }
                        }
                    }
                    if(attribute is ValidatorSurnameAttribute)
                    {
                        if(property.GetValue(type) is string value)
                        {
                            if(String.IsNullOrEmpty(value))
                            {
                                errors.Add(2, "Surname Hissesi Bosdur");
                                isvalid = true;
                            }
                        }
                    }
                    if (attribute is ValidatorEmailAttribute)
                    {
                        if (property.GetValue(type) is string value)
                        {
                            if (String.IsNullOrEmpty(value))
                            {
                                errors.Add(3, "Email Hissesi Bosdur");
                                isvalid = true;
                            }
                            else
                            {
                                if (!value.Contains("@"))
                                {
                                    errors.Add(3, "Email Hissesinde @ Isaresi yoxdur");
                                    isvalid = true;
                                }
                            }
                        }
                    }
                    if (attribute is ValidatorPasswordAttribute)
                    {
                        if (property.GetValue(type) is string value)
                        {
                            if (String.IsNullOrEmpty(value))
                            {
                                errors.Add(4, "Password Hissesi Bosdur");
                                isvalid = true;
                            }
                            else
                            {
                                int number = value.Length;
                                if (number < 6)
                                {
                                    errors.Add(4, "Password 6 dan Kicikdir");
                                    isvalid = true;
                                }
                            }
                        }
                    }

                }
            }
            return isvalid;
        }

        public Dictionary<int,string> GetAllData()
        {
            return errors;
        }
    }

}
