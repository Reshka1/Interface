using System;

namespace TestProject1
{
    class BasePerson : IBreath
    {
        public string Name
        {
            get => "John";
        }

        public void Cycle(int BreathInADay)
        {
            for (int i = 0; i < 23040; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Done()
        {
            throw new NotImplementedException();
        }
    }
}

