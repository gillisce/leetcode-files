// Design a parking system for a parking lot. The parking lot has three kinds of parking spaces: big, medium, and small, with a fixed number of slots for each size.
// Implement the ParkingSystem class:
// ParkingSystem(int big, int medium, int small) Initializes object of the ParkingSystem class. The number of slots for each parking space are given as part of the constructor.
// bool addCar(int carType) Checks whether there is a parking space of carType for the car that wants to get into the parking lot. carType can be of three kinds: big, medium, or small, which are represented by 1, 2, and 3 respectively. A car can only park in a parking space of its carType. If there is no space available, return false, else park the car in that size space and return true.

///Test Case
//  ["ParkingSystem","addCar","addCar","addCar","addCar"]
// [[1,1,0],[1],[2],[3],[1]]
namespace leetcode.designs
{
    public class ParkingSystem
    {

        private int _big;
        private int _medium;
        private int _small;

        public ParkingSystem(int big, int medium, int small)
        {
            _big = big;
            _medium = medium;
            _small = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    return (_big)-- > 0;
                case 2:
                    return (_medium)-- > 0;
                case 3:
                    return (_small)-- > 0;
                default:
                    return false;
            }

        }
    }
}


/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */