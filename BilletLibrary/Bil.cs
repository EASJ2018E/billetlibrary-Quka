using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
	/// <summary>
	/// Creates a Bil object with price and vehicle type information
	/// </summary>
	public class Bil
	{
		public string Nummerplade { get; set; }
		public DateTime Dato { get; set; }

		/// <summary>
		/// Get the price of the car
		/// </summary>
		/// <returns>Returns 240 as a decimal</returns>
		public decimal Pris()
		{
			return 240;
		}

		/// <summary>
		/// Get the type of the vehicle
		/// </summary>
		/// <returns>Returns Bil as a string</returns>
		public string Køretøj()
		{
			return "Bil";
		}
	}
}
