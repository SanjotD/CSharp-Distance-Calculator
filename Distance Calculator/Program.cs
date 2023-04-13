// Distance Calculator
#nullable disable
Console.Clear();


Console.WriteLine("WELCOME TO THE DISTANCE CALCULATOR!");

//User Inputs (Points) 
    Console.Write("Enter x1 value: ");
    double xOne = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter y1 value: ");
    double yOne = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter x2 value: ");
    double xTwo = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter y2 value: ");
    double yTwo = Convert.ToDouble(Console.ReadLine());

//Process
    double distanceOne = (xTwo - xOne);
    distanceOne = Math.Pow(distanceOne, 2);
    double distanceTwo = (yTwo - yOne);
    distanceTwo = Math.Pow(distanceTwo, 2);

    double finalDistance = Math.Sqrt(distanceOne + distanceTwo);

//Output
Console.WriteLine($"Distance between the two points is {finalDistance}.");
