namespace PruebaVeterinaryCenter.models
{
    public class Animal
    {
        protected int Id;
        protected string Name;
        protected DateOnly BirthDate;
        protected string Breed;
        protected string Color;
        protected double WeightnKg;


        //miembros constructor
        public Animal()
        {
            
        }

        public void ShowInformacion(){}

        protected void BasicReview(){

        }

        protected int CalculateAgeInMonths(){
            return 0;
        }
    }
}