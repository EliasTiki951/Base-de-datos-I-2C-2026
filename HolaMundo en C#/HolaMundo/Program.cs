namespace MiProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 5.2;
            double y = 10;
            double a = Math.Pow(x,2); //Potencia
            double raiz = Math.Sqrt(x); //Raiz Cuadrada
            double red = Math.Round(x); //Redondear para arriba
            double piso = Math.Floor(x); //Redondear para abajo
            double arriba = Math.Ceiling(x); //Número que está arriba
            double maximo = Math.Max(x, y); //El número maximo entre 2 numeros.
            double minimo = Math.Min(x, y); //El número mínimo entre 2 numeros.

            //Potencia
            Console.Write(x + " elevado al cuadrado ");
            Console.WriteLine(" es " + a);
            Console.WriteLine();
            //Raiz Cuadrada
            Console.Write("La raíz cuadrada de "+ x);
            Console.WriteLine(" es "+ raiz);
            Console.WriteLine();
            //Redondear para arriba
            Console.WriteLine(red);
            Console.WriteLine();
            //Redondear para abajo
            Console.WriteLine(piso);
            Console.WriteLine();
            //Número que está arriba
            Console.WriteLine(arriba);
            Console.WriteLine();
            //El número maximo entre 2 numeros.
            Console.WriteLine("El número máximo es "+ maximo);
            Console.WriteLine();
            //El número mínimo entre 2 numeros.
            Console.WriteLine("El número mínimo es "+ minimo);
            Console.WriteLine();

            Console.WriteLine("====================================");
            Console.WriteLine();

            Random aleatorio = new Random(); //Invoca números aleatorios
            int num = aleatorio.Next(1,7); //En un dado hay 6 caras, entonses se pone 7 [1;7)
            int num2 = aleatorio.Next(1, 101); //Cualquier número del 1-100
            double num3 = aleatorio.NextDouble(); //Cualquier número double o decimal del 0 al 1

            Console.WriteLine("Número Aleatorio (1-6): "+ num);
            Console.WriteLine("Número Aleatorio (1-100): "+ num2);
            Console.WriteLine("Número Aleatorio (0-1): " + num3);
            Console.WriteLine();

            Console.Write("Escribe tu nombre: ");
            string nombre = Console.ReadLine();

            if(nombre == "")
            {
                Console.WriteLine("No escribiste tu nombre paisa...");
            }
            else
            {
                Console.WriteLine("Tu nombre es: "+ nombre);
                Console.WriteLine();
                Console.WriteLine("Hola "+ nombre);

            }

            Console.Write("Ingresa tu edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            if(edad > 100)
            {
                Console.WriteLine("Mentiroso");
            }
            else if(edad >= 18)
            {
                Console.WriteLine("Te has inscripto");
            }
            else if(edad<2)
            {
                Console.WriteLine("Eres un bebé");
            }
            else
            {
                Console.WriteLine("Tienes que ser mayor de 18");
            }

            if (edad < 100)
            {
                Console.WriteLine();
                Console.Write("Tu edad es de " + edad);
                Console.WriteLine(" años.");
            }

            Console.ReadKey(); // Hace que no aparesca letras en la terminal
                               // Al menos que toques enter y salgas de la terminal
        }
    }
}