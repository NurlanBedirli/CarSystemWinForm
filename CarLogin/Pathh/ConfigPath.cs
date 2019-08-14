using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin.ImagePath
{
   public  class Pathh
    {
        public string FullPath(string photo)
        {
            string configPath = ConfigurationManager.AppSettings["Path"].ToString();
            string fullPath = Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\", configPath, photo));
            return fullPath;
        }

        public byte[] ReadFileByte(string file)
        {
            byte[] array = null;
            using (FileStream stream = File.Open(file, FileMode.Open))
            {
                array = new byte[stream.Length];
                stream.Read(array, 0, array.Length);
            }
            return array;
        }
    }
}
