using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review4
{
    internal class JSONDataReader
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public void ParseAndReadData()
        {
            string path = @"E:\BL\Training\C#\ReviewsCode\Review4\JSONData.json";

            if (File.Exists(path))
            {
                string data = File.ReadAllText(path);
                JSONDataReader dataReader = JsonConvert.DeserializeObject<JSONDataReader>(data);

                Console.WriteLine($"Name: {dataReader.Name}");
                Console.WriteLine($"Email: {dataReader.Email}");
                Console.WriteLine($"Age: {dataReader.Age}");

            }

            else
            {
                Console.WriteLine("File not found !!!! ");
            }

        }
    }
}
