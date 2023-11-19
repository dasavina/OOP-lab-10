namespace P01_HarvestingFields
{
    using System;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            Type type = typeof(HarvestingFields);
            string command = Console.ReadLine();
            while (!command.Equals("harvest"))
            {
                switch (command)
                {
                    case "public":
                        {
                            foreach (FieldInfo field in type.GetFields())
                            {
                                if (field.IsPublic)
                                {
                                    Console.WriteLine("public " + field.Name);
                                }
                            }
                        }
                        break;
                    case "protected":
                        {
                            foreach (FieldInfo field in type.GetFields())
                            {
                                if (field.IsFamily)
                                {
                                    Console.WriteLine("protected " + field.Name);
                                }
                            }
                        }
                        break;
                    case "private":
                        {
                            foreach (FieldInfo field in type.GetFields())
                            {
                                if (field.IsPrivate)
                                {
                                    Console.WriteLine("private " + field.Name);
                                }
                            }
                        }
                        break;
                    case "all":
                        {
                            foreach (FieldInfo field in type.GetFields())
                            {
                                Console.WriteLine("public " + field.Name);
                            }
                        }
                        break;
                    default: { Console.WriteLine("no such command"); } break;
                }
           
                command = Console.ReadLine();
            }
        }
    }
}
