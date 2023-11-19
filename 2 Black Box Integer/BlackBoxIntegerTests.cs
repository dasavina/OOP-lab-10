namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Type type = typeof(BlackBoxInteger);
            ConstructorInfo constructor = type.GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, null, new Type[0], null);
            BlackBoxInteger box = (BlackBoxInteger)constructor.Invoke(new object[] { 0 });
            FieldInfo field = type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);
            while (!command.Equals("end"))
            {
                string[] parameters = command.Split('_');
                switch (parameters[0])
                {
                    case "Add":
                        {
                            MethodInfo addInfo = type.GetMethod("Add", BindingFlags.NonPublic | BindingFlags.Instance);
                            addInfo.Invoke(box, new object[] { Convert.ToInt32(parameters[1]) });
                            Console.WriteLine((int)field.GetValue(box));
                        }
                        break;
                    case "multiply":
                        {
                            MethodInfo multiplyInfo = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

                        }
                        break;
                    case "divide":
                        {
                            MethodInfo addInfo = type.GetMethod("Divide", BindingFlags.NonPublic | BindingFlags.Instance);
                            addInfo.Invoke(box, new object[] { Convert.ToInt32(parameters[1]) });
                            Console.WriteLine((int)field.GetValue(box));
                        }
                        break;
                    case "substract":
                        {
                            MethodInfo addInfo = type.GetMethod("Substract", BindingFlags.NonPublic | BindingFlags.Instance);
                            addInfo.Invoke(box, new object[] { Convert.ToInt32(parameters[1]) });
                            Console.WriteLine((int)field.GetValue(box));
                        }
                        break;
                    case "leftShift":
                        {
                            MethodInfo addInfo = type.GetMethod("LeftShift", BindingFlags.NonPublic | BindingFlags.Instance);
                            addInfo.Invoke(box, new object[] { Convert.ToInt32(parameters[1]) });
                            Console.WriteLine((int)field.GetValue(box));
                        }
                        break;
                    case "rightShift":
                        {
                            MethodInfo addInfo = type.GetMethod("RightShift", BindingFlags.NonPublic | BindingFlags.Instance);
                            addInfo.Invoke(box, new object[] { Convert.ToInt32(parameters[1]) });
                            Console.WriteLine((int)field.GetValue(box));
                        }
                        break;
                    default: { Console.WriteLine("no such command"); } break;
                }

                command = Console.ReadLine();
            }

        }
    }
}
