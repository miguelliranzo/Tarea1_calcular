

namespace Tarea1_calcular.Class
{
    public class Calcualar
    {
        public void secuencial()
        {
            int num1 = 0;
            int num2 = 0;
            int suma = 0;
            int producto = 0;
            int resultado = 0;

            Console.WriteLine("Digita el primer numero:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digita el segundo numero:");
            num2 = Convert.ToInt32(Console.ReadLine());

            suma = (num1 + num2);
            producto = (num1 * num2);
            

            Console.WriteLine($"El total de la suma es : {suma }, y el resultado del producto es : {producto} ");

            
    


        }
    }
}
