//declare array and initialize it
string[] names = new string[8] { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

//Iterate through each element of the array
foreach (string name in names)
{
    //check if the element starts with B
    if (name.StartsWith("B"))
    {
        //print the element
        Console.WriteLine(name);
    }
}