using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace IWayCsTraining
{
    class Serialization
    {
        public static void BinarySerialization(Car obj, string filePathWithName)
        {
            //Car car1 = new Car("Blue", "Honda City", 320, 4);
            Console.WriteLine("Details of Car1:");
            obj.PrintDetails();

            //Object --> Binary File Stream --> Object

            //Serialization
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(filePathWithName, FileMode.Create, FileAccess.Write);

            formatter.Serialize(fs, obj);
            fs.Close();

        }

        public static Car BinaryDeserialization(string filePathWithName)
        {
            Console.WriteLine("\n\n\n");
            //De-serialize
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fsRead = new FileStream(filePathWithName, FileMode.Open, FileAccess.Read);
            Car car2 = (Car)formatter.Deserialize(fsRead);
            //car2.PrintDetails();
            return car2;
        }

        public static Car XmlSerializationDeserialization()
        {
            Car car1 = new Car("Red", "Honda City", 320, 4);
            Console.WriteLine("Details of Car1:");
            car1.PrintDetails();

            //Object --> XML File Stream --> Object

            //Serialization
            XmlSerializer xs = new XmlSerializer(car1.GetType());
            FileStream fs = new FileStream(@"D:\TrainingFiles\xmlFile.xml", FileMode.Create, FileAccess.Write);
            xs.Serialize(fs, car1);
            fs.Close();

            //Deserialization
            FileStream fsRead = new FileStream(@"D:\TrainingFiles\xmlFile.xml", FileMode.Open, FileAccess.Read);
            Car car2 = (Car)xs.Deserialize(fsRead);
            car2.PrintDetails();
            return car2;
        }

        public static void JsonSerializationDeserialization()
        {
            Car car1 = new Car("Red", "Honda City", 320, 4);
            Console.WriteLine("Details of Car1:");
            car1.PrintDetails();

            //Object --> XML File Stream --> Object

            //Serialization
            string jsonString = JsonSerializer.Serialize(car1);
            Console.WriteLine("Json String: \n" + jsonString);

            //Deserialization
            Car car2 = JsonSerializer.Deserialize<Car>(jsonString);

            Console.WriteLine("\n\nDeserialized objects values: \n");
            car2.PrintDetails();
            
        }

    }
}
