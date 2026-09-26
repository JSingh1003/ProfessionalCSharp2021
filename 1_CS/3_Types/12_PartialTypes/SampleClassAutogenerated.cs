// Simulates the part of the class that a code generator would (re)create.
[CustomAttribute]
partial class SampleClass : SampleBaseClass, ISampleClass
{
    public void MethodOne()
    {
        Console.WriteLine("MethodOne (generated part)");
        APartialMethod();
    }

    // Partial method declaration: the implementation is optional.
    // If no part implements it, the compiler removes the call above.
    partial void APartialMethod();
}
