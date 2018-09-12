using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
	/// <summary>
	/// Creates an MC object with price and vehicle type information
	/// </summary>
	public class MC : Køretøj
	{
		/// <summary>
		/// Get the price of the MC
		/// </summary>
		/// <returns>Returns 125 as a decimal</returns>
		public override decimal Pris()
		{
			return 125;
		}

		/// <summary>
		/// Get the type of the vehicle
		/// </summary>
		/// <returns>Returns MC as a string</returns>
		public override string Type()
		{
			return "MC";
		}
	}
}
