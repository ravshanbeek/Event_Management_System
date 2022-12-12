using Event_Management_System.Brokers;
using Event_Management_System.Models;

class Program
{
   static async  Task  Main(string[] args)
    {
        User user = new User(1, "Ravshan","Axadov","Admin","Admin",3);

        IStorageBroker storedBrokers = new StorageBroker();
        storedBrokers.InsertUser(user).Wait();
        Console.ReadLine(); 
    }
}