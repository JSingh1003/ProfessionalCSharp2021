// Primary constructor: firstName and lastName are captured into the readonly fields below
public class Person(string firstName, string lastName)
{
    // readonly field: assigned once at construction, exposed through a get-only property
    private readonly string _firstName = firstName;
    public string FirstName => _firstName;
    private readonly string _lastName = lastName;
    public string LastName => _lastName;

    // Computed property: no backing field, calculated on every access
    public string FullName => $"{FirstName} {LastName}";

    // Full property with a backing field: the only one that can be changed after construction
    private int _age;
    public int Age
    {
        get => _age;
        set
        {
            // Validate before storing: age must be between 0 and 150
            if (value < 0 || value > 150)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, "Age must be between 0 and 150.");
            }
            _age = value;
        }
    }

    // Deconstruct method: lets callers write (var first, var last, var age) = person;
    public void Deconstruct(out string firstName, out string lastName, out int age)
    {
        firstName = FirstName;
        lastName = LastName;
        age = Age;
    }
}