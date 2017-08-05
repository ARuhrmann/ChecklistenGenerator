namespace ChecklistenGenerator_Logik
{
    public class Warenwirtschaft
    {
        private static byte counter = 0;

        public Warenwirtschaft()
        {
            counter++;
            Name = "Keine Warenwirtschaft " + counter;
        }

        public string Name { get; set; }
    }
}