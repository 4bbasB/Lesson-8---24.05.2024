namespace Lesson_8___24._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.Write("Adinizi daxil edin: ");
            user.Name = Console.ReadLine();

            Console.Write("Passwordu daxil edin: ");
            user.Password = Console.ReadLine();

            Console.WriteLine(user.Name);
            Console.WriteLine(user.Password);
        }
    }
}