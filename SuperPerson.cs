using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    class SuperPerson : IBreath, ISpeedBreath
    {
        public string Name
        {
            get => "JoSuper";
        }
        public int BreathInADay
        {
            get => 15070;
        }
        public void Cycle(int BreathInADay)
        {
            string collection = "He is breathing";
            foreach (int BreathInDay in collection)
            {
                Console.WriteLine(BreathInDay.ToString() + "");
            }
        }

        void IBreath.Done()
        {
            Console.WriteLine();
        }

        void ISpeedBreath.Done(int count)
        {

        }
    }
}
