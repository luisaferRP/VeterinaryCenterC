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
        public static void CastrateAnimal()
        {
            Console.WriteLine("Verificación de castración...");

            Console.Write("Ingrese el id del animal que desea castrar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var seeAnimal = new VeterinaryClinic();
            seeAnimal.ValidationCastrateAnimal(id);
        }
        

        //peluqueria
        public void Hairdress(){
            if (CoatType == "pelo corto")
            {
                Console.Write("EL pelaje de el perro es muy corto para ser peluqueado");
            }else if(CoatType == "pelo mediano")
            {
                Console.WriteLine("El pelaje de el perro es mediano,te recomiendo cortes de puntas");
            }else if(CoatType == "pelo largo")
            {
                Console.WriteLine("El pelaje de el perro es largo,puedes hacer cualquier tipo de corte");
            }else{
                Console.WriteLine("EL pelaje del perro es sin pelo,no es posible peluquear");
            }
        }

        public void ShowInformacionDog(){
            base.ShowInformacion(); 
            Console.WriteLine(@$"
            Temperamento: {Temperament}, Tipo de pelo: {CoatType}
            Estado de reproducción: {BreedingStatus},
            Numero de microchip: {MicrochipNumber},
            Volumen del ruido de ladrar: {BarkVolume} 
            Años en meses: {CalculateAgeInMonths()}
            ________________________________________________________________________________");
        }

    }
}