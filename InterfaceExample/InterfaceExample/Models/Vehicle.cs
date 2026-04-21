
namespace InterfaceExample.Models
{
    internal abstract class Vehicle
    {
		private string _factoryName;

		public string FactoryName
		{
			get { return _factoryName; }
			set {
				value = value.Trim();
				if (value.Length>0)
				{
					_factoryName= value;
				}

			}
		}

        public string Model { get; set; }
        public string Color { get; set; }

        public double DrivePath { get; set; }
        public double DriveTime { get; set; }


		public void AverageSpeed()
		{
            Console.WriteLine(DrivePath/DriveTime);
        }

		public virtual void GetInfo()
		{
            Console.WriteLine($"{FactoryName} {Model} {Color} {DriveTime} {DrivePath}");
        }

        public override string ToString()
        {
			base.ToString();
            return $"{FactoryName} {Model}";
        }

		public abstract void DefineNatureHarmness();


    }
}
