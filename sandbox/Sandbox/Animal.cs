public abstract class Animal {

    public string name;
    public Animal(string name) {
        this.name = name;
    }
    public virtual void MakeSound() {
        Console.WriteLine("**Ominous Silence**");
    }
} 