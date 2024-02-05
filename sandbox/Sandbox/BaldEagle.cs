class BaldEagle : Animal {

    public BaldEagle(string name) : base(name) {

    }

    public override void MakeSound() {
        Console.WriteLine($"{this.name} says: Screeee!");
    }
}