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

        //creo un nuevo atributo para la validacion de castrados
        public bool isCastrated;


        //miembros constructor
        public Animal(string name, DateOnly birthDate, string breed, string color, double weightInKg, bool isCastrated)
        {
            this.Id = ++currentId; // Incrementa y asigna un nuevo Id único
            this.Name = name;
            this.BirthDate = birthDate;
            this.Breed = breed;
            this.Color = color;
            this.WeightnKg = weightInKg;
            this.isCastrated = isCastrated;
        }

        public void ShowInformacion()
        {
            Console.WriteLine(@$"
            ________________________________________________________________________________
            Id:{Id,-5} Nombre:{Name,-2}, Fecha Nacimiento: {BirthDate},
            Raza: {Breed} , Color: {Color}, Peso : {WeightnKg},");
        }

        protected void BasicReview()
        {
            Console.WriteLine(@$"
            Id:{Id,-5} Nombre:{Name,-2}, Fecha Nacimiento: {BirthDate},
            Raza: {Breed} ,Peso : {WeightnKg},");

        }


        protected int CalculateAgeInMonths()
        {
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

            // Calcula la diferencia en años y meses
            int yearsDifference = currentDate.Year - BirthDate.Year;
            int monthsDifference = currentDate.Month - BirthDate.Month;

            // Ajusta la diferencia en años
            if (monthsDifference < 0)
            {
                yearsDifference--;
                monthsDifference += 12;
            }

            // Calcula la edad total en meses
            int ageInMonths = (yearsDifference * 12) + monthsDifference;

            return ageInMonths;
        }

        public int ReturnId()
        {
            return Id;
        }

        //retornar raza
        public string RetrunBreed()
        {
            return Breed.ToString();
        }

        public void UpdateData(string color, double weightInKg, bool isCastrated){
            this.Color = color;
            this.WeightnKg = weightInKg;
            this.isCastrated = isCastrated;
        }
    }
}

