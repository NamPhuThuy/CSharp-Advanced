using System;

namespace WorkingWithDelegates
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            Delegates.Calculate cal = null;
            ConsoleKeyInfo userX, userZ;
            float x;
            float z;

            cal += Delegates.Add;
            cal += Delegates.Sustract;
            cal += Delegates.Multiply;
            cal += Delegates.Divide;

            Console.WriteLine("Integer calculator"); CarriageReturn();
            Console.WriteLine("Press \"e\" to exit"); CarriageReturn();

            do
            {
                Console.Write("x: ");
                userX = Console.ReadKey();

                EvaluateCloseApp(userX);

                Console.Write(" y: ");
                userZ = Console.ReadKey();

                EvaluateCloseApp(userZ);

                float.TryParse(userX.KeyChar.ToString(), out x);
                float.TryParse(userZ.KeyChar.ToString(), out z);

                CarriageReturnNewLine();

                foreach (Delegate del in cal.GetInvocationList())
                {
                    try
                    {
                        Console.WriteLine(String.Format("{0}: {1}", del.Method.Name.ToString(), del.DynamicInvoke(x, z).ToString()));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.InnerException.Message);
                    }
                }

                CarriageReturnNewLine();

            } while (!userX.KeyChar.ToString().Equals("E") && !userX.KeyChar.ToString().Equals("e"));

        }

        public static void Clear ()
        {
            Console.Clear();
        }
        public static void CarriageReturn ()
        {
            Console.WriteLine("\r");
        }
        public static void CarriageReturnNewLine ()
        {
            Console.WriteLine("\r\n");
        }
        public static void EvaluateCloseApp (ConsoleKeyInfo key)
        {
            string character = key.KeyChar.ToString();

            if (character.Equals("e") || character.Equals("E"))
            {
                CarriageReturnNewLine();
                Console.WriteLine("Application will be close...");
                Environment.Exit(0);
            }
        }
    }
}