using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Runtime.CompilerServices;

namespace PruebaVeterinaryCenter.models
{
    public class VeterinaryClinic
    {
        public string Name;
        public string Address;
        public static List<Dog> Dogs = new List<Dog>();
        public static List<Cat> Cats = new List<Cat>();

        //miembros metodos
        public VeterinaryClinic() { }

        //constructor con parametros
        public VeterinaryClinic(string name, string address)
        {
            this.Name = name;
            this.Address = address;
        }

        //metodo para agregar un perro a la clinica
        public static void SaveDog(Dog newDog)
        {
            Dogs.Add(newDog);
            Menssage.CreateSucces();

        }

        //metodo para agregar un gato a la clinica
        public static void SaveCat(Cat newCat)
        {
            Cats.Add(newCat);
            Menssage.CreateSucces();
        }

        //metodo para actualizar un perro 
        public void UpdateDog(Dog dog)
        {
            string color = string.Empty;
            double weightInKg = 0.0;
            bool breedingStatus = false;

            int option;

            Console.Write($"\nElige una opcion de lo que deseas actualizar del perro:\n1.Color\n2.Peso en kilogramos\n3.Castraccion\n4.Temperamento\n5.Volumen de ladrido\n6.Tamaño del pelo\n-----> ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Ingresa el nuevo color del perro\n------> ");
                    color = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Ingresa el peso del perro en kilogramos\n------> ");
                    weightInKg = Convert.ToDouble(Console.ReadLine());
                    break;
                case 3:
                    while (true)
                    {
                        Console.WriteLine("¿Cuál es el estado de castración del perro? Elige una opción:");
                        Console.WriteLine("1. Castrado , 2. No castrado");
                        option = Convert.ToInt32(Console.ReadLine());

                        if (option == 1)
                        {
                            breedingStatus = true;
                            break;
                        }
                        else if (option == 2)
                        {
                            breedingStatus = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, pero debes elegir una opción disponible.");
                            continue;
                        }
                    }
                    break;
                // Se pueden añadir más casos aquí según las opciones de actualización disponibles
                default:
                    Console.WriteLine("Error, elige una opción válida.");
                    return; // Salir del método si la opción no es válida
            }

            Console.WriteLine($"El perro {dog.ReturnId()} ha sido ACTUALIZADO con éxito.");
            dog.UpdateData(color, weightInKg, breedingStatus);
        }

        //metodo para actualizar un gato
        public void UpdateCat(Cat cat)
        {
            string color = string.Empty;
            double weightInKg = 0.0;
            bool breedingStatus = false;

            int option;

            Console.Write($"\nElige una opcion de lo que deseas actualizar del gato:\n1.Color\n2.Peso en kilogramos\n3.Castraccion\n4.Temperamento\n5.Volumen de ladrido\n6.Tamaño del pelo\n-----> ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Ingresa el nuevo color del gato\n------> ");
                    color = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Ingresa el peso del gato en kilogramos\n------> ");
                    weightInKg = Convert.ToDouble(Console.ReadLine());
                    break;
                case 3:
                    while (true)
                    {
                        Console.WriteLine("¿Cuál es el estado de castración del gato? Elige una opción:");
                        Console.WriteLine("1. Castrado , 2. No castrado");
                        option = Convert.ToInt32(Console.ReadLine());

                        if (option == 1)
                        {
                            breedingStatus = true;
                            break;
                        }
                        else if (option == 2)
                        {
                            breedingStatus = false;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Lo sentimos, pero debes elegir una opción disponible.");
                            continue;
                        }
                    }
                    break;
                // Se pueden añadir más casos aquí según las opciones de actualización disponibles
                default:
                    Console.WriteLine("Error, elige una opción válida.");
                    return; // Salir del método si la opción no es válida
            }

