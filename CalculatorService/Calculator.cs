// <copyright file="Calculator.cs" company="Alyona">
// Copyright (c) 2022 All Rights Reserved
// </copyright>

namespace CalculatorService
{
   /// <summary>
   /// Calculator Class.
   /// </summary>
   public class Calculator
   {
      /// <summary>
      /// Additional Method.
      /// </summary>
      /// <returns>Additional two numbers.</returns>
      public int Additional(int a, int b)
      {
         return a + b;
      }

      /// <summary>
      /// Subtraction Method.
      /// </summary>
      /// <returns>Subtraction two numbers.</returns>
      public int Subtraction(int a, int b)
      {
         return a - b;
      }

      /// <summary>
      /// Miltiplication Method.
      /// </summary>
      /// <returns>Miltiplication two numbers.</returns>
      public int Miltiplication(int a, int b)
      {
         return a * b;
      }

      /// <summary>
      /// Division Method.
      /// </summary>
      /// <returns>Division two numbers.</returns>
      public int Division(int a, int b)
      {
         return a / b;
      }

   }
}
