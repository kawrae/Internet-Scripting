namespace FilmDetails
{
    public class Film
    {
        public int FilmID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public Int32 ActorID { get; set; }
    }

    public class Actor
    {
        public Int32 ActorID { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
    }
}
