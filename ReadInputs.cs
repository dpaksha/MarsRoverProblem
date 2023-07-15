using System;

public class ReadInputs
{
    public static (int, int) ReadPleatueCoordinates()
    {
        Console.WriteLine("Enter the Pleatue's Max and Min coordinates (seperated by space) and press Enter...");
        string pleatueCoordinates = Console.ReadLine();

        string[] pleatueCoordinateArray = pleatueCoordinates.Split(' ');

        int pleatueX = Convert.ToInt32(pleatueCoordinateArray[0].Trim());
        int pleatueY = Convert.ToInt32(pleatueCoordinateArray[1].Trim());

        return (pleatueX, pleatueY);
    }

    public static (char, int, int) ReadRoverCoordinatesAndDirection()
    {
        Console.WriteLine("Enter Rover intial coordinates and direction (seperated by space) and press Enter...");
        string roverPositionAndDirection = Console.ReadLine();

        string[] posAndDirectionArray = roverPositionAndDirection.Split(' ');

        int X = Convert.ToInt32(posAndDirectionArray[0].Trim());
        int Y = Convert.ToInt32(posAndDirectionArray[1].Trim());
        char directionChar = Convert.ToChar(posAndDirectionArray[2].Trim());

        return (directionChar, X, Y);
    }

    public static string ReadRoverInstructions()
    {
        Console.WriteLine("Enter Rover's instructions (no space)");
        string roverInstructions = Console.ReadLine();

        return roverInstructions;
    }
}