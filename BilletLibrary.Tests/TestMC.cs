using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.Tests
{
	[TestClass]
	public class TestMC
	{
		[TestMethod]
		public void TestMCPris()
		{
			// Arrange
			MC mc = new MC();

			// Act
			decimal pris = mc.Pris();

			// Assert
			Assert.AreEqual(125, pris);
		}

		[TestMethod]
		public void TestMCKøretøj()
		{
			// Arrange
			MC mc = new MC();

			// Act
			string køretøj = mc.Køretøj();

			// Assert
			Assert.AreEqual("MC", køretøj);
		}
	}
}
