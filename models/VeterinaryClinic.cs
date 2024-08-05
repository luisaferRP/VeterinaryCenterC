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
        public VeterinaryClinic()
        {
        }

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

        }

        //metodo para actualizar un gato
        public void UpdateCat(Dog dog)
        {

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
            Console.WriteLine("---------------- Estos son todos los pacientes -----------------");
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
            Console.WriteLine($"----------------------Animales de raza: {type}----------------------");
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
            Console.WriteLine($"----------------------Animales con id: {idPatient}----------------------");
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
        public void CastrateAnimal(int idAnimal)
        {
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