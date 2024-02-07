using System.Diagnostics;

namespace ejercicio5Fechas
{

    class Program
    {

        static void Main(string[] args)
        {
            //PARA PEDIR FECHAS AL USUARIO
            Console.WriteLine("Inserte fecha 1");
            DateTime fecha1 = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Inserte fecha 2");
            DateTime fecha2 = Convert.ToDateTime(Console.ReadLine());

            //PARA ORDENAR LAS FECHAS
            if (fecha1 < fecha2)
            {
                DateTime temp = fecha1;
                fecha1 = fecha2;
                fecha2 = temp;
            }
            
            //PARA SACAR LA DIFERENCIA ENTRE LAS FECHAS, TimeSpan sirve para sacar intervalos de tiempo entre dos fechas 
            TimeSpan fechaDiferencia = fecha1.Subtract(fecha2);
            
            //PARA SACAR HORAS,MINUTOS Y SEGUNDOS
            int horas = 24 * fechaDiferencia.Days;
            int minutos = 60 * horas;
            int sec = 60 * minutos;

            Console.WriteLine(" ");
            Console.WriteLine("La fecha restante es:");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Dias: " + fechaDiferencia.Days);
            Console.WriteLine("Horas: "+ horas);
            Console.WriteLine("Minutos: " + minutos);
            Console.WriteLine("Segundos: " + sec);





            /*
            int Dias = fecha1.Day - fecha2.Day;
            int Horas = fecha1.Hour - fecha2.Hour;
            int Minutos = fecha1.Minute - fecha2.Minute;
            int Segundos = fecha1.Second - fecha2.Second;
            */
        }
    }
}