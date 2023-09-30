using System.Text;

namespace panzer_division.Model
{
    public class PanzerDivision
    {
        public string Name;
 
        private List<Tank> Tanks;
        public PanzerDivision(string name)
        {   
            Name = name;
            Tanks = new List<Tank>();
        }

        public void AddTank(Tank tank)
        {
            Tanks.Add(tank);
        }

        public override string ToString() 
        {
           StringBuilder sb = new StringBuilder();
           sb.AppendLine($"Der Zustand der Panzerdivision: {Name}");
           sb.AppendLine($"----------------------------------------");
           sb.AppendLine($"Der Zurstand der Tanks:");
           sb.AppendLine($"-----------------------");

           foreach (Tank tank in Tanks)
            {
                sb.AppendLine(tank.ToString()); 
            }
           return sb.ToString();    
        }

    }
}
