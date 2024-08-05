
using PruebaVeterinaryCenter.models;

class Program
{
    static void Main(string[] args)
    {
        bool bandera = true;
        int option;

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
                            //castrat
                            break;
                        case 7:
                            bandera = false;
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
            Console.WriteLine("Ingrese el id dee el perro que desea eliminar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var deleteDog = new VeterinaryClinic();
            deleteDog.DeleteDog(id);
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
    
        //ver animal por id
        void seeAnimalById(){
            Console.WriteLine("Ingresa el id de el animal deseas ver : ");
            int id = Convert.ToInt32(Console.ReadLine());

            var seeAnimal = new VeterinaryClinic();
            seeAnimal.ShowPatient(id);

        }
    
        //animal castrado
        void CastrateAnimal(){
            Console.Write("Ingrese el id del animal que desea castrar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var seeAnimal = new VeterinaryClinic();
            seeAnimal.CastrateAnimal(id);
        }
    
    }
}
