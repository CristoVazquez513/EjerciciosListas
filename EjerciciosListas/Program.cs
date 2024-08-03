namespace EjerciciosListas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> diasSemana = new List<string>();
            diasSemana.Add("1.- Lunes");
            diasSemana.Add("2.- Martes");
            diasSemana.Add("3.- Miercoles");
            diasSemana.Add("4.- Jueves");
            diasSemana.Add("5.- Viernes");
            diasSemana.Add("6.- Sabado");
            diasSemana.Add("7.- Domingo");

            foreach (string dia in diasSemana) 
            {
                Console.WriteLine(dia);
            }

            //Console.WriteLine("Dame un numero de dia");
            //string diaUsuario = Console.ReadLine();
            //Console.WriteLine(diasSemana[int.Parse(diaUsuario)-1]);

            Console.WriteLine(((int)DateTime.Now.DayOfWeek));
            Console.WriteLine(diasSemana[((int)DateTime.Now.DayOfWeek)-1]);
        }
    }
}
