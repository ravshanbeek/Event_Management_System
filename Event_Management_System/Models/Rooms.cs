namespace Event_Management_System.Models;

public class Rooms
{
    public Rooms(int id, int number, int capacity)
    {
        Id = id;
        Number = number;
        Capacity = capacity;
    }

    public int Id { get; set; }
    public int Number { get; set; }
    public int Capacity { get; set; }
}
