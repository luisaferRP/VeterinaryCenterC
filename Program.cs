
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
                                        break;
                                    case 2:
                                        break;
                                    case 3:
                                        break;

                                    
                                    default:
                                        break;
                                }

                            break;
                        case 2: 
                            break;
                        case 3: 
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
        //agregar un perro
        void CreateDog(){
            Console.WriteLine("¡Vamos a registrar un perro!");

            Console.WriteLine("Nombre:");
            string name = Console.ReadLine();

            Console.WriteLine("Fecha de nacimiento: AAAA-MM-DD");
            DateOnly brithDate;
            bool brith = DateOnly.TryParse(Console.ReadLine(), out brithDate);

            Console.WriteLine("Raza:");
            string breed = Console.ReadLine();

            Console.WriteLine("Color:");
            string color = Console.ReadLine();

            Console.WriteLine("Peso en Kg:");
            double weightInKg = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Temperamento: 
            1.timido, 2.normal, 3.agresivo :");
            string validation = Console.ReadLine().ToLower();
            string temperament = validation == "1" ? "timido" : validation == "2" ? "normal" : validation == "3" ? "agresivo": "invalide";


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

            //agregar un perro
            Dog dog = new Dog(name,brithDate,breed,color,weightInKg,breedingStatus,temperament,microchipNumber,barkVolume,coatType);
            VeterinaryClinic.SaveDog(dog);
            






            






        }

    }
}