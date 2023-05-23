namespace Quest
{
    public class Hat
    {
        public int ShininessLevel { get; set; }
        public string ShininessDescription { get; set; }

        public Hat(int shiny)
        {
            string description = "";
            if (shiny < 2)
            {
                description = "Dull";
            }
            else if (shiny >= 2 || shiny <= 5)
            {
                description = "Noticable";
            }
            else if (shiny >= 6 || shiny <= 9)
            {
                description = "Bright";
            }
            else if (shiny > 9)
            {
                description = "Blinding";
            }

            this.ShininessDescription = description;
        }
    }
}