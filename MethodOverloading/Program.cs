namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {

            #region Int Add
            Add(12, 6);
            #endregion
            
            #region Double Add

            Add(12.3, 74.9);

            #endregion

            #region Dollar Add

            bool validInput;

            Console.WriteLine("Please enter the first number you want to add in dollars:");
            bool validNum1 = int.TryParse(Console.ReadLine(), out int dollarInput1);

            Console.WriteLine("");
            Console.WriteLine("Please enter the second number you want to add in dollars:");
            bool validNum2 = int.TryParse(Console.ReadLine(), out int dollarInput2);

            if (validNum1 == true & validNum2 == true)
            {
                validInput = true;
            }
            else
            {
                validInput = false;
            }

            Console.WriteLine(Add(dollarInput1, dollarInput2, validInput));

            #endregion
        }

        #region Methods
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static string Add(int num1, int num2, bool myBool)
        {


            while (!myBool)
            {
                Console.WriteLine("Please input a valid number for both numbers.");
                Console.WriteLine("");

                Console.WriteLine("Please enter the first number you want to add in dollars:");
                bool valuecheck1 = int.TryParse(Console.ReadLine(), out num1);

                Console.WriteLine("");
                Console.WriteLine("Please enter the second number you want to add in dollars:");
                bool valuecheck2 = int.TryParse(Console.ReadLine(), out num2);

                if (valuecheck1 == true & valuecheck2 == true)
                {
                    myBool = true;
                    int total = num1 + num2;

                    if (total == 1)
                    {
                        return $"You have a total of {total} dollar.";
                    }
                    else if (total == 0)
                    {
                        return $"You have no money.";
                    }
                    else if (total == -1)
                    {
                        total = Math.Abs(total);
                        return $"You owe {total} dollar.";
                    }
                    else if (total < 0)
                    {
                        total = Math.Abs(total);
                        return $"You owe {total} dollars.";
                    }

                }
                
            }

            int totalAmount = num1 + num2;

            if (totalAmount == 1)
            {
                return $"You have a total of {totalAmount} dollar.";
            }
            else if (totalAmount == 0)
            {
                return $"You have no money.";
            }
            else if (totalAmount == -1)
            {
                totalAmount = Math.Abs(totalAmount);
                return $"You owe {totalAmount} dollar.";
            }
            else if (totalAmount < 0)
            {
                totalAmount = Math.Abs(totalAmount);
                return $"You owe {totalAmount} dollars.";
            }
            else
            {
                return $"You have a total of {totalAmount} dollars.";
            }
        }
        #endregion

    }
}
