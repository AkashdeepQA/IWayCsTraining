using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWayCsTraining
{
    [Serializable]
    public class Vehicle
    {
        protected string manufacturer;
        protected string model;
        protected string color;

        public Vehicle() { }
        public Vehicle(string manufacturer1, string model1, string color1)
        {
            manufacturer = manufacturer1;
            model = model1;
            color = color1;
        }

        public virtual void Start()
        {
            Console.WriteLine($"{manufacturer} {model} has started");
        }

        public void Stop()
        {
            Console.WriteLine("The vehicle has stopped");
        }
    }

    [Serializable]
    public class Car1 : Vehicle
    {
        public Car1() { }
        public Car1(string manufacturer1, string model1, string color1, int doors, string transmission1) : base(manufacturer1, model1, color1)
        {
            numberOfdoors = doors;
            transmission = transmission1;
        }
        int numberOfdoors;
        string transmission;

        public void VideoRecording()
        {
            //Console.WriteLine(manufacturer);
            Console.WriteLine("Video recording is on");
        }

        public override void Start()
        {
            Console.WriteLine("This is child class Start() function");
            Console.WriteLine("The Car has started... Vrooomm vrooomm.....");
        }

        
    }
}
