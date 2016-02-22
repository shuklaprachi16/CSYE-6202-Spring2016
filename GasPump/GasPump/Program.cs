using System;

namespace GasPump
{
	public class Program
	{
		public enum GasType
		{
			None,
			RegularGas,
			MidgradeGas,
			PremiumGas,
			DieselFuel				
		}

		static void Main(string[] args)
		{
            // your implementation here
            string gasType = "";
            string gasAmount = "";
            Console.Write("Please enter gas type, Q/q to quit :");
            gasType = Console.ReadLine();



            if (UserEnteredSentinelValue(gasType))
            {
                Console.WriteLine("exit ");

            }
            else
            {
                if (UserEnteredValidGasType(gasType))
                {

                    Console.Write("Please enter gas Amount, Q/q to quit :");
                    gasAmount = Console.ReadLine();

                    if (UserEnteredSentinelValue(gasAmount))
                    {
                        Console.WriteLine("Exit ");

                        return;
                    }

                    if (UserEnteredValidAmount(gasAmount))
                    {
                        char inputChar = 'X';
                        inputChar = gasType[0];

                        GasType actualGasType = GasTypeMapper(inputChar);
                        double totalCost = 0.0f;


                        decimal decimalGasAmount = 0;
                        bool convertType = decimal.TryParse(gasAmount, out decimalGasAmount);


                        double amount;

                        amount = System.Convert.ToDouble(decimalGasAmount);
                        CalculateTotalCost(actualGasType, amount, ref totalCost);




                    }
                    else
                    {
                        Console.WriteLine(" InValid Amount ");
                        Console.ReadLine();

                    }
                }
                else
                {
                    Console.Write("Invalis gas type ");
                    Console.ReadLine();

                }
            }
        }


        // use this method to check and see if sentinel value is entered
        public static bool UserEnteredSentinelValue(string userInput)
		{
			var result = false;
            if (userInput == null)
            {
                result = false;
            }

           else if (userInput.Equals("Q", StringComparison.InvariantCultureIgnoreCase)) {
                result = true;
            }
			return result;
		}

		// use this method to parse and check the characters entered
		// this does not conform 
		public static bool UserEnteredValidGasType(string userInput)
		{
            var result = false;

            if (userInput == null)
            {
                result = false;
            }
          else  if (userInput.Equals("r", StringComparison.InvariantCultureIgnoreCase) ||
                    userInput.Equals("m", StringComparison.InvariantCultureIgnoreCase) ||
                        userInput.Equals("p", StringComparison.InvariantCultureIgnoreCase) ||
                           userInput.Equals("d", StringComparison.InvariantCultureIgnoreCase))
            {
                result = true;
            }
            return result;
        }

		// use this method to parse and check the double type entered
		// please use Double.TryParse() method 
		public static bool UserEnteredValidAmount(string userInput)
		{
            var result = false;

            decimal amount = 0;
            bool convertType = decimal.TryParse(userInput, out amount);
            if (convertType == true)
                result = true;

            return result;
        }

		// use this method to map a valid char entry to its enum representation
		// e.g. User enters 'R' or 'r' --> this should be mapped to GasType.RegularGas
		// this mapping "must" be used within CalculateTotalCost() method later on
		public static GasType GasTypeMapper(char c)
		{
            GasType gasType = GasType.None;
            string c1 = c.ToString();

            if (c1.Equals("P", StringComparison.InvariantCultureIgnoreCase))
                gasType = GasType.PremiumGas;


            if (c1.Equals("R", StringComparison.InvariantCultureIgnoreCase))
                gasType = GasType.RegularGas;


            if (c1.Equals("M", StringComparison.InvariantCultureIgnoreCase))
                gasType = GasType.MidgradeGas;

            if (c1.Equals("D", StringComparison.InvariantCultureIgnoreCase))
                gasType = GasType.DieselFuel;


            return gasType;
        }

		public static double GasPriceMapper(GasType gasType)
		{
			var result = 0.0;

            if (gasType.Equals(GasType.RegularGas))
                result = 1.94;
            else if (gasType.Equals(GasType.MidgradeGas))
                result = 2;

            else if (gasType.Equals(GasType.PremiumGas))
                result = 2.24;

            else if (gasType.Equals(GasType.DieselFuel))
                result = 2.17;
            return result;
	}

		public static void CalculateTotalCost(GasType gasType, double gasAmount, ref double totalCost)
		{
            double gasPrice = GasPriceMapper(gasType);
            totalCost = gasPrice * gasAmount;

            Console.WriteLine(" Gas Type: " + gasType + " Gas amount " + gasAmount + " Gas Price " + gasPrice);
            Console.WriteLine("total cost: $" + totalCost);
            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }
	}
}
