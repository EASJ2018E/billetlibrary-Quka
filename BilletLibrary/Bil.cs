using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
	/// <summary>
	/// Creates a Bil object with price and vehicle type information
	/// </summary>
	public class Bil : Køretøj
	{
		/// <summary>
		/// Get the price of the car
		/// </summary>
		/// <returns>Returns 240 as a decimal</returns>
		public override decimal Pris()
		{
			int price = 240;

			return Brobizz ? price * 0.95m : price;
		}

		/// <summary>
		/// Get the type of the vehicle
		/// </summary>
		/// <returns>Returns Bil as a string</returns>
		public override string Type()
		{
			return "Bil";
		}
	}
}
