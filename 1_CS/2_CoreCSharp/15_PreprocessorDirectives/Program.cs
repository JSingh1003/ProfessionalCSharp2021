// #define / #undef must appear before any other tokens in the file (even before "using").
#define MYSYMBOL
#undef MYSYMBOL2
#define ENTERPRISE
#define W10

using System;

// #if / #elif / #else / #endif ------------------------------------------
#if MYSYMBOL
Console.WriteLine("MYSYMBOL is defined.");
#else
Console.WriteLine("MYSYMBOL is not defined.");
#endif

#if MYSYMBOL2
Console.WriteLine("MYSYMBOL2 is defined.");
#else
Console.WriteLine("MYSYMBOL2 is not defined (it was removed with #undef).");
#endif

// DEBUG is defined automatically by a Debug build, RELEASE by a Release build.
#if DEBUG
Console.WriteLine("Built with the Debug configuration (DEBUG symbol set by the compiler).");
#elif RELEASE
Console.WriteLine("Built with the Release configuration (RELEASE symbol set by the compiler).");
#else
Console.WriteLine("Neither DEBUG nor RELEASE is defined.");
#endif

// Nested #if blocks and logical operators (!, ==, !=, &&, ||) ------------
#if ENTERPRISE
Console.WriteLine("Enterprise edition.");
#if W10
Console.WriteLine("  ...with the Windows 10 specific code path.");
#endif
#elif PROFESSIONAL
Console.WriteLine("Professional edition.");
#else
Console.WriteLine("Lean edition.");
#endif

#if W10 && !ENTERPRISE
Console.WriteLine("This line is skipped because ENTERPRISE is also defined.");
#endif

// #error would abort compilation - guarded so it never actually triggers here.
#if DEBUG && RELEASE
#error "You've defined DEBUG and RELEASE simultaneously!"
#endif

// #warning shows a compiler warning without stopping the build.
#warning "Preprocessor directives sample: remove this reminder before shipping."

// #region / #endregion group code for editors like Visual Studio; the
// compiler itself ignores them. Prefer short files over relying on regions.
#region Member-like local declarations
int x = 1;
double d = 2.0;
decimal balance = 100.00m;
Console.WriteLine($"x={x}, d={d}, balance={balance}");
#endregion

// #line changes the file/line numbers the compiler reports in
// warnings and errors - rarely needed, mostly for generated code:
// #line 164 "Core.cs"
// ... code that should be reported as if it came from Core.cs line 164 ...
// #line default

PragmaSample.Run();

// #nullable enable/disable/restore toggles nullable reference types
// for a section of the file, independent of the project setting.
#nullable disable
string nullableDisabledExample = null; // allowed here even though the project enables nullable reference types
#nullable restore
Console.WriteLine($"nullableDisabledExample is null: {nullableDisabledExample is null}");

class PragmaSample
{
    // #pragma warning disable/restore suppresses specific compiler warnings
    // for just the code between the two directives.
#pragma warning disable CS0169
    private int _neverUsedField;
#pragma warning restore CS0169

    public static void Run() => Console.WriteLine("PragmaSample.Run() executed.");
}
