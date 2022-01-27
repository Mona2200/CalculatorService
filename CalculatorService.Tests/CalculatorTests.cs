// <copyright file="CalculatorTests.cs" company="Alyona">
// Copyright (c) 2022 All Rights Reserved
// </copyright>

namespace CalculatorService.Tests
{
   using NUnit.Framework;

   [TestFixture]
   class CalculatorTests
   {
      [Test]
      public void AdditionalMustReturnCorrectValue()
      {
         var calculator = new Calculator();
         Assert.That(calculator.Additional(50, 50) == 100);
      }

      [Test]
      public void SubtractionMustReturnCorrectValue()
      {
         var calculator = new Calculator();
         Assert.That(calculator.Subtraction(50, 50) == 0);
      }

      [Test]
      public void MiltiplicationMustReturnCorrectValue()
      {
         var calculator = new Calculator();
         Assert.That(calculator.Miltiplication(50, 50) == 2500);
      }

      [Test]
      public void DivisionMustReturnCorrectValue()
      {
         var calculator = new Calculator();
         Assert.That(calculator.Division(50, 50) == 1);
      }

   }
}
