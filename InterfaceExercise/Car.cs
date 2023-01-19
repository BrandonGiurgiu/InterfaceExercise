using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
	{
		public Car()
		{
		}

        double IVehicle.EngineSize { get; set; } = 4.6;
        string IVehicle.Make { get; set; } = "Ford";
        string IVehicle.Model { get; set; } = "Mustang";
        int IVehicle.SeatCount { get; set; } = 4;
        string ICompany.CompanyName { get; set; } = "Ford";
        string ICompany.Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward");
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

        public void ChangeGears (bool isChanged)
        {
            HasChangedGears = isChanged;
        }

 
    }
}

