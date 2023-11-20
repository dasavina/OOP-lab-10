namespace _03BarracksFactory.Contracts
{
    public interface IRunnable
    {
        void Run() {
            string command = Console.ReadLine();
            while (!command.Equals("fight"))
            {
                string[] parameters = command.Split(' ');
                switch (parameters[0])
                {
                    case "add":
                        {


                            Console.WriteLine("added");
                        }
                        break;
                    case "report":
                        {

                        }
                        break;
                    default:
                        {
                            Console.WriteLine("no such command");
                        }
                        break;

                }
            }
        }
    }
}
