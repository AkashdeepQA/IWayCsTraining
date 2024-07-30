using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWayCsTraining
{
    [Serializable]
    public class Car
    {
        //parameter-less contructor
        public Car()
        {

        }

        //parameterized constructor
        public Car(string clr, string mdl, int tpSpd, int numDoors)
        {
            Color = clr;
            Model = mdl;
            TopSpeed = tpSpd;
            NumberOfDoors = numDoors;
        }

        //Fields
        public string Color { get; set; }
        public string Model { get; set; }
        public int TopSpeed { get; set; }
        public int NumberOfDoors { get; set; }

        //Methods
        public void Start()
        {
            Console.WriteLine("Car has started");
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped");
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Color: {Color}\nModel: {Model}\nTop Speed: {TopSpeed}\nNumber of Doors: {NumberOfDoors}");
        }
    }
}
