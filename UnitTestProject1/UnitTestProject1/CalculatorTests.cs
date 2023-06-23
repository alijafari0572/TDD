using System;
using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatorTestProject
{
	[TestClass]
	public class CalculatorTests
	{
		[TestMethod]
		public void AnnualSalaryTest()
		{
			//Arrange
			SalaryCalculator sc = new SalaryCalculator();

			//Act
			decimal annualSalary = sc.GetAnnnualSalary(50);

			//Assert
			Assert.AreEqual(104000, annualSalary);
		}
	}
}