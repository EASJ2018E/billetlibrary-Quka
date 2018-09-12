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
		public void TestBilKøretøj()
		{
			// Arrange
			Bil b = new Bil();

			// Act
			string køretøj = b.Type();

			// Assert
			Assert.AreEqual("Bil", køretøj);
		}
	}
}
