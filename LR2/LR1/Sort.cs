namespace LR1;

public class Sort
{
    public void SortByBreed(List<Animal> animals)
    {
        animals.Sort((a, b) => a.Breed.CompareTo(b.Breed));
    }
    
    public void SortByType(List<Animal> animals)
    {
        animals.Sort((a, b) => a.Type.CompareTo(b.Type));
    }
    public void SortByAge(List<Animal> animals)
    {
        animals.Sort((a, b) => a.Age.CompareTo(b.Age));
    }

    public void SortTypeByTask(List<Animal> animals)
    {
        Action sortByType = () =>
        {
            SortByType(animals);
        };

        Task task = new Task(sortByType);
        task.Start();
        task.Wait();
    }
    public void SortAgeByTask(List<Animal> animals)
    {
        Action sortByAge = () =>
        {
            animals.Sort((a1, a2) => string.Compare(a1.Breed, a2.Breed));
        };

        Task task = new Task(sortByAge);
        task.Start();
        task.Wait();
    }
    public void SortBreedByTask(List<Animal> animals)
    {
        Action sortByBreed = () =>
        {
            SortByBreed(animals);
        };

        Task task = new Task(sortByBreed);
        task.Start();
        task.Wait();
    }

    public void MultiSort(List<Animal> animals)
    {
        Action sortByBreed = () =>
        {
            animals.Sort((a, b) => a.Breed.CompareTo(b.Breed));
        };
        Action sortByAge = () =>
        { animals.Sort((a, b) => a.Age.CompareTo(b.Age)); };
        Action sortByType = () =>
        { animals.Sort((a, b) => a.Type.CompareTo(b.Type)); };
        
        Task task1 = new Task(sortByBreed);
        task1.Start();
        Task task2 = new Task(sortByType);
        Task task3 = new Task(sortByAge);
        task2.Start();
        task3.Start();
        Thread.Sleep(1000); // Призупинити поточний потік на 1 секунду
        Thread.SpinWait(1000000); // Виконати обертання процесора задану кількість разів
        // Чекаємо на завершення всіх завдань
        Task.WaitAll(task1, task2, task3);
    }



}