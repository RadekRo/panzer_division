namespace panzer_division.Model
{
    public class Soldier
    {
        public string? Name { get; set; }

        public Soldier(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Mein name ist {Name}. Ich bin ein deutscher Soldat. Heil Hitler!"; 
        }

    }
}
