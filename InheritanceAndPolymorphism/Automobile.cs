using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphism
{
    class Automobile : Vehicle
    {
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels { get; }
        public int NumberOfDoors { get; }
        public float WheelSize { get; }

        public Automobile()
        {

        }

        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity,
            string color, double movementSpeed)
        {
            this.numberOfDoors = numberOfDoors;
            this.wheelSize = wheelSize;
            this.numberOfWheels = numberOfWheels;
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }
    }
}
