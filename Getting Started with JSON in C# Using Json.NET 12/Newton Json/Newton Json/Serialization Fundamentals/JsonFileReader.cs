using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton_Json.Serialization_Fundamentals
{
    public class JsonFileReader
    {
        public  string getJson()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "text.json");
            return  File.ReadAllText(filePath);

        }
    }
}
