using System.Numerics;

// Converting a primitive type to a string uses a method on the underlying .NET struct
int i = 42;
string s = i.ToString();
Console.WriteLine($"int {i} as string: \"{s}\"");

// Integer Types --------------------------------------------------------
byte b = 255;                 // 0 to 255
sbyte sb = -128;               // -128 to 127
short sh = -32_768;            // -32,768 to 32,767
ushort ush = 65_535;           // 0 to 65,535
int n = -2_147_483_648;        // 32-bit signed
uint un = 4_294_967_295;       // 32-bit unsigned
long l = -9_223_372_036_854_775_808; // 64-bit signed
ulong ul = 18_446_744_073_709_551_615; // 64-bit unsigned

Console.WriteLine($"b: {b}, sb: {sb}, sh: {sh}, ush: {ush}, n: {n}, un: {un}, l: {l}, ul: {ul}");
Console.WriteLine($"byte range: {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"sbyte range: {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short range: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int range: {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long range: {long.MinValue} to {long.MaxValue}");

// Big Integer ------------------------------------------------------------
BigInteger big = BigInteger.Pow(2, 128);
Console.WriteLine($"2^128 as BigInteger: {big}");
Console.WriteLine($"BigInteger + 1: {BigInteger.Add(big, 1)}");

// Native Integer Types -----------------------------------------------------
nint native = 42;   // 32 bits on a 32-bit process, 64 bits on a 64-bit process
nuint unative = 42;
Console.WriteLine($"native: {native}, unative: {unative}, nint size on this process: {nint.Size} bytes");

// Digit Separators ---------------------------------------------------------
long l1 = 0x_123_4567_89ab_cedf;
long l2 = 0x123456789abcedf;   // same value, without separators
Console.WriteLine($"l1 == l2: {l1 == l2}");

// Binary Values --------------------------------------------------------
uint binary1 = 0b_1111_1110_1101_1100_1011_1010_1001_1000;
uint hex1 = 0xfedcba98;
Console.WriteLine($"binary1 == hex1: {binary1 == hex1}");

uint binary2 = 0b_111_110_101_100_011_010_001_000; // grouped by 3 bits (octal)
ushort binary3 = 0b1111_0000_101010_11;             // grouped per protocol layout
Console.WriteLine($"binary2: {binary2}, binary3: {binary3}");

// Floating-Point Types ---------------------------------------------------
Half half = (Half)12.3;
float f = 12.3F;
double d = 12.3;
decimal m = 12.30M;

Console.WriteLine($"Half: {half}, float: {f}, double: {d}, decimal: {m}");

// The Boolean Type -----------------------------------------------------
bool flag = true;
Console.WriteLine($"flag: {flag}");
// bool wrong = 0; // compile error - no implicit conversion from int to bool

// The Character Type ----------------------------------------------------
char c1 = 'A';
char c2 = 'A';   // hex Unicode value
char c3 = (char)65;   // cast from int
char c4 = '\x0041';   // hexadecimal value
char newline = '\n';
char tab = '\t';
Console.WriteLine($"c1 == c2 == c3 == c4: {c1 == c2 && c2 == c3 && c3 == c4}");
Console.WriteLine($"escape sequences -- newline code: {(int)newline}, tab code: {(int)tab}");

// The object Type --------------------------------------------------------
object obj = 42;
Console.WriteLine($"obj.GetType(): {obj.GetType()}");
Console.WriteLine($"obj.ToString(): {obj.ToString()}");
Console.WriteLine($"obj.Equals(42): {obj.Equals(42)}");
