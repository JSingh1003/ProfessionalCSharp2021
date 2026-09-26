// Static class: can't be instantiated, contains only static members (a factory / utility class)
public static class PeopleFactory
{
    // Static field shared by all callers: counts how many people were created (s_ prefix = static field)
    private static int s_peopleCount;

    // Factory method: creates a Person and keeps track of how many have been created
    public static Person CreatePerson(string firstName, string lastName)
    {
        s_peopleCount++;
        return new Person(firstName, lastName);
    }

    // Read-only static property exposing the counter
    public static int PersonCount => s_peopleCount;
}
