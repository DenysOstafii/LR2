namespace LR1;

public class RandomData
{
    private static List<string> DogNames = new List<string> { "Buddy", "Max", "Charlie", "Bailey", "Cooper", "Daisy", "Lucy", "Sadie", "Toby", "Molly" };
    private static List<string> DogBreeds = new List<string> { "Labrador Retriever", "German Shepherd", "Beagle", "Yorkshire Terrier", "Siberian Husky", "Bulldog", 
        "Pug", "Jack Russell Terrier", "Collie", "Poodle" };
    private static List<string> DogType = new List<string> { "big", "small", "average" };
    private static List<string> DogPhotos = new List<string>
    {
        "photo3.jpg", "photo32.jpg", "photo35.jpg", "photo13.jpg", "photo23.jpg", "photo43.jpg",
        "photo123.jpg", "photo363.jpg", "photo53.jpg",
        
    };
    private static string GetRandomDogName()
    {
        Random random = new Random();
        int index = random.Next(DogNames.Count);
        return DogNames[index];
    }
    private static string GetRandomDogPhoto()
    {
        Random random = new Random();
        int index = random.Next(DogPhotos.Count);
        return DogPhotos[index];
    }
    private static string GetRandomDogBreed()
         {
             Random random = new Random();
             int index = random.Next(DogBreeds.Count);
             return DogBreeds[index];
         }
    private static string GetRandomDogType()
    {
        Random random = new Random();
        int index = random.Next(DogType.Count);
        return DogType[index];
    }

    public static List<Animal> GenerateRandomData(int size)
    {
        List<Animal> animals = new List<Animal>();
        Random random = new Random();
        for (int i = 0; i < size; ++i)
        {
            Animal animal = new Animal
            {
                Name = GetRandomDogName(),
                Breed = GetRandomDogBreed(),
                Type = GetRandomDogType(),
                Age = random.Next(15),
                Sex = random.Next(2) == 0,
                Photo = GetRandomDogPhoto()
            };
            animals.Add(animal);
        }

        return animals;
    }
    }

