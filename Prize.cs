namespace Quest
{

    public class Prize
    {
        private string _text { get; }

        public Prize(string secret)
        {
            _text = secret;
        }

        public void ShowPrize(Adventurer theAdventurer)
        {
            if (theAdventurer.Awesomeness > 0)
            {
                for (int i = 0; i < theAdventurer.Awesomeness; i++)
                {
                    if (i == 0) { System.Console.WriteLine("You win:"); }
                    System.Console.WriteLine(this._text);
                }
            }
        }
    }
}