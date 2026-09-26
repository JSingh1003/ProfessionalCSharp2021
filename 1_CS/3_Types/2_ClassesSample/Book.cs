
// C# 12 primary constructor: "title" is a constructor parameter declared right on the class
public class Book(string title)
{
    // init-only property: can be set in the constructor or in an object initializer, then it's read-only
    public string Title { get; init; } = title;

    // nullable reference type: a book might not have a publisher
    public string? Publisher { get; init; }
}
