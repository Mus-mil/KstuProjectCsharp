namespace KstuProjectCsharp
{
    internal static class Program02
    {
        public static void GetUserInfo(string[] args)
        {
            string name;
            string surname;
            int age;
            name = Console.ReadLine();
            surname = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("your name and surname "+name+surname+"\n"+"your age: "+age);
        }
    }
}