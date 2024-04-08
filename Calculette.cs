namespace Fonctions;

internal class Calculette
{

    static double Add(double a, double b) => a + b;
    static double Substract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Operation invalid, division par 0.");
            return 0;
        }

        return a / b;
    }

    static double Modulo(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Operation invalid, modulo par 0.");
            return 0;
        }

        return a % b;
    }



    static void Main(string[] args)
    {

        while (true)
        {
            Console.WriteLine("\n\nSaisit exit to exit the program.");


            Console.Write("Premier Nombre :");
            var operation1 = Console.ReadLine();

            if (string.IsNullOrEmpty(operation1))
            {
                Console.WriteLine("Operation annuler, nombre saisit vide ou invalid.");
                return;
            }

            if (operation1 == "exit")
                break;

            Console.Write("Second Nombre :");
            var operation2 = Console.ReadLine();

            if (string.IsNullOrEmpty(operation2))
            {
                Console.WriteLine("Operation annuler, nombre saisit vide ou invalid.");
                return;
            }

            if (operation2 == "exit")
                break;

            Console.Write("Operateur [add, multiply, substract, divide, modulo]:");
            var op = Console.ReadLine();

            if (string.IsNullOrEmpty(op))
            {
                Console.WriteLine("Operation annuler, operateur saisit vide ou invalid.");
                return;
            }

            if (op == "exit")
                break;

            double res = 0;
            string oper = "";

            if (double.TryParse(operation1, out double firstNumber))
            {
                if (double.TryParse(operation2, out double secondNumber))
                {
                    switch (op)
                    {
                        case "multiply":
                            res = Multiply(firstNumber, secondNumber);
                            oper = "*";
                            break;
                        case "add":
                            res = Add(firstNumber, secondNumber);
                            oper = "+";
                            break;
                        case "substract":
                            res = Substract(firstNumber, secondNumber);
                            oper = "-";
                            break;
                        case "divide":
                            res = Divide(firstNumber, secondNumber);
                            oper = "/";
                            break;
                        case "modulo":
                            res = Modulo(firstNumber, secondNumber);
                            oper = "%";
                            break;
                        default:
                            Console.WriteLine("Operation annuler, operator not found.");
                            break;
                    }

                    Console.WriteLine($"{firstNumber} {oper} {secondNumber} = {Math.Round(res, 2)}");
                }
            }
        }


        Console.WriteLine("Fin du program.");

    }
}
