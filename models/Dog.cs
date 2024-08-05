namespace PruebaVeterinaryCenter.models
{
    public class Dog : Animal
    {
        //Miembros atributos
        //estado de el animal
        public bool BreedingStatus;
        public string Temperament;
        public string MicrochipNumber;
        public string BarkVolume;
        //tipo de abrigo
        public string CoatType;

        //miembro constructor
        public Dog(string name,DateOnly birthdate,string breed,string color,double weightInKg,bool breedingStatus,string temperament,
        string microchipNumber,string barkVolume,string coatType): base(name,birthdate,breed,color,weightInKg)
        {
        }

//animal castrado
        public void CastrateAnimal(){

        }

//peluqueria
        public void Hairdress(){}

    }
}