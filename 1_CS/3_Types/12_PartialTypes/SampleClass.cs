// The hand-written part: safe from being overwritten when the generator reruns.
[AnotherAttribute]
partial class SampleClass : IOtherSampleClass
{
    public void MethodTwo()
    {
        Console.WriteLine("MethodTwo (hand-written part)");
    }

    // Optional implementation of the partial method declared in the generated part
    partial void APartialMethod()
    {
        Console.WriteLine("APartialMethod implementation");
    }
}
