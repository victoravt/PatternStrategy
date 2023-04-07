using PatternStrategy;

Console.WriteLine("Hello, World!");

///First version only using concrete classes
NormalVersion.Run();

///Second functinal, which is not bloating code with Concrete classes.
FunctionalTypeVersion.Run();