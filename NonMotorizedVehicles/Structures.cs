using System;
using Enumerations;
using NonMotorizedVehicles;

namespace Structures
{
    public struct Tricycle : INonMotorizedVehicle
    {
        public TerrainType TerrainType { get; set; }
        public int NoOfTires { get; set; }
        public string Brakes { get; set; }
        public bool HasPedals { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public int NoOfWheels { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        TerrainType INonMotorizedVehicle.TerrainType { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public bool Moving()
        {
            throw new System.NotImplementedException();
        }

        public bool Moving(bool isMoving)
        {
            throw new System.NotImplementedException();
        }

        
    }
}
