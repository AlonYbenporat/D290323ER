﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods {
	internal class Program {
		static void Main(string[] args) {
			/*Console.WriteLine("Hello World");

			string m = "message 1";

			PrintAMessage(m);
			PrintAMessage("Simon is cool!");
			PrintAMessage(m + "-2");
			PrintAMessage(DateTime.Now.ToString());

			int result = AddTwoNumbers(2, 5);

			Console.WriteLine("result is " + result);
			*/

			int num = 5;
			Increment(ref num, 2);
			Increment(ref num, 4);

			/*
			 * Write a method called "DoubleIt"
			 * That takes an int value asa reference parameter and doubles it (no return)
			 * call the method 3 times each time printing the value of the variable
			 *
			 */
			/*
			int num2 = 10;
			DoubleIt(ref num2);
			Console.WriteLine(num2);
			DoubleIt(ref num2);
			Console.WriteLine(num2);
			DoubleIt(ref num2);
			Console.WriteLine(num2);
			*/

			/*
			int a = 5;
			int b = 10;
			string op = "STUFF";
			bool validOperatorEntered = false;
			double result = CalculateResult(a, b, out op, out validOperatorEntered);
			*/


			/*
			 * Write a method called "SqrIt" that takes a parameter and returns the
			 * result as an out parameter. print the result.
			 */

			int num3 = 2;
			int res;
			SqrIt(num3, out res);
			Console.WriteLine(res);

			Console.ReadKey();
		}


		static void PrintAMessage(string msg) {
			//string message = "Hello World from my method!";
			Console.WriteLine("The message i got is: " + msg);
		}

		static int AddTwoNumbers(int num1, int num2) {
			int sum = num1 + num2;
			Console.WriteLine("calculated the value");
			return sum;
		}

		static void Increment(ref int value, int by) {
			value = value + by;
		}

		static void DoubleIt(ref int value) {
			value = value * 2;
		}

		static void SqrIt(int value, out int result) {
			result = value * value;
		}

		static double CalculateResult(int num1, int num2, out string op, out bool validOperatorEntered) {
			Console.WriteLine("Please select the operator to use: (+,-,/,*)");
			validOperatorEntered = false;
			op = "";
			double result = 0;
			while (!validOperatorEntered) {
				op = Console.ReadLine();

				switch (op) {
					case "add":
					case "1":
					case "sum":
					case "+":
						result = num1 + num2;
						validOperatorEntered = true;
						op = "+";
						break;
					case "-":
					case "sub":
					case "2":
						result = num1 - num2;
						validOperatorEntered = true;
						op = "-";
						break;
					case "/":
					case "div":
					case "3":
						if (num2 == 0) {
							Console.WriteLine("Cannot divide by zero, pick a different operation (+,-,*)");
						} else {
							result = num1 / num2;
							validOperatorEntered = true;
							op = "/";
						}
						break;
					case "*":
					case "mul":
					case "4":
						result = num1 * num2;
						validOperatorEntered = true;
						op = "*";
						break;
					default:
						Console.WriteLine("Invalid operator selection, try again");
						break;
				}

			}

			return result;
		}
	}
}
