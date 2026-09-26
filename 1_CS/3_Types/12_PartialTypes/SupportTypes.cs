class SampleBaseClass { }

interface ISampleClass { }

interface IOtherSampleClass { }

[AttributeUsage(AttributeTargets.Class)]
class CustomAttributeAttribute : Attribute { }

[AttributeUsage(AttributeTargets.Class)]
class AnotherAttributeAttribute : Attribute { }
