using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public double EngineSize { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
		public int SeatCount { get; set; }
		public bool HasChangedGears { get; set; }

		public void Drive();
		public void Reverse();
		public void Park();
		public void ChangeGears (bool isChanged);
	}
}

