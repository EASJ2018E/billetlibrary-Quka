using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
	public abstract class Køretøj
	{
		public string Nummerplade { get; set; }
		public DateTime Dato { get; set; }

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
