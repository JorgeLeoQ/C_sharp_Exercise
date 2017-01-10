using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_Part2
{
    public class HouseMove
    {
        public HouseMove(Location currentLocation)
        {
            CurrentLocation = currentLocation;
        }
        public Location CurrentLocation { get; private set; }

        public Location[] Exits
        {
            get { return CurrentLocation.Exits; }
        }
        public void MoveToANewLocation(Location newLocation)
        {
            CurrentLocation = newLocation;
        }
        public void GoThroughExteriorDoor()
        {
            IHasExteriorDoor hasDoor = CurrentLocation as IHasExteriorDoor;
            if (hasDoor != null)
                MoveToANewLocation(hasDoor.DoorLocation);
            else
                throw new ApplicationException("The location you are in (" + CurrentLocation.Name + ") has no exterior door!");
        }
    }
}
