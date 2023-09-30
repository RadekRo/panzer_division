using System.Runtime.CompilerServices;

namespace panzer_division.Model
{
    public class Tanker : Soldier
    {
        public Tanker(string name) : base(name)
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + " Ich bin ein Tanker!";
        }
    }
}
