
using PruebaVeterinaryCenter.models;

class Program
{
    static void Main(string[] args)
    {
        bool bandera = true;
        int option;
        var VeterinaryClinic = new VeterinaryClinic("Todos juntos","cra 23 # 7b");

        do
        {
            //bool bandera = true;
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
                        case 5:
                            seeAnimalById();
                            break;
                        case 6:
                            CastrateAnimal();
                            break;
                        case 7:
                            break;
                        case 8:
                            Console.Write("¡Chao! Te deseo un lindo día");
                            Console.WriteLine("Preciona cualquier tecla para salir");
                            Console.Read();
                            bandera = false;
                            break;

                        default:
                            break;
                    }

                }

            }
            catch (System.Exception)
            {

                Console.WriteLine("Ha ocurrido un error,ejecute de nuevo el programa...");
            }


        } while (bandera);

        //metodos----------------------------------
        //perro------------------------------------------------
        void CreateDog()
        {
            Console.WriteLine("¡Vamos a registrar un perro!");
            Dog newDog = ManagerApp.CreateDog();
            VeterinaryClinic.SaveDog(newDog);
        }

        //eliminar
        void DeleteDog(){
            Console.WriteLine("Ingrese el id de el perro que desea eliminar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            VeterinaryClinic.DeleteDog(id);
        }
    

        //gato------------------------------------
        void CreateCat()
        {
            Console.WriteLine("¡Vamos a registrar un gato!");
            Cat newCat = ManagerApp.CreateCat();
            VeterinaryClinic.SaveCat(newCat);
        }
    
        //eliminar
        void DeleteCat(){
            Console.WriteLine("Ingrese el id de el gato que desea eliminar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            VeterinaryClinic.DeleteCat(id);

        }

        //ver animal por tipo
        void SeeAnimalByType(){
            Console.WriteLine("¿Qué tipo de animal deseas ver? Escribe la raza: ");
            string breed = Console.ReadLine().ToLower();

            VeterinaryClinic.ShowAnimals(breed);
        }
    
        //ver animal por id
        void seeAnimalById(){
            Console.WriteLine("Ingresa el id de el animal deseas ver : ");
            int id = Convert.ToInt32(Console.ReadLine());

            var seeAnimal = new VeterinaryClinic();
            VeterinaryClinic.ShowPatient(id);

        }

        //peluqueria de animales
        void HairdressAnimal(){
            //ParallelLoopState 1 buscar  desde aca y despues la ma en dog

            while (true)
            {
                Console.WriteLine("¿Qué tipo de animal desea peluquear? 1.Perro o 2.Gato");
                int option = Convert.ToInt16(Console.ReadLine()); 

                if(option == 1){
                    Console.WriteLine("Ingresa el id de el perro: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var findDog = VeterinaryClinic.Dogs.FirstOrDefault(item => item.ReturnId() == id);
                    if (findDog != null)
                    {
                        findDog.Hairdress();
                    }
                    break;

                }else if(option == 2){
                    Console.WriteLine("Ingresa el id de el gato: ");
                    int id = Convert.ToInt32(Console.ReadLine());
                    var findCat = VeterinaryClinic.Cats.FirstOrDefault(item => item.ReturnId() == id);
                    if (findCat != null)
                    {
                        findCat.Hairdress();
                    }

                    break;
                }
                
            }

        }

        //animal castrado
        void CastrateAnimal(){
            Dog.CastrateAnimal();
        }
    
    }
}
