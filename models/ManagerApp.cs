using System.Security.AccessControl;

namespace PruebaVeterinaryCenter.models
{
        public static class ManagerApp
        {

                //miembros metodos static
                public static Dog CreateDog()
                {
                        string name;
                        DateOnly birthDate;
                        string breed;
                        string color;
                        double weightInKg;
                        bool isCastrated;
                        string temperament;
                        bool breedingStatus;
                        string microchipNumber;
                        string barkVolume;
                        string coatType;

                        while (true)
                        {
                                Console.WriteLine("Nombre:");
                                name = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(name))
                                {
                                        Console.WriteLine("El nombre no puede estar vacío. Inténtalo de nuevo.");
                                        continue;
                                }
                                break;
                        }
                        while (true)
                        {
                                Console.WriteLine("Fecha de nacimiento: AAAA-MM-DD");
                                if (DateOnly.TryParse(Console.ReadLine(), out birthDate))
                                {
                                        DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
                                        //comparo fechas
                                        if (birthDate >= currentDate)
                                        {
                                                Console.WriteLine("La fecha de nacimiento no puede ser mayor que la fecha actual. Inténtalo de nuevo.");
                                                continue;
                                        }
                                        break;
                                }
                                else
                                {
                                        Console.WriteLine("La fecha ingresada no es válida. Asegúrate de usar el formato AAAA-MM-DD. Inténtalo de nuevo.");
                                }
                        }
                        while (true)
                        {
                                Console.WriteLine("Raza:");
                                breed = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(breed))
                                {
                                        Console.WriteLine("La raza no puede estar vacía. Inténtalo de nuevo.");
                                        continue;
                                }
                                break;
                        }

                        while (true)
                        {
                                Console.WriteLine("Color:");
                                color = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(color))
                                {
                                        Console.WriteLine("El color no puede estar vacío. Inténtalo de nuevo.");
                                        continue;
                                }
                                break;
                        }

                        while (true)
                        {
                                Console.WriteLine("Peso en Kg:");
                                if (double.TryParse(Console.ReadLine(), out weightInKg))
                                {
                                        break;
                                }
                                else
                                {
                                        Console.WriteLine("El peso debe ser un número positivo. Inténtalo de nuevo.");
                                }
                        }

                        while (true)
                        {
                                Console.WriteLine("¿El canino está castrado? 1.SI , 2.NO:");
                                string castrate = Console.ReadLine();
                                if (castrate == "1")
                                {
                                        isCastrated = true;
                                        break;
                                }
                                else if (castrate == "2")
                                {
                                        isCastrated = false;
                                        break;
                                }
                                else
                                {
                                        Console.WriteLine("Opción invalida, Inténtalo de nuevo.");
                                }
                        }

                        while (true)
                        {
                                Console.WriteLine(@"Temperamento: 
                                        1. tímido, 2. normal, 3. agresivo:");
                                string validation = Console.ReadLine();
                                if (validation == "1")
                                {
                                        temperament = "tímido";
                                        break;
                                }
                                else if (validation == "2")
                                {
                                        temperament = "normal";
                                        break;
                                }
                                else if (validation == "3")
                                {
                                        temperament = "agresivo";
                                        break;
                                }
                                else
                                {
                                        Console.WriteLine("Opción invalida. Usa 1, 2 o 3. Inténtalo de nuevo.");
                                }
                        }

                        while (true)
                        {
                                Console.WriteLine("¿El canino aún está en estado de reproducción? SI/NO:");
                                string status = Console.ReadLine().ToLower();
                                if (status == "si")
                                {
                                        breedingStatus = true;
                                        break;
                                }
                                else if (status == "no")
                                {
                                        breedingStatus = false;
                                        break;
                                }
                                else
                                {
                                        Console.WriteLine("Opción no válida. Usa SI o NO. Inténtalo de nuevo.");
                                }
                        }

                        while (true)
                        {
                                Console.WriteLine("Número del microchip:");
                                microchipNumber = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(microchipNumber))
                                {
                                        Console.WriteLine("El número del microchip no puede estar vacío. Inténtalo de nuevo.");
                                        continue;
                                }
                                break;
                        }

                        while (true)
                        {
                                Console.WriteLine("Volumen de ladrido :");
                                barkVolume = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(barkVolume))
                                {
                                        Console.WriteLine("El volumen del ladrido no puede estar vacío. Inténtalo de nuevo.");
                                        continue;
                                }
                                break;

                        }

                        while (true)
                        {
                                Console.WriteLine(@"Tipo de pelo :
                                        1.sin pelo, 2. pelo corto,
                                        3.pelo mediano, 4. pelo largo) :");
                                string type = Console.ReadLine();
                                if (type == "1")
                                {
                                        coatType = "sin pelo";
                                        break;

                                }
                                else if (type == "2")
                                {
                                        coatType = "pelo corto";
                                        break;
                                }
                                else if (type == "3")
                                {
                                        coatType = "pelo mediano";
                                        break;
                                }
                                else if (type == "4")
                                {
                                        coatType = "pelo largo";
                                        break;
                                }
                                else
                                {
                                        Console.WriteLine("Opción no válida.Inténtalo de nuevo.");
                                        continue;
                                }
                        }

                        //crear un perro
                        return new Dog(name, birthDate, breed, color, weightInKg, isCastrated, breedingStatus, temperament, microchipNumber, barkVolume, coatType);
                }

                //mostrar cabecera
                public static void ShowHeader() { }

                //mostrar pue de pagina
                public static void ShowFooter() { }

                //mostrar separador
                public static void ShowSeparator() { }

        }
}



