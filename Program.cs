namespace Prueba
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Ingrese el agente que desea ejecutar: ");
            Console.WriteLine("[1] - Agente A");
            Console.WriteLine("[2] - Agente B");
            Console.WriteLine("[3] - Agente C");
            Console.WriteLine("Ingrese la opción:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ingrese el tamaño de N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0 || n > 100)
            {
                Console.WriteLine("Debe ingresar un tamaño entre 0 y 100.");
            }
            else
            {
                switch (num)
                {
                    case 1:
                        getStairCase_AgenteA(n);
                        break;
                    case 2:
                        getStairCase_AgenteB(n);
                        break;
                    case 3:
                        getStairCase_AgenteC(n);
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción válida.");
                        break;
                }
            }
        }

        static void getStairCase_AgenteA(int n)
        {
            for (int y = n - 1; y >= 0; y--)
            {
                for (int x = 0; x < n; x++)
                {
                    if (x >= y)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }
        }

        static void getStairCase_AgenteB(int n)
        {
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if (y > x)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }

                }
                Console.WriteLine("");
            }
        }

        static void getStairCase_AgenteC(int n)
        {

        }
    }
}