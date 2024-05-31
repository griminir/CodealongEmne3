namespace CodealongEmne3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserCommands.Dyreliste.Add(UserCommands.ChoiceMenu());
            UserCommands.ShowAnimal(UserCommands.Dyreliste);
            Console.ReadLine();
        }
    }
}
