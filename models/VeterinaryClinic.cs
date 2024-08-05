using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace PruebaVeterinaryCenter.models
{
    public class VeterinaryClinic
    {
        public string Name;
        public string Address;
        public List<Dog> Dogs = new List<Dog>();
        public List<Cat> Cats = new List<Cat>();

        //miembros metodos
        public VeterinaryClinic()
        {
        }

        //constructor con parametros
        public VeterinaryClinic(string name,string address)
        {
            this.Name = name;
            this.Address = address;
        }

        //metodo para agregar un perro a la clinica
        public void SaveDog(Dog newDog){

        }

        //metodo para agregar un gato a la clinica
        public void SaveCat(Cat newCat){

        }

        //metodo para actualizar un perro 
        public void UpdateDog(Dog dog){

        }

        //metodo para actualizar un gato
        public void UpdateCat(Dog dog){

        }

        //eliminar perro
        public void DeleteDog(int id){

        }

        //eliminar gato
        public void DeleteCat(int id){

        }

        //Mostrar todos los pacientes
        public void ShowAllPatients(){

        }

        //Mostrar todos los animales
        public void ShowAnimals(string type){

        }

        //mostrar paciente
        public void ShowPatient(int idPatient){

        }
    }
}