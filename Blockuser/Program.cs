namespace Blockuser;

class Program
{
    static void Main()
    {
        User[] users = {
            new User("Stea_lamid", "Jack", true),
            new User("chocolatecake5k", "Ray", true),
            new User("ForkFreak", "Fine", false)};
        foreach (User user in users) { Greeting.GreetUser(user); }
        
        Console.ReadKey();
    }
}