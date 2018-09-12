using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
	public abstract class Køretøj
	{
		private string _nummerplade;

		public string Nummerplade
		{
			get { return _nummerplade; }
			set
			{
				_nummerplade = value.Length < 8 ? value : throw new ArgumentException("Nummerplade must be 7 chars or less");
			}
		}

		public DateTime Dato { get; set; }

		/// <summary>
		/// Get the price of the car
		/// </summary>
		/// <param name="brobizzUsed">
		///	Pass true if brobizz is used for 5% rebate, false if no rebate	
		/// </param>
		/// <returns>Returns a price as a decimal</returns>
		public abstract decimal Pris(bool brobizzUsed);

		/// <summary>
		/// Get the type of the vehicle
		/// </summary>
		/// <returns>Returns a vehicle as a string</returns>
		public abstract string Type();
	}
}
