using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWayCsTraining
{
    class GenClass<Type1, Type2>
    {
        public Type1 prop1 { get; set; }

        public Type2 prop2 { get; set; }

        public void PrintMessage(Type1 param1, Type2 param2)
        {
            Console.WriteLine($"The values are: {param1} & {param2}");
        }


    }
}
