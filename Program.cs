using panzer_division.Model;

namespace panzer_division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Soldier soldierOne = new("Hans");
            Console.WriteLine(soldierOne);
            Tanker soldierTwo = new("Bruno");
            Console.WriteLine(soldierTwo);
            Tank tankOne = new();
            Tank tankTwo = new();
            Console.WriteLine(tankOne);
            tankOne.AddSoldier(soldierTwo);
            Console.WriteLine(tankOne);
            tankOne.AddSoldier(soldierOne);
            PanzerDivision divisionOne = new("Das Reich");
            divisionOne.AddTank(tankOne);
            divisionOne.AddTank(tankTwo);
            Console.WriteLine(divisionOne);
            Console.WriteLine(soldierTwo.GetType());
        }
    }
}