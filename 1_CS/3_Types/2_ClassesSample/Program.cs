// Target-typed new + object initializer: title goes to the constructor, Publisher is set via the init-only property
Book theBook = new("Professional C#")
{
    Publisher = "Wrox Press"
};
Console.WriteLine($"{theBook.Title} - {theBook.Publisher}");

// Create people through the static factory, which also counts them
Person john = PeopleFactory.CreatePerson("John", "Doe");
Person jane = PeopleFactory.CreatePerson("Jane", "Smith");
Console.WriteLine($"{john.FullName}, {jane.FullName}");
Console.WriteLine($"People created by the factory: {PeopleFactory.PersonCount}");

// Create a Person through its primary constructor and read its properties
Person katharina = new("Katharina", "Nagel");
Console.WriteLine($"{katharina.FirstName} {katharina.LastName}");

// Instance method call on a service object
GreetingService service = new();
var greeting = service.Greet(katharina);
Console.WriteLine(greeting);

// deconstruction: calls Person.Deconstruct; the discard (_) ignores the age value

(var first, var last, _) = katharina;
Console.WriteLine($"{first} {last}");
