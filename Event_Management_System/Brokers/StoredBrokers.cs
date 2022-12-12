using Event_Management_System.Brokers.Helper;
using Event_Management_System.Models;
using System.Data;
using System.Data.SqlClient;

namespace Event_Management_System.Brokers;

    public partial class StorageBroker : IStorageBroker
    {
    public async Task<List<Orders>> GetAllEevents()
    {
        using var connection = GetConnection();
        using var command = connection.CreateCommand();

        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = StorageBrokerHelper.GetAllEvents;

        await connection.OpenAsync();
        List<Orders> orders = new List<Orders>();

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                orders.Add(orders.FirstOrDefault());
            }
        }

        return orders;
    }

    public SqlConnection GetConnection()
        {
            string connectionString = @"Server=(localdb)\mssqllocaldb; Database=Events";

            return new SqlConnection(connectionString);
        }

        public async Task<User> InsertUser(User user)
        {
            using var connection = GetConnection();
            using var command = connection.CreateCommand();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = StorageBrokerHelper.InsertToUsers;

            command.Parameters.Add(new SqlParameter("@name", user.Name));
            command.Parameters.Add(new SqlParameter("@surname", user.Surname));
            command.Parameters.Add(new SqlParameter("@login", user.Login));
            command.Parameters.Add(new SqlParameter("@password", user.Password));
            command.Parameters.Add(new SqlParameter("@role", user.Role));
            
            await connection.OpenAsync();

            command.ExecuteNonQuery();

            return user;
        }

        public async Task RegisterToEvent(OrdersForUsers order)
        {
            using var connection = GetConnection();
            using var command = connection.CreateCommand();

            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = StorageBrokerHelper.InsertUserToEvent;

            command.Parameters.Add(new SqlParameter("@id", order.Id));
            command.Parameters.Add(new SqlParameter("@eventId", order.EventId));
            command.Parameters.Add(new SqlParameter("@userId",order.UserId));
            command.Parameters.Add(new SqlParameter("@sitting", order.Sitting));

            await connection.OpenAsync();

            command.ExecuteNonQuery();
    }
    }

