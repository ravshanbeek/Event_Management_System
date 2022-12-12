using Event_Management_System.Models;

namespace Event_Management_System.Brokers;

public interface IStorageBroker
{
    public Task<User> InsertUser(User user);
    public Task RegisterToEvent(OrdersForUsers order);
    public Task<List<Orders>> GetAllEevents();

}