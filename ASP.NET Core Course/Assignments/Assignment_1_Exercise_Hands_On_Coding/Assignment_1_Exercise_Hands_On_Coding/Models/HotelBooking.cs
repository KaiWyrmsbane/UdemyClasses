namespace Assignment_1_Exercise_Hands_On_Coding.Models
{
    public class HotelBooking
    {
        public int id { get; set; }
        public string ?guestName { get; set; }
        public DateTime dateStart { get; set; }
        public DateTime dateEnd { get; set; }
    }
}
