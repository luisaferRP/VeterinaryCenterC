using System.Data;
using System.Runtime.Serialization;

namespace PruebaVeterinaryCenter.models
{
    public class Animal
    {
        private static int currentId = 0; // mantener el último Id generado
        protected int Id;
        protected string Name;
        protected DateOnly BirthDate;
        protected string Breed;
        protected string Color;
        protected double WeightnKg;


        //miembros constructor
        public Animal(string name,DateOnly birthDate,string breed,string color,double weightInKg)
        {
            this.Id = ++currentId; // Incrementa y asigna un nuevo Id único
            this.Name = name;
            this.BirthDate = birthDate;
            this.Breed = breed;
            this.Color = color;
            this.WeightnKg = weightInKg;
        }

        public void ShowInformacion(){
            Console.WriteLine(@$"
            ________________________________________________________
            Id:{Id} Nombre:{Name}, Fecha Nacimiento: {BirthDate},
            Raza: {Breed} , Color: {Color}, Peso : {WeightnKg},");
        }

        protected void BasicReview(){

        }

        protected int CalculateAgeInMonths(){
            return 0;
        }

        public int ReturnId(){
            return Id;
        }

        //retornar raza
        public string RetrunBreed(){
            return Breed.ToString();
        }
    }
}

