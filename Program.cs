
using PruebaVeterinaryCenter.models;

class Program
{
    static void Main(string[] args)
    {
        int option;

        do
        {
            InterfazVisual.Visualize();

            try
            {
                bool opSuccess = int.TryParse(Console.ReadLine(), out option);
                if (opSuccess != true)
                {
                    Menssage.InvalidData();
                }
                else
                {
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine(@"
                            ============= Perro =============
                            1.Agregar un perro.
                            2.Actualizar un perro.
                            3.ELiminar un perro.");
                            int option2;
                            bool optionSuccess = int.TryParse(Console.ReadLine(), out option2);

                            switch (option2)
                            {
                                case 1:
                                    CreateDog();
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    DeleteDog();
                                    break;


                                default:
                                    break;
                            }

                            break;
                        case 2:
                        Console.WriteLine(@"
                            ============= Gato =============
                            1.Agregar un gato.
                            2.Actualizar un gato.
                            3.ELiminar un gato.");
                            int option3;
                            bool optionSucces = int.TryParse(Console.ReadLine(), out option3);

                            switch (option3)
                            {
                                case 1:
                                    CreateCat();
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    DeleteCat();
                                    break;
                                
                                default:
                                    break;
                            }
                            break;
                        case 3:
                            var see = new VeterinaryClinic();
                            see.ShowAllPatients();
                            break;
                        case 4:
                            SeeAnimalByType();
                            break;

                        default:
                            break;
                    }

                }


            }
            catch (System.Exception)
            {

                throw;
            }


        } while (true);

        //metodos----------------------------------
        //perro------------------------------------------------
        void CreateDog()
        {
            Console.WriteLine("¡Vamos a registrar un perro!");

            Console.WriteLine("Nombre:");
            string name = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento: AAAA-MM-DD");
            DateOnly birthDate;
            if (DateOnly.TryParse(Console.ReadLine(), out birthDate))
            {
                // Obtengo fecha actual
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

                // Comparo la fecha de nacimiento con la fecha actual
                if (birthDate >= currentDate)
                {
                    Console.WriteLine("La fecha de nacimiento no puede ser mayor que la fecha actual.");
                }
            } else
            {
                Console.WriteLine("La fecha ingresada no es válida. Asegúrate de usar el formato AAAA-MM-DD.");
            }

            Console.WriteLine("Raza:");
            string breed = Console.ReadLine();

            Console.WriteLine("Color:");
            string color = Console.ReadLine();

            Console.WriteLine("Peso en Kg:");
            double weightInKg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Temperamento: 
            1.timido, 2.normal, 3.agresivo :");
            string validation = Console.ReadLine().ToLower();
            string temperament = validation == "1" ? "timido" : validation == "2" ? "normal" : validation == "3" ? "agresivo" : "invalide";


            Console.WriteLine("¿El canino aun esta en estado de reprocucción? SI/NO:");
            string status = Console.ReadLine().ToLower();
            bool breedingStatus = status == "si" ? true : false;

            Console.WriteLine("Numero del microship:");
            string microchipNumber = Console.ReadLine();

            Console.WriteLine("Volumen de ladrido :");
            string barkVolume = Console.ReadLine();

            Console.WriteLine(@"Tipo de pelo :
            1.sin pelo, 2. pelo corto,
            3.pelo mediano, 4. pelo largo) :");
            string type = Console.ReadLine();
            string coatType = type == "1" ? "sin pelo" : type == "2" ? "pelo corto" : type == "3" ? "pelo mediano" : type == "4" ? "pelo largo" : "invalide";

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(breed) || string.IsNullOrWhiteSpace(temperament) || string.IsNullOrWhiteSpace(microchipNumber))
            {
                Console.WriteLine("Algun dato ingresado no es valido,por favor verifica antes de crear!");
                
            }else
            {
                //agregar un perro
                Dog dog = new Dog(name, birthDate, breed, color, weightInKg, breedingStatus, temperament, microchipNumber, barkVolume, coatType);
                VeterinaryClinic.SaveDog(dog);
                
            }
        }

        //eliminar
        void DeleteDog(){
            Console.WriteLine("Ingrese el id dee el perro que desea eliminar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var deleteDog = new VeterinaryClinic();
            deleteDog.DeleteDog(id);
        }
    

        //gato------------------------------------
        void CreateCat()
        {
            Console.WriteLine("¡Vamos a registrar un gato!");

            Console.WriteLine("Nombre:");
            string name = Console.ReadLine().Trim();

            Console.WriteLine("Fecha de nacimiento: AAAA-MM-DD");
            DateOnly birthDate;
            if (DateOnly.TryParse(Console.ReadLine(), out birthDate))
            {
                // Obtengo fecha actual
                DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

                // Comparo la fecha de nacimiento con la fecha actual
                if (birthDate >= currentDate)
                {
                    Console.WriteLine("La fecha de nacimiento no puede ser mayor que la fecha actual.");
                }
            } else
            {
                Console.WriteLine("La fecha ingresada no es válida. Asegúrate de usar el formato AAAA-MM-DD.");
            }

            Console.WriteLine("Raza:");
            string breed = Console.ReadLine();

            Console.WriteLine("Color:");
            string color = Console.ReadLine();

            Console.WriteLine("Peso en Kg:");
            double weightInKg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("¿El felino aun esta en estado de reprocucción? SI/NO:");
            string status = Console.ReadLine().ToLower();
            bool breedingStatus = status == "si" ? true : false;

            Console.WriteLine(@"Tipo de pelo :
            1.sin pelo, 2. pelo corto,
            3.pelo mediano, 4. pelo largo) :");
            string type = Console.ReadLine();
            string furLength = type == "1" ? "sin pelo" : type == "2" ? "pelo corto" : type == "3" ? "pelo mediano" : type == "4" ? "pelo largo" : "invalide";

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(breed) )
            {
                Console.WriteLine("Algún dato ingresado no es valido,por favor verifica antes de crear!");
                
            }else
            {
                Cat cat = new Cat(name, birthDate, breed, color, weightInKg,breedingStatus,furLength);
                VeterinaryClinic.SaveCat(cat);
            }


        }
    
        //eliminar
        void DeleteCat(){
            Console.WriteLine("Ingrese el id de el gato que desea eliminar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var deleteCat = new VeterinaryClinic();
            deleteCat.DeleteCat(id);

        }
    

        //ver animal por tipo
        void SeeAnimalByType(){
            Console.WriteLine("¿Qué tipo de animal deseas ver? Escribe la raza: ");
            string breed = Console.ReadLine().ToLower();

            var seeAnimal = new VeterinaryClinic();
            seeAnimal.ShowAnimals(breed);
        }
    
    }
}