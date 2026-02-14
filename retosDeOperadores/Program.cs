namespace retosDeOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaracion de variables
            int width = 7;
            int height = 5;

            // calcular area

            int area = width * height;

            // calcular perimetro

            int perimetro = 2 * width + 2 * height;

            // incrementar width en 3
            width += 3;

            // decrementar height en 2
            height -= 2;

            // recalcular area y perimetro 
            area = width * height;
            perimetro = 2 * height + 2 * width;

            // mostrar en consola 
            Console.WriteLine("valores finales");
            Console.WriteLine("width: " + width);
            Console.WriteLine("height : " + height);
            Console.WriteLine("area: " + area);
            Console.WriteLine("perimetro: " + perimetro);




        }
    }
}
