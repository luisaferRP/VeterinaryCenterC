namespace PruebaVeterinaryCenter.models
{
    public class InterfazVisual
    {
        public static void Visualize(){
            Console.WriteLine(@"
            ===============================================
                        Bienvenido usuario
            ===============================================
                1.Perro.
                2.Gato.
                3.Mostrar todos los pacientes.
                4.Mostrar animal por tipo (raza).
                5.Mostrar paciente por ID.
                6.Castrar animal.
                7.Peluqueria de animal.
                8.Salir.
            =================================================
                Por favor elija una opción: ");
        }
    }
}