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

                        }
                        break;
                    case "report":
                        {

                        }
                        break;
                    default:
                        {

                        }
                        break;

                }
            }
        }
    }
}
