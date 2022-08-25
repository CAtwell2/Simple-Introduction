Console.WriteLine("What is your first name?");
string firstName = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("What is your last name?");
string lastName = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("How old are you?");
string age = Console.ReadLine();
Console.WriteLine();
string firstnameinitial = firstName.Substring(0, 1);
string lastnameinitial = lastName.Substring(0, 1);
Console.WriteLine($"Hello {firstName} {lastName}! Your initials {firstnameinitial}.{lastnameinitial}., and you are {age}");

