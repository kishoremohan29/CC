namespace CC6
{
    public class Movie
    {
        private static int s_Id = 0;
        public int Id { get; }
        public string Title { get; set; }
        public string Cast { get; set; }
        public double TicketPrice { get; set; }

        public Movie(string title, string cast, double ticketPrice)
        {
            s_Id++;
            Id = s_Id;
            Title = title;
            Cast = cast;
            TicketPrice = ticketPrice;
        }
    }
}