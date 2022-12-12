namespace Event_Management_System.Models;

public class User
{
    public User(int id, 
            string name,
            string surname,
            string login, 
            string password,
            int role)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Login = login;
        Password = password;
        Role = role;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public int Role { get; set; }


}
