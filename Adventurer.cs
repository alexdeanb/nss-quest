namespace Quest
{
    public class Adventurer
    {

        public string Name { get; }

        public int Awesomeness { get; set; }
        public Robe ColorfulRobe { get; }
        public Hat ShinyHat { get; }
        public Adventurer(string name, Robe colorfulRobe, Hat hat, int awesomeness)
        {
            Name = name;
            Awesomeness = awesomeness;
            ColorfulRobe = colorfulRobe;
            ShinyHat = hat;
        }

        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }

        public string GetDescription()
        {
            string colors = "";
            ColorfulRobe.Colors.ForEach(delegate (string color)
            {
                colors += $"{color} ";
            });


            return $"Adventurer {Name} is wearing a {ColorfulRobe.Length}in long robe with {colors} with a {ShinyHat.ShininessDescription} hat!";
        }
    }
}