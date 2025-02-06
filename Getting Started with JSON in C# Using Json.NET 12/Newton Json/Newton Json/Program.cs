using System.Dynamic;
using Newton_Json.Serialization_Fundamentals;
using Newtonsoft.Json;

namespace Newton_Json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JsonFileReader fileReader = new JsonFileReader();

            #region Mapping JSON to and from .NET with JsonConvert
            //var json = fileReader.getJson();

            //Console.WriteLine(json);
            //Console.WriteLine("####################");
            //var person = JsonConvert.DeserializeObject<Person>(json);
            //Console.WriteLine(person);

            //var backToJson = JsonConvert.SerializeObject(json, Formatting.Indented);
            //Console.WriteLine(backToJson);
            #endregion

            #region Preserving Object References
            //Person mike = new Person()
            //{
            //    name = "mike",
            //    age = 1,
            //};

            //Person jack = new Person()
            //{
            //    name = "jack",
            //    age = 1,
            //};

            //Person george = new Person()
            //{
            //    name = "george",
            //    age = 1,
            //};

            //george.favouritePersons = new List<Person>{ mike, jack, george };




            //Console.WriteLine(JsonConvert.SerializeObject(george,new JsonSerializerSettings()
            //{
            //    Formatting = Formatting.Indented,
            //    PreserveReferencesHandling = PreserveReferencesHandling.Objects
            //}));

            #endregion

            #region Using System.Dynamic with JsonConvert
            //dynamic obj = new ExpandoObject();
            //obj.name = "George";
            //obj.Age = 123;


            //Console.WriteLine(JsonConvert.SerializeObject(obj,Formatting.Indented));
            #endregion





        }
    }
}
