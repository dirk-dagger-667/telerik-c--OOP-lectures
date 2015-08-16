using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XExpression
{
    class XExpression
    {
        static void Main(string[] args)
        {

            string inputExpression = Console.ReadLine();

            char[] symbols = inputExpression.ToCharArray();
            double result = 0;
            double firstNumber = 0;
            double secondNumber = 0;
            double resultBrackets = 0;
            for (int i = 0; i < symbols.Length; i++)
            {
                switch (symbols[i])
                {
                    case '+':
                        if (i == 1)
                        {
                            firstNumber = symbols[i - 1] - '0';
                            secondNumber = symbols[i + 1] - '0';
                            result = firstNumber + secondNumber;

                        }
                        else
                        {
                            result += symbols[i + 1] - '0';
                        }
                        break;

                    case '-':
                        if (i == 1)
                        {
                            firstNumber = symbols[i - 1] - '0';
                            secondNumber = symbols[i + 1] - '0';
                            result = firstNumber - secondNumber;

                        }
                        else
                        {
                            result -= symbols[i + 1] - '0';
                        }
                        break;

                    case '*':
                        if (i == 1)
                        {
                            firstNumber = symbols[i - 1] - '0';
                            secondNumber = symbols[i + 1] - '0';
                            result = firstNumber * secondNumber;

                        }
                        else
                        {
                            result *= symbols[i + 1] - '0';
                        }
                        break;

                    case '/':
                        if (i == 1)
                        {
                            firstNumber = symbols[i - 1] - '0';
                            secondNumber = symbols[i + 1] - '0';
                            result = firstNumber / secondNumber;

                        }
                        else
                        {
                            result /= symbols[i + 1] - '0';
                        }
                        break;

                    case '(':
                        for (int j = i; j < symbols.Length; j++)
                        {
                            switch (symbols[j])
                            {
                                case '+':
                                    if (i == 1)
                                    {
                                        firstNumber = symbols[j - 1] - '0';
                                        secondNumber = symbols[j + 1] - '0';
                                        resultBrackets = firstNumber + secondNumber;

                                    }
                                    else
                                    {
                                        resultBrackets += symbols[j + 1] - '0';
                                    }
                                    break;

                                case '-':
                                    if (i == 1)
                                    {
                                        firstNumber = symbols[j - 1] - '0';
                                        secondNumber = symbols[j + 1] - '0';
                                        resultBrackets = firstNumber - secondNumber;

                                    }
                                    else
                                    {
                                        resultBrackets -= symbols[j + 1] - '0';
                                    }
                                    break;

                                case '*':
                                    if (i == 1)
                                    {
                                        firstNumber = symbols[j - 1] - '0';
                                        secondNumber = symbols[j + 1] - '0';
                                        resultBrackets = firstNumber * secondNumber;

                                    }
                                    else
                                    {
                                        resultBrackets *= symbols[j + 1] - '0';
                                    }
                                    break;

                                case '/':
                                    if (i == 1)
                                    {
                                        firstNumber = symbols[j - 1] - '0';
                                        secondNumber = symbols[j + 1] - '0';
                                        resultBrackets = firstNumber / secondNumber;

                                    }
                                    else
                                    {
                                        resultBrackets /= symbols[j + 1] - '0';
                                    }
                                    break;
                                case ')':
                                    break;
                                    
                            }
                           

                        }
                        break;
                }
                Console.WriteLine(result);
                
            }
        }
    }
}
