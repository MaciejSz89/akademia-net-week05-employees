using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Employees
{
    public class Serializer<T> : ISerializer<T>
    {
        private readonly string _filePath;
        public Serializer(string filePath)
        {
            _filePath = filePath;
        }
        public void Serialize(T item)
        {
            using (FileStream fs = new FileStream(_filePath, FileMode.Create, FileAccess.Write))
            {
                TextWriter tw = new StreamWriter(fs);
                string jsonString = JsonConvert.SerializeObject(item);
                tw.Write(jsonString);
                tw.Close();
            }
        }

        public T Deserialize()
        {
            throw new NotImplementedException();
            //T item;
            //using (FileStream fs = new FileStream(_filePath, FileMode.OpenOrCreate, FileAccess.Read))
            //{                
            //    TextReader tr = new StreamReader(fs);
            //    fs.Close();
            //}
            //return item;
        }
    }
}
