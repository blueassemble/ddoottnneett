int fahrenheit = 94;
decimal celsius = (fahrenheit - 32) * 5 / 9;

//wirteline celsius
Console.WriteLine("The temperature is " + celsius + " Celsius.");

//get user input for farhenheit one line
Console.Write("Enter a temperature in Fahrenheit: " );
fahrenheit = Convert.ToInt32(Console.ReadLine());

//convert fahrenheit to celsius
celsius = (fahrenheit - 32) * 5 / 9;

//wirteline celsius
Console.WriteLine("The temperature is " + celsius + " Celsius.");