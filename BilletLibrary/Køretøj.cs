using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
	public abstract class Køretøj
	{
		private string _nummerplade;

		/// <summary>
		/// The serialnr. of this vehicle
		/// </summary>
		public string Nummerplade
		{
			get { return _nummerplade; }
			set
			{
				_nummerplade = value.Length < 8 ? value : throw new ArgumentException("Nummerplade must be 7 chars or less");
			}
		}

		/// <summary>
		/// The date of when this vehicle has passed a/any bridge or passing
		/// </summary>
		public DateTime Dato { get; set; }
		
		/// <summary>
		/// Is true if this vehicle has used brobizz, false if not
		/// </summary>
		public bool Brobizz { get; set; }

		/// <summary>
		/// Get the price of the car
		/// </summary>
		/// <returns>Returns a price as a decimal</returns>
		public abstract decimal Pris();

		/// <summary>
		/// Get the type of the vehicle
		/// </summary>
		/// <returns>Returns a vehicle as a string</returns>
		public abstract string Type();
	}
}
