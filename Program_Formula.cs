namespace Prueba
{
    class Program_Formula
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el agente que desea ejecutar: ");
            Console.WriteLine("[1] - Agente A");
            Console.WriteLine("[2] - Agente B");
            Console.WriteLine("[3] - Agente C");
            Console.WriteLine("Ingrese la opción:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ingrese la lista de números: ");
            var n = Console.ReadLine();
            if (n != null)
            {
                switch (num)
                {
                    case 1:
                        getMedia_AgenteA(n);
                        break;
                    case 2:
                        getMediaArmonica_AgenteB(n);
                        break;
                    case 3:
                        getMediana_AgenteC(n);
                        break;
                    default:
                        Console.WriteLine("Seleccione una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Debe ingresar una lista de números.");
            }
        }

        static void getMedia_AgenteA(string n)
        {
            double suma = 0.0;
            for (int y = 0; y < n.Length; y++)
            {
                suma = suma + Convert.ToInt32(n.Substring(y, 1));
            }
            double result = suma / n.Length;
            Console.WriteLine("El resultado de la media es: " + result);
        }

        static void getMediaArmonica_AgenteB(string n)
        {
            double suma = 0.0;
            for (int y = 0; y < n.Length; y++)
            {
                suma = suma + (1 / Convert.ToInt32(n.Substring(y, 1)));
            }
            double result = n.Length / suma;
            Console.WriteLine("El resultado de la media es: " + result);
        }

        static void getMediana_AgenteC(string n)
        {
            int[] vec = new int[n.Length];
            for (int y = 0; y < n.Length; y++)
            {
                vec[y] = Convert.ToInt32(n.Substring(y, 1));
            }
            Array.Sort(vec);
            double suma = 0.0;
            if (vec.Length % 2 == 0)
            {
                int mitad1 = vec[(vec.Length / 2)];
                int mitad2 = vec[(vec.Length / 2) + 1];
                suma = (mitad1 + mitad2) / 2;
            }
            else
            {
                decimal mitad = (vec.Length / 2) + 1;
                int pos = Convert.ToInt32(Math.Floor(mitad));
                suma = vec[pos - 1];
            }
            Console.WriteLine("El resultado de la mediana es: " + suma);
        }
    }
}