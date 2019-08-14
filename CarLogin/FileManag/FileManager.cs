using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLogin.FileManag
{
  public  class FileManager
    {
        public byte[] ReadFromFile(string file)
        {
            byte[] array = null;
            using (FileStream stream = File.Open(file,FileMode.Open))
            {
                array = new byte[stream.Length];
                stream.Read(array, 0, array.Length);
            }
            return array;
        }
    }
}
