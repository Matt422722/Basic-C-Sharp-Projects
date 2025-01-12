namespace Abstract
{
    // Abstract class Person with two properties and one abstract method
    public abstract class Person
    {
        // Public property to hold the first name
        public string FirstName { get; set; }

        // Public property to hold the last name
        public string LastName { get; set; }

        // Abstract method that must be implemented in derived classes
        public abstract void SayName();
    }
}
