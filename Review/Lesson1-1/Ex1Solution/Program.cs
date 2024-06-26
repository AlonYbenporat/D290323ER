﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Solution {
	internal class Program {
		static void Main(string[] args) {

			double num1 = 0;
			double num2 = 0;

			Console.WriteLine("Please enter the first number:");
			while (!double.TryParse(Console.ReadLine(), out num1)) {
				Console.WriteLine("Invalid value, try again");
			}

			Console.WriteLine("Please enter the second number:");
			while (!double.TryParse(Console.ReadLine(), out num2)) {
				Console.WriteLine("Invalid value, try again");
			}

			Console.WriteLine("Please select the operator to use: (+,-,/,*)");
			bool validOperatorEntered = false;
			string op = "";
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

				/*
				if (op == "+" || op == "add" || op == "1") {
					result = num1 + num2;
					validOperatorEntered = true;
				} else if (op == "-" || op == "sub" || op == "2") {
					result = num1 - num2;
					validOperatorEntered = true;
				} else if (op == "/" || op == "div" || op == "3") {
					if (num2 == 0) {
						Console.WriteLine("Cannot divide by zero, pick a different operation (+,-,*)");
					} else {
						result = num1 / num2;
						validOperatorEntered = true;
					}
				} else if (op == "*" || op == "mul" || op == "4") {
					result = num1 * num2;
					validOperatorEntered = true;
				} else {
					Console.WriteLine("Invalid operator selection, try again");
				}
				*/
			}

			Console.WriteLine("The answer to " + num1 + op + num2 + "=" + result);


			Console.ReadLine();
		}
	}
}
