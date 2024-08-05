namespace PruebaVeterinaryCenter.models
{
    public class Menssage
    {
        public static void InvalidData(){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("¡Ey! ¡Por favor ingresa un dato valido!");
            Console.ResetColor();
        }

        public static void CreateSucces(){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Dato agregado de forma exitosa!");
            Console.ResetColor();
        }

        public static void DeleteSuccess()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡Dato eliminado de forma exitosa!");
            Console.ResetColor();

        }
    }
}