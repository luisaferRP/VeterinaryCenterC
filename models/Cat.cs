namespace PruebaVeterinaryCenter.models
{
    public class Cat : Animal
    {
        //miembros atributos
        public bool BreedingStatus;

        //longitud del pelo
        public string FurLength;

        //miembro constructor
        public Cat(string name,DateOnly birthdate,string breed,string color,double weightInKg,bool isCastrated,bool breedingStatus,string furLength):base(name,birthdate,breed,color,weightInKg,isCastrated)
        {
            this.BreedingStatus = breedingStatus;
            this.FurLength = furLength;
        }

        //miembros metodos
        public void CastrateAnimal(){
            Console.WriteLine("Verificación de castración...");

            Console.Write("Ingrese el id del animal que desea castrar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var seeAnimal = new VeterinaryClinic();
            seeAnimal.ValidationCastrateAnimal(id);

        }

        //peluqueria
        public void Hairdress(){
            if (FurLength == "pelo corto")
            {
                Console.Write("El pelaje de el gato es muy corto, recomendació: solo cortar puntas.");
            }else if(FurLength == "pelo mediano")
            {
                Console.WriteLine("El pelaje de el gato es mediano,te recomiendo cortes basicos.");
            }else if(FurLength == "pelo largo")
            {
                Console.WriteLine("El pelaje de el gato es largo,puedes hacer cualquier tipo de corte.");
            }else{
                Console.WriteLine("El pelaje del gato es sin pelo,no es posible peluquear.");
            }
        }


        public void ShowInformacionCat(){
            base.ShowInformacion(); 
            Console.WriteLine(@$"
            Estado de reproducción: {BreedingStatus}, Tipo de pelo: {FurLength},
            Años en meses: {CalculateAgeInMonths()}
            ________________________________________________________________________________");
        }
        
    }
}