public class Dog : Animal
{
    private string breed;
    
    public Dog(string breed , string name) : base(name)
    {
        this.breed = breed;
    }

    public string Breed {
        get => breed;
    }
}