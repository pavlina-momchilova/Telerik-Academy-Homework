namespace RefactorAndImproveTheCode
{
    public class Players
    {
        private string name;
        private int score;

        public Players(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
    }
}
