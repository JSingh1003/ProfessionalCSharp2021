// No access modifier on a top-level class means "internal": visible only inside this assembly
class GreetingService
{
    // Instance method: needs a GreetingService object to be called
    public string Greet(Person person)
    {
        return $"Hello, {person.FirstName}!";
    }
}

