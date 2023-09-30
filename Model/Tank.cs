namespace panzer_division.Model
{
    public class Tank : Vehicle
    {
        public int FirePower;
        private List<Soldier> _Team;
        public Tank()
        {
            Speed = 60;
            FirePower = 100;
            _Team = new List<Soldier>();
        }

        public void AddSoldier (Soldier soldier)
        {
            if (_Team.Count < 4) 
            {
                _Team.Add(soldier);
            }
            else
            {
                Console.WriteLine("Der Tank ist bereits voll, General!");
            }
        }
        public override string ToString()
        {
            return $"Tankservice: {_Team.Count}/4";


        }
    }
}
