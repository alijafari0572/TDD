﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	public class SalaryCalculator
	{
		public decimal GetAnnnualSalary(decimal hourlyWage)
		{
			const int HourInYear = 2080;
			decimal annualSalary = hourlyWage * HourInYear;
			return annualSalary;
		}
	}
}
