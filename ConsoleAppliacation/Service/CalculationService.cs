using System;

namespace ConsoleApplication
{
	public class CalculationService
	{
		String CallClassName { get; set; }

		public CalculationService(String _CallClassName)
		{
			CallClassName = _CallClassName;
		}

		public String add(int a, int b)
		{
			int sum = a + b;
			return $"{CallClassName}'s result = {sum}";
		}


	}
}

