namespace EmployeeEqualityCheck
{
    // Define the Employee class
    public class Employee
    {
        // Define properties for Employee
        public int Id { get; set; } // Employee ID
        public string FirstName { get; set; } // Employee first name
        public string LastName { get; set; } // Employee last name

        // Overload the "==" operator
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null, or if either is null
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return ReferenceEquals(emp1, emp2);

            // Compare the Id properties for equality
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator (must be paired with "==")
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Use the negation of the "==" operator to determine inequality
            return !(emp1 == emp2);
        }

        // Override Equals() for consistency with the "==" operator
        public override bool Equals(object obj)
        {
            // Check if the other object is an Employee and compare Id
            return obj is Employee employee && this.Id == employee.Id;
        }

        // Override GetHashCode() because Equals() was overridden
        public override int GetHashCode()
        {
            // Use the Id property to generate a hash code
            return Id.GetHashCode();
        }
    }
}