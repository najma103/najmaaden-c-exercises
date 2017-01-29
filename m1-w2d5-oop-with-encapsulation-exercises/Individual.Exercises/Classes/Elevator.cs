using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Elevator
    {
        public int currentLevel;
        public int numberOfLevels;
        public bool doorIsOpen;

        public Elevator(int totalNumberOffloors)
        {
            numberOfLevels = totalNumberOffloors;
            currentLevel = 1;
            doorIsOpen = false; 
            
        }

        public int CurrentLevel
        {
            get { return currentLevel; }
        }
        public int NumberOfLevels
        {
            get { return numberOfLevels; }
        }

        public bool DoorIsOpen
        {
            get { return doorIsOpen; }
        }

        // methods to open and cloos elevator door
        public void OpenDoor()
        {
            doorIsOpen = true;
        }

        public void CloseDoor()
        {
            doorIsOpen = false; 
        }

        public void GoUp(int desiredFloor)
        {
            if (!doorIsOpen)
            {
                if (desiredFloor > currentLevel && desiredFloor < numberOfLevels)
                {
                    currentLevel = desiredFloor;
                }
                else
                {
                    currentLevel = numberOfLevels;
                }

            }


        }
        public void GoDown (int desiredFloor)
        {
            if (!doorIsOpen)
            {
                if (desiredFloor > 0 && desiredFloor < currentLevel)
                {
                    currentLevel = desiredFloor;
                }
            }
            
        }
       
        
    }

}
