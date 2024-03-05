namespace GenericAnimalClass
{
    public class Animal <T>
    {
        public T data;
        public Animal(T data)
        {
            this.data = data;
        }
        public T getAnimal()
        {
            return data;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // setting animal properties
            Animal<string> animalName = new Animal<string>("Toucan");
            Animal<string> animalHabitat = new Animal<string>("Canopies of Central and South American rain forests");
            Animal<bool> endangered = new Animal<bool>(false);
            Animal<bool> extinct = new Animal<bool>(false);
            Animal<int> averageLifespan = new Animal<int>(16);
            // display animal information
            Console.WriteLine("Name: " + animalName.getAnimal());
            Console.WriteLine("Habitat: " + animalHabitat.getAnimal());
            Console.WriteLine("Endangered: " + endangered.getAnimal());
            Console.WriteLine("Extinct: " + extinct.getAnimal());
            Console.WriteLine("Average Lifespan: " + averageLifespan.getAnimal() + " years");
        }
    }
}