            Console.WriteLine($"El gato con id: {cat.ReturnId()} ha sido ACTUALIZADO con éxito.");
            cat.UpdateData(color, weightInKg, breedingStatus);

        }



        //eliminar perro
        public void DeleteDog(int id)
        {
            var DogFind = Dogs.FirstOrDefault(item => item.ReturnId() == id);

            if (DogFind != null)
            {
                Console.WriteLine("¡Oye! ¿Seguro qué deseas eliminar este animal? SI/NO");
                string confirmation = Console.ReadLine().Trim().ToLower();

                if (string.IsNullOrWhiteSpace(confirmation) == false && confirmation == "si")
                {
                    Dogs.Remove(DogFind);
                    Menssage.DeleteSuccess();
                }
                else
                {
                    Console.WriteLine("Se ha cancelado la eliminación...");
                }

            }
        }

        //eliminar gato
        public void DeleteCat(int id)
        {
            var CatFind = Cats.FirstOrDefault(item => item.ReturnId() == id);

            if (CatFind != null)
            {
                Console.WriteLine("¡Oye! ¿Seguro qué deseas eliminar este animal? SI/NO");
                string confirmation = Console.ReadLine().Trim().ToLower();

                if (string.IsNullOrWhiteSpace(confirmation) == false && confirmation == "si")
                {
                    Cats.Remove(CatFind);
                    Menssage.DeleteSuccess();
                }
                else
                {
                    Console.WriteLine("Se ha cancelado la eliminación...");
                }

            }
        }

        //Mostrar todos los pacientes
        public void ShowAllPatients()
        {
            Console.WriteLine(@"
            ==================================================================================
                                    Estos son todos los pacientes 
            ==================================================================================
            ");
            if (Dogs.Count == 0)
            {
                Console.WriteLine("No hay perros registrados en este mometos");
            }
            else
            {
                foreach (var dog in Dogs)
                {
                    dog.ShowInformacionDog();
                }
            }

            if (Cats.Count == 0)
            {
                Console.WriteLine("No hay gatos registrados en este mometos");

            }
            else
            {

                foreach (var cat in Cats)
                {
                    cat.ShowInformacionCat();

                }
            }
        }

        //Mostrar todos los animales
        public void ShowAnimals(string type)
        {
            Console.WriteLine(@$"
            ==========================================================================
                                    Animales de raza: {type}
            ==========================================================================");
            var findBreedD = Dogs.Where(item => item.RetrunBreed() == type).ToList();
            var findBreedC = Cats.Where(item => item.RetrunBreed() == type).ToList();

            if (findBreedD.Count == 0 && findBreedC.Count == 0)
            {
                Console.WriteLine("No hay animales de esa raza registrados.");
            }
            else
            {
                foreach (var item in findBreedD)
                {
                    item.ShowInformacionDog();
                }
                foreach (var item in findBreedC)
                {
                    item.ShowInformacionCat();
                }

            }
        }

        //mostrar paciente
        public void ShowPatient(int idPatient)
        {
            Console.WriteLine(@$"
            =================================================================
                                Animales con id: {idPatient}
            =================================================================");
            var findDog = Dogs.FirstOrDefault(item => item.ReturnId() == idPatient);
            var findCat = Cats.FirstOrDefault(item => item.ReturnId() == idPatient);

            if (findDog != null)
            {
                findDog.ShowInformacionDog();
            }
            else if (findCat != null)
            {
                findCat.ShowInformacionCat();
            }
            else
            {
                Console.WriteLine("No hay pacientes registrados con ese id.");
            }

        }

        //Buscar animal para castrar
        public void ValidationCastrateAnimal(int idAnimal)
        {
            Console.WriteLine("verificando...");
            var findDog = Dogs.Where(item => item.ReturnId() == idAnimal).Select(item => new
            {
                id = item.ReturnId(),
                castrated = item.isCastrated
            }).ToList();

            var findCat = Cats.Where(item => item.ReturnId() == idAnimal).Select(item => new
            {
                id = item.ReturnId(),
                castrated = item.isCastrated
            }).ToList();

            if (findDog != null || findDog.Count != 0)
            {
                foreach (var item in findDog)
                {
                    if (item.castrated == false)
                    {
                        Console.WriteLine($"El perro con el id: {item.id} , no ha sido castrado");
                    }
                    else
                    {
                        Console.WriteLine($"El perro con el id: {item.id} , ya ha sido castrado");
                    }

                }
            }
            else if (findCat != null || findCat.Count != 0)
            {

                foreach (var item in findCat)
                {
                    if (item.castrated == false)
                    {
                        Console.WriteLine($"El gato con el id: {item.id} , no ha sido castrado");
                    }
                    else
                    {
                        Console.WriteLine($"El gato con el id: {item.id} , ya ha sido castrado");
                    }

                }
            }
        }

    }
}