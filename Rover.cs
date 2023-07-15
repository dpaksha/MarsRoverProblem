using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public struct Position
    {

        public int X { get; set; }
        public int Y { get; set; }  

    }


    public class Rover
    {

        public Pleatue Pleatue;
         
        public Position CurrentRoverPosition;

        public Direction CurrentDirection { get; set; }

        public Rover() { }

        public Rover(int x, int y, char directionChar)
        {
           

            CurrentRoverPosition.X = x;
            CurrentRoverPosition.Y = y;

            CurrentDirection = Direction.GetDirection(directionChar);  
        }
        public Rover(Position initPos,char directionChar) { 

           

            CurrentRoverPosition= initPos;
           
            CurrentDirection = Direction.GetDirection(directionChar);
        }   
       
        public void Move(string instructionString)
        {
            foreach (char c in instructionString.ToCharArray())
            {
                if (c.Equals('L') || c.Equals('R'))
                {
                    updateDirection(c);
                }
                else 
                {
                    updatePosition();
                }
            }
        }
        private void updatePosition() { 

            switch (CurrentDirection.GetType().Name)
            {
                case "North":
                    if(CurrentRoverPosition.Y >= Pleatue.MinY)
                        CurrentRoverPosition.Y = CurrentRoverPosition.Y+ 1;
                    break;
                case "South":
                    if (CurrentRoverPosition.Y <= Pleatue.MaxY)
                        CurrentRoverPosition.Y = CurrentRoverPosition.Y - 1;
                    break;
                case "East":
                    if (CurrentRoverPosition.X <= Pleatue.MaxX)
                        CurrentRoverPosition.X = CurrentRoverPosition.X + 1;
                    break;
                case "West":
                    if (CurrentRoverPosition.X >= Pleatue.MinX)
                        CurrentRoverPosition.X = CurrentRoverPosition.X - 1;
                    break;
                default:
                    break;

            }
        
        }
        private void updateDirection(char leftorright)
        {
            Direction directionUpdate = CurrentDirection;
            if (leftorright.Equals('L'))
            {
                CurrentDirection = CurrentDirection.Left();
            }
            else
            {
                CurrentDirection = CurrentDirection.Right();
            }
        }

        public void DisplayRoverCoordinates() 
        {
            Console.WriteLine("{0} {1} {2} \n\n", CurrentRoverPosition.X.ToString(), CurrentRoverPosition.Y.ToString(), CurrentDirection.ToString()); 
        }

    }
}
