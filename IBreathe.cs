using System.Linq;

namespace TestProject1
{
    /// <summary>
    /// Это мой интерфейсо
    /// </summary>
    public interface IBreath
    {
       
        string Name { get; }
        
        void Done();
        void Cycle(int BreathInADay);
       
    }
}
