using class_task.folder;

namespace class_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
        


            User user = new User
            {
                UserName = "Ali",
                Pasword ="hhRT6778",

            };
            Console.WriteLine("UserName: "+user.UserName);
            Console.WriteLine("Pasword: "+user.Pasword);
           
        }
    }
}