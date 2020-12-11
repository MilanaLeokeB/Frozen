namespace Frozen
{
    internal class Character
    {
        private int id;
        private string title;
        private long gross;

        public Character(int id, string title, long gross)
        {
            this.id = id;
            this.title = title;
            this.gross = gross;
        }

        public static object Id { get; internal set; }
        public static object Title { get; internal set; }
        public static object LifeTimeGross { get; internal set; }
    }
}