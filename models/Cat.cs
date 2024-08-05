namespace PruebaVeterinaryCenter.models
{
    public class Cat : Animal
    {
        //miembros atributos
        public bool BreedingStatus;

        //longitud del pelo
        public string FurLength;

        //miembro constructor
        public Cat(string name,DateOnly birthdate,string breed,string color,double weightInKg,bool breedingStatus,string furLength):base(name,birthdate,breed,color,weightInKg)
        {
            this.BreedingStatus = breedingStatus;
            this.FurLength = furLength;
        }

        //miembros metodos
        public void CastrateAnimal(){

        }

        //peluqueria
        public void Hairdress(){}


        public void ShowInformacionCat(){
            base.ShowInformacion(); 
            Console.WriteLine(@$"
            Estado de reproducción: {BreedingStatus}, Tipo de pelo: {FurLength}
            ________________________________________________________");
        }
        
    }
}