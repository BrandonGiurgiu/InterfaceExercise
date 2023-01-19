using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
    {
		public Truck()
		{
		}

        double IVehicle.EngineSize { get; set; } = 6;
        string IVehicle.Make { get; set; } = "Ford";
        string IVehicle.Model { get; set; } = "F150";
        int IVehicle.SeatCount { get; set; } = 4;
        string ICompany.CompanyName { get; set; } = "Ford";
        string ICompany.Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }

        public bool HasFourWheelDrive { get; set; } = true;

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4x4 Drive {GetType().Name} now driving forward");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward");
            }
        }

        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
        }

        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears");
            }
        }

        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

        
    }
}

