using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2020510199_muratcan_barcin
{
    internal class program
    {
        static void Main(string[] args)
        {

            /* 
             !!!! IMPORTANT INFORMATION !!!!
            1- There is a deviation of 0.01 or less for some input values in the program.
            2- In order to minimize the margin of error in the code, the variables that should be "int" are assigned as "double"
            */

            // The variables are defined
            double x, y;
            char chosen_operator;
            double x_short_one=2, x_short_two=5, x_short_result, y_short_result=1;
            double shortest, total_denominator=0, denominator,first_denominator =4, denominator_temp;
            double result_temp, first_result, result;
            double nums, temp_term_num;

            // Input values were received from the user and necessary checks were made.
            Console.Write("Enter the X value:");
            x = Convert.ToDouble(Console.ReadLine());

            while (x<2 || x>50) {
                Console.Write("Incorrect Value! Re-enter the X value: (2-50)");
                x = Convert.ToDouble(Console.ReadLine());


            }
            Console.Write("Enter the Y value:");
            y = Convert.ToDouble(Console.ReadLine());

            while (y < 25 || y > 30)
            {
                Console.Write("Incorrect Value! Re-enter the Y value: (2-50)");
                y = Convert.ToDouble(Console.ReadLine());


            }
            Console.Write("Choose the operator:(+,*)");
            chosen_operator= Convert.ToChar(Console.ReadLine());


            if (chosen_operator == '+')
            {   //Equations related to x and y were calculated. The smallest value was found.
                x_short_result = (x_short_one + x_short_two) * x;
                
                for (double fact_num =1; fact_num <(y+1); fact_num++) {
                    y_short_result *= fact_num;
                
                }

                if (x_short_result < y_short_result)
                {
                    shortest = x_short_result;
                }
                else { shortest = y_short_result; }
                //For algorithmic reasons, the initial value was calculated without using loops.
                first_result = shortest / first_denominator;
                result= first_result;
                
                for (double term_num =1;  term_num < 25; term_num++)
                {
                    y -= 1;
                    x_short_one += 3;
                    x_short_two += 3;
                    y_short_result = 1;
                    //Equations related to x and y were calculated. The smallest value was found.
                    x_short_result = (x_short_one + x_short_two) * x;

                    for (double fact_number = 1; fact_number< (y + 1); fact_number++)
                    {
                        y_short_result *= fact_number;
                    }
                    if (x_short_result < y_short_result)
                    {
                        shortest = x_short_result;
                    }
                    else { shortest = y_short_result; }

                    nums = term_num + 2;
                    temp_term_num = term_num;
                    // For the calculation of the denominator; Necessary code operations have been done.
                    while (nums > 0)
                    {
                        denominator = 2 * (temp_term_num + 1) - 1;
                        denominator_temp = denominator;
                        for (double num_product = 0; num_product <term_num; num_product++)
                        {
                            denominator *= denominator_temp;

                        }
                        nums -= 1;
                        total_denominator+= denominator;
                        temp_term_num += 1;
                       

                    }
                    //The result is found and added to the total result.
                    if (term_num % 2 == 1) { result_temp = shortest / total_denominator; }
                    else { result_temp = - (shortest / total_denominator); }


                    result += result_temp;
               


                }
                Console.WriteLine("Result    " + result);
                Console.ReadLine();





            }
            else if (chosen_operator == '*')
            {   //Equations related to x and y were calculated. The smallest value was found.
                x_short_result = (x_short_one * x_short_two) * x* x;

                for (double fact_num = 1; fact_num < (y + 1); fact_num++)
                {
                    y_short_result *= fact_num;

                }

                if (x_short_result < y_short_result)
                {
                    shortest = x_short_result;
                }
                else { shortest = y_short_result; }
                //For algorithmic reasons, the initial value was calculated without using loops.

                first_result = shortest / first_denominator;
                result = first_result;

                for (double term_num = 1; term_num < 25; term_num++)
                {
                    y -= 1;
                    x_short_one += 3;
                    x_short_two += 3;
                    y_short_result = 1;
                    //Equations related to x and y were calculated. The smallest value was found.

                    x_short_result = (x_short_one * x_short_two) * x* x;

                    for (double fact_number = 1; fact_number < (y +1); fact_number++)
                    {
                        y_short_result *= fact_number;
                    }
                    if (x_short_result < y_short_result)
                    {
                        shortest = x_short_result;
                    }
                    else { shortest = y_short_result; }

                    nums = term_num + 2;
                    temp_term_num = term_num;
                    // For the calculation of the denominator; Necessary code operations have been done.

                    while (nums > 0)
                    {
                        denominator = 2 * (temp_term_num + 1) - 1;
                        denominator_temp = denominator;
                        for (double num_product = 0; num_product < term_num; num_product++)
                        {
                            denominator *= denominator_temp;

                        }
                        nums -= 1;
                        total_denominator += denominator;
                        temp_term_num += 1;


                    }
                    //The result is found and added to the total result.

                    if (term_num % 2 == 1) { result_temp = shortest / total_denominator; }
                    else { result_temp = -(shortest / total_denominator); }


                    result += result_temp;



                }
                Console.WriteLine("Result:    " + result);
                Console.ReadLine();





            }



        }
    }
}
