namespace Event_Management_System.Models;

public class Orders
{
    public Orders(int id,
        int companyId,
        string eventName, 
        int roomId, 
        DateTime beginAt, 
        DateTime endAt)
    {
        Id = id;
        CompanyId = companyId;
        EventName = eventName;
        RoomId = roomId;
        BeginAt = beginAt;
        EndAt = endAt;
    }

    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string EventName { get; set;}
    public int RoomId { get; set; }
    public DateTime BeginAt { get; set; }
    public DateTime EndAt { get; set; }
}
