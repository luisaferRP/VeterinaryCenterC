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
        public Dog(string name,DateOnly birthdate,string breed,string color,double weightInKg,bool isCastrated,bool breedingStatus,string temperament,
        string microchipNumber,string barkVolume,string coatType): base(name,birthdate,breed,color,weightInKg,isCastrated)
        {
            this.BreedingStatus = breedingStatus;
            this.Temperament = temperament;
            this.MicrochipNumber = microchipNumber;
            this.BarkVolume = barkVolume;
            this.CoatType = coatType;
        }

//animal castrado
        public void CastrateAnimal(){

        }

//peluqueria
        public void Hairdress(){}

        public void ShowInformacionDog(){
            base.ShowInformacion(); 
            Console.WriteLine(@$"
            Estado de reproducción: {BreedingStatus}, Temperamento: {Temperament}, 
            Numero de microchip: {MicrochipNumber},
            Volumen del ruido de ladrar: {BarkVolume} , Tipo de pelo: {CoatType}
            ________________________________________________________");
        }

    }
}