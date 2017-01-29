using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        public string planeNumber = "";
        public int bookedFirstClassSeats = 0;
        public int availableFirstClassSeats = 0;
        public int totalFirstClassSeats = 0;

        public int bookedCoachSeats = 0;
        public int availableCoachSeats = 0;
        public int totalCoachSeats = 0;

        //Constructor accepts three prams to initiallize the object
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            this.planeNumber = planeNumber;
            this.totalFirstClassSeats = totalFirstClassSeats;
            this.availableFirstClassSeats = totalFirstClassSeats;
            this.totalCoachSeats = totalCoachSeats;
            this.availableCoachSeats = totalCoachSeats;
        }

        // public property to return value of private property
        public string PlaneNumber
        {
            get { return planeNumber; }
        }
        public int BookedFirstClassSeats
        {
            get { return bookedFirstClassSeats; }
        }

        public int AvailableFirstClassSeats
        {
            get
            {
                return availableFirstClassSeats;
            }
        }
        public int TotalFirstClassSeats
        {
            get { return totalFirstClassSeats; }
        }
        public int BookedCoachSeats
        {
            get { return bookedCoachSeats; }
        }
        public int AvailableCoachSeats
        {
            get
            {
                return availableCoachSeats;
            }
        }
        public int TotalCoachSeats
        {
            get { return totalCoachSeats; }
        }
        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass)
            {
                if (totalFirstClassSeats > totalNumberOfSeats)
                {
                    bookedFirstClassSeats += totalNumberOfSeats;
                    availableFirstClassSeats -= totalNumberOfSeats;
                    totalFirstClassSeats -= totalNumberOfSeats;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (totalCoachSeats > totalNumberOfSeats)
                {
                    bookedCoachSeats += totalNumberOfSeats;
                    availableCoachSeats -= totalNumberOfSeats;
                    return true;
                }
                else
                {
                    return false;
                }
                
            }


        }
    }
}
