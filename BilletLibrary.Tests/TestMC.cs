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
			string køretøj = mc.Type();

			// Assert
			Assert.AreEqual("MC", køretøj);
		}

		[TestMethod]
		public void TestMCNummerplade()
		{
			// Arrange
			MC mc = new MC();

			// Act
			mc.Nummerplade = "1234567"; // 8 chars (must be 7)

			// Assert
			Assert.AreEqual("1234567", mc.Nummerplade);
		}


		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestMCNummerpladeLengthException()
		{
			// Arrange
			MC mc = new MC();

			// Act
			mc.Nummerplade = "12341234"; // 8 chars (must be 7)

			// Assert
			Assert.Fail();
		}
	}
}
