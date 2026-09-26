Book2 book2 = new("Professional C#", "Wrox Press");
Console.WriteLine(book2);

Book1 book1a = new() { Title = "Professional C#", Publisher = "Wrox Press" };
Book1 book1b = new() { Title = "Professional C#", Publisher = "Wrox Press" };
if (!object.ReferenceEquals(book1a, book1b)) Console.WriteLine("Two different references for equal records");
if (book1a == book1b) Console.WriteLine("Both records have the same values");

// "with" creates a COPY of the record; only the listed properties change, the original stays untouched
var aNewBook = book1a with { Title = "Professional C# and .NET - 2024" };
Console.WriteLine($"original: {book1a}");
Console.WriteLine($"copy:     {aNewBook}");
Console.WriteLine($"same reference? {ReferenceEquals(book1a, aNewBook)}");   // False
Console.WriteLine($"equal values?   {book1a == aNewBook}");                  // False (Title differs)

// records are compared by value, so a copy with no changes is equal to the original
var exactCopy = book1a with { };
Console.WriteLine($"exact copy equal? {book1a == exactCopy}");               // True

// positional records generate a Deconstruct method
var (title, publisher) = book2;
Console.WriteLine($"deconstructed: {title} / {publisher}");

// record inheritance: Book3 derives from Book2, EqualityContract tells the exact runtime type
Book3 book3 = new("Professional C#", "Wrox Press");
Console.WriteLine(book3);
Console.WriteLine($"book3 contract: {book3.GetContract()}");
Console.WriteLine($"book2 == book3? {book2 == book3}");                     // False: different types

// nominal records - would be init-only properties, but this seems to have changed
//public record Book2 { string Title; string Publisher; }
public record Book1
{
    public string Title { get; init; } = string.Empty;
    public string Publisher { get; init; } = string.Empty;
}

// positional record
public record Book2(string Title, string Publisher);

// implements Equals, ==, != operators, GetHashCode, properties with get/init, Deconstruct

public record Book3(string Title, string Publisher) : Book2(Title, Publisher)
{
    public Type GetContract() => EqualityContract;
}

