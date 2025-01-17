class Person
{
    public string Name { get; }
    public int Age { get; }

    // Primary constructor that takes both name and age
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Secondary constructor that only takes a name and assigns a default age
    public Person(string name) : this(name, 18) // Chaining to the main constructor
    {
        // This constructor calls the primary constructor, setting a default age of 18
    }
}
