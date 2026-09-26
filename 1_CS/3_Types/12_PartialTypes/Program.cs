// Both parts are compiled into ONE type with both methods
SampleClass sample = new();
sample.MethodOne();
sample.MethodTwo();

// Base class, interfaces and attributes of all the parts are combined
Console.WriteLine($"base class: {typeof(SampleClass).BaseType}");
Console.WriteLine($"is ISampleClass: {sample is ISampleClass}");
Console.WriteLine($"is IOtherSampleClass: {sample is IOtherSampleClass}");
foreach (var attribute in typeof(SampleClass).GetCustomAttributes(false))
{
    Console.WriteLine($"attribute: {attribute.GetType().Name}");
}
