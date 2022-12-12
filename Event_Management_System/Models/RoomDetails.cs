namespace Event_Management_System.Models;

public class RoomDetails
{
    public RoomDetails(int id,
            int roomId,
            int bookedSittings,
            int capacity, 
            int eventId,
            DateTime beginAt, 
            DateTime endAt)
    {
        Id = id;
        RoomId = roomId;
        BookedSittings = bookedSittings;
        Capacity = capacity;
        EventId = eventId;
        BeginAt = beginAt;
        EndAt = endAt;
    }

    public int Id { get; set; }
    public int RoomId { get; set; }
    public int BookedSittings { get; set; }
    public int Capacity { get; set; }
    public int EventId { get; set; }
    public DateTime BeginAt { get; set; }
    public DateTime EndAt { get; set; }
}
