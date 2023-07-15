using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
   
    internal class Program
    {
        static void Main(string[] args)
        {

            (int pleatueX, int pleatueY) = ReadInputs.ReadPleatueCoordinates();
            Pleatue P=new Pleatue(pleatueX, pleatueY);

            bool keepRunning = true;
            while (keepRunning)
            {
               (char direction,int X, int Y) = ReadInputs.ReadRoverCoordinatesAndDirection();

                string roverInstructions = ReadInputs.ReadRoverInstructions();
                Rover rover= new Rover(X,Y,direction);

                rover.Pleatue= P;
                
                rover.Move(roverInstructions);
                rover.DisplayRoverCoordinates();
                
            }


        }      
        
    }
}
    