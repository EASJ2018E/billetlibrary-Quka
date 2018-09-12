using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilletLibrary.Tests
{
	[TestClass]
	public class TestBil
	{
		[TestMethod]
		public void TestBilPris()
		{
			// Arrange
			Bil b = new Bil();

			// Act
			decimal pris = b.Pris();

			// Assert
			Assert.AreEqual(240, pris);
		}

		[TestMethod]
		public void TestBilK�ret�j()
		{
			// Arrange
			Bil b = new Bil();

			// Act
			string k�ret�j = b.Type();

			// Assert
			Assert.AreEqual("Bil", k�ret�j);
		}

		[TestMethod]
		public void TestBilNummerplade()
		{
			// Arrange
			Bil b = new Bil();

			// Act
			b.Nummerplade = "1234567"; // 8 chars (must be 7)

			// Assert
			Assert.AreEqual("1234567", b.Nummerplade);
		}


		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestBilNummerpladeLengthException()
		{
			// Arrange
			Bil b = new Bil();

			// Act
			b.Nummerplade = "12341234"; // 8 chars (must be 7)

			// Assert
			Assert.Fail();
		}
	}
}
