namespace Blockuser;

public static class Greeting
{
    public static void GreetUser(User user)
    {
        Console.WriteLine($"{user.Login} logged in.");
        Console.WriteLine($"Greetings, {user.Name}");
        if (user.IsPremium) { Console.WriteLine("Have a good day!"); }
        else { Ads.ShowAds(); }
        Console.WriteLine();
    }
}
