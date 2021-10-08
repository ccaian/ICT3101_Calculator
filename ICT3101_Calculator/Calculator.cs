using System;
using System.Collections.Generic;
using System.Text;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }
        public double DoOperation(double num1, double num2, double num3, string op)
        {
            double result = double.NaN; // Default value
                                        // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    result = Factorial(num1);
                    break;
                case "t":
                    result = Triangle(num1,num2);
                    break;
                case "c":
                    result = Circle(num1);
                    break;
                case "mtbf":
                    result = MTBF(num1,num2);
                    break;
                case "avail":
                    result = Availability(num1, num2);
                    break;
                case "cfi":
                    result = CurrentFailureIntensity(num1, num2, num3);
                    break;
                case "anef":
                    result = AverageNumberExpectedFailures(num1, num2, num3);
                    break;
                case "cfil":
                    result = CurrentFailureIntensityLogModel(num1, num2, num3);
                    break;
                case "anefl":
                    result = NumberExpectedFailuresLogModel(num1, num2, num3);
                    break;
                case "dd":
                    result = DefectDensity(num1, num2);
                    break;
                case "kssi":
                    result = KSSI(num1,num2,num3);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
        public double Add(double num1, double num2)
        {
            
            if (this.CheckBinary(num1) && this.CheckBinary(num2))
            {
                
                string binaryString = num1.ToString() + num2.ToString();

              
                return Convert.ToInt32(binaryString, 2);
            }

            return (num1 + num2);
        }
        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            //    if (num2 == 0)
            //    {
            //        throw new ArgumentException();
            //    }
            //    else if(num1 == 0)
            //    {
            //        return 0;
            //    }
            //    return (num1 / num2);
            if (num1 == 0 && num2 == 0)
                return 1;

            else if (num2 == 0)
            {
                return double.PositiveInfinity;
            }
            else if (num1 == 0)
            {
                return 0;
            }
            return (num1 / num2);
        }

        public double Factorial (double num1)
        {
            if(num1 <0)
            {
                throw new ArgumentException();
            }

           if (num1 == 0)
            {
                return 1;
            }

            return num1 * Factorial(num1 - 1);
        }
        public double Triangle(double num1,double num2)
        {
            if (num1 <= 0 || num2 <= 0)
            {
                throw new ArgumentException();
            }

            return ((num1 * num2) / 2);
        }

        public double Circle(double num1)
        {
            if (num1 < 0 || num1 == 0)
            {
                throw new ArgumentException();
            }

            return (3.14*(num1*num1));
        }

        // Task 18
        public double UnknownFunctionA(double num1, double num2)
        {
            double total;
            if(num1 < num2)
            {
                throw new ArgumentException();
            }
            else if (num1 == num2)
            {
                return Factorial(num1);
            }
            else
            {
                total = Subtract(num1, num2);
                total *= Factorial(Subtract(total, 1));
                return (num1 * Factorial(Subtract(num1, 1))) / total;
            }
        }

        public double UnknownFunctionB(double num1, double num2)
        {
            
            if (num1 < num2)
            {
                throw new ArgumentException();
            }
           
            else
            {
                //n = num1 
                //r = num2
                //(n!/(r!*(n-r)!)
                return Divide(Factorial(num1), (Multiply(Factorial(num2), Factorial(Subtract(num1, num2)))));
            }
        }
        private bool CheckBinary(double num1)
        {
            // If has decimal places, not binary
            //not binary, return false so just normal add
            if (num1 % 1 != 0)
                return false;

            //then this is to convert binary to decimal and then pass d test
            while (num1 != 0)
            {
              
                if (num1 % 10 > 1)
                    return false;

                num1 = Math.Floor(num1 / 10);
            }

            return true;
        }

        //mttf + mttr
        public double MTBF(double num1, double num2)
        {
            return (num1 + num2);
        }


        //mttf/mtbf * 100
        public double Availability(double num1, double num2)
        {
            return (num1 / num2) * 100;
        }

        //basic model
        //num 1 initial failure intensity
        //num 2 average expected failures at time t
        //num 3 total number of failures
        public double CurrentFailureIntensity(double num1, double num2, double num3)
        {
            //to round up
            double total = (num1 * (1 - (num2 / num3)));
            double multiplier = Math.Pow(10, Convert.ToDouble(2));
            total = Math.Ceiling(total * multiplier) / multiplier;
            return total;
        }

        public double DefectDensity(double defect, double size)
        {
            return Math.Round(Divide(defect, size), 2);
        }

        public double KSSI(double orignalsize, double newcode, double changedcode)
        {
            return Math.Round(Subtract(Add(orignalsize, newcode), changedcode), 2);
        }


        public double AverageNumberExpectedFailures(double num1, double num2, double num3)
        {
            //test
            //test2
            //test3
            double total = (num1 * (1 - Math.Exp(-(num2 / num1) * num3)));
            double multiplier = Math.Pow(10, Convert.ToDouble(2));
            total = Math.Ceiling(total * multiplier) / multiplier;
            return total;
        }

        //num1 initial failure intensity
        //num2 decay parameter
        //num3 average expected failure
        public double CurrentFailureIntensityLogModel(double num1, double num2, double num3)
        {
            //to round up
            double total = (num1 * Math.Exp(-num2*num3));
            double multiplier = Math.Pow(10, Convert.ToDouble(2));
            total = Math.Ceiling(total * multiplier) / multiplier;
            return total;
        }



        public double NumberExpectedFailuresLogModel(double num1, double num2, double num3)
        {
            double total = (1/num1)* Math.Log(num2 * num1 * num3 + 1);
            double multiplier = Math.Pow(10, Convert.ToDouble(2));
            total = Math.Ceiling(total * multiplier) / multiplier;
            return total;
        }




    }
}
