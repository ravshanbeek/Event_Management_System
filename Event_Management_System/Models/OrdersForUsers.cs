namespace Event_Management_System.Models;

public class OrdersForUsers
{
    public OrdersForUsers(int id, int eventId, int userId, int sitting)
    {
        Id = id;
        EventId = eventId;
        UserId = userId;
        Sitting = sitting;
    }

    public int Id { get; set; }
    public int EventId { get; set; }
    public int UserId { get; set; }
    public int Sitting { get; set; }
}
