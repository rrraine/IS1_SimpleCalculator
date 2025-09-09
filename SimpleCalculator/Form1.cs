using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        string currentInput = "";
        double result = 0;
        string operation = "";
        bool isOperationPerformed = false;
        string lastOperation = "";
        double lastOperand = 0;

        public Form1()
        {
            InitializeComponent();
            label2.TextAlign = ContentAlignment.MiddleRight;
            label1.TextAlign = ContentAlignment.MiddleRight;
        }

        // button handlers

        private void buttonHistory_Click(object sender, EventArgs e) { }

        private void buttonZero_Click(object sender, EventArgs e) => AppendInput("0");
        private void buttonOne_Click(object sender, EventArgs e) => AppendInput("1");
        private void buttonTwo_Click(object sender, EventArgs e) => AppendInput("2");
        private void buttonThree_Click(object sender, EventArgs e) => AppendInput("3");
        private void buttonFour_Click(object sender, EventArgs e) => AppendInput("4");
        private void buttonFive_Click(object sender, EventArgs e) => AppendInput("5");
        private void buttonSix_Click(object sender, EventArgs e) => AppendInput("6");
        private void buttonSeven_Click(object sender, EventArgs e) => AppendInput("7");
        private void buttonEight_Click(object sender, EventArgs e) => AppendInput("8");
        private void buttonNine_Click(object sender, EventArgs e) => AppendInput("9");

        private void buttonDecimal_Click(object sender, EventArgs e) => AppendInput(".");

        private void buttonAddition_Click(object sender, EventArgs e) => AppendInput("+");
        private void buttonSubtraction_Click(object sender, EventArgs e) => AppendInput("-");
        private void buttonMultiplicationClick(object sender, EventArgs e) => AppendInput("*");
        private void buttonDivision_Click(object sender, EventArgs e) => AppendInput("/");

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (label2.Text.Length > 0)
            {
                label2.Text = label2.Text.Substring(0, label2.Text.Length - 1);
            }
        }

        private void buttonAC_click(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "0";
            result = 0;
            currentInput = "";
            operation = "";
            isOperationPerformed = false;
        }

        private void buttonOpenCloseParentheses_Click(object sender, EventArgs e)
        {
            int openCount = label2.Text.Count(c => c == '(');
            int closeCount = label2.Text.Count(c => c == ')');

            if (openCount == closeCount || EndsWithOperatorOrOpenParen())
            {
                AppendInput("(");
            }
            else
            {
                AppendInput(")");
            }
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(label2.Text))
                {
                    double value = (double)(EvaluateExpression(label2.Text) / 100.0);
                    label1.Text = value.ToString();
                    label2.Text = value.ToString();
                }
            }
            catch
            {
                label1.Text = "Error";
            }
        }

        private void buttonPositiveNegative_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(label2.Text))
            {
                if (label2.Text.StartsWith("-"))
                    label2.Text = label2.Text.Substring(1);
                else
                    label2.Text = "-" + label2.Text;
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(label2.Text))
            {
     
                double? evalResult = EvaluateExpression(label2.Text);
                if (evalResult != null)
                {
                    label1.Text = evalResult.ToString();
                    currentInput = evalResult.ToString();
                    result = (double)evalResult;
                    isOperationPerformed = true;

          
                    ParseLastOperation(label2.Text);

                    label2.Text = "";
                }
            }
            else if (!string.IsNullOrEmpty(lastOperation))
            {
          
                switch (lastOperation)
                {
                    case "+":
                        result += lastOperand;
                        break;
                    case "-":
                        result -= lastOperand;
                        break;
                    case "*":
                        result *= lastOperand;
                        break;
                    case "/":
                        if (lastOperand == 0)
                        {
                            ShowMathError(result + "/" + lastOperand);
                            return;
                        }
                        result /= lastOperand;
                        break;
                }

                label1.Text = result.ToString();
                currentInput = result.ToString();
            }
        }

        private void ParseLastOperation(string expression)
        {
          
            string operators = "+-*/";
            int lastIndex = expression.LastIndexOfAny(operators.ToCharArray());

            if (lastIndex >= 0 && lastIndex < expression.Length - 1)
            {
                lastOperation = expression[lastIndex].ToString();
                string operandStr = expression.Substring(lastIndex + 1);

                if (double.TryParse(operandStr, out double operand))
                {
                    lastOperand = operand;
                }
            }
        }

        // mga helper functions

        private void AppendInput(string value)
        {
            label2.Text += value;
        }

        private bool EndsWithOperatorOrOpenParen()
        {
            if (string.IsNullOrEmpty(label2.Text)) return false;
            char last = label2.Text.Last();
            return last == '+' || last == '-' || last == '*' || last == '/' || last == '(';
        }


        private string PreprocessExpression(string expression)
        {
            // if parentheses is used as multiplication, e.g. 2(3+4) or (1+2)3
            var result = "";
            for (int i = 0; i < expression.Length; i++)
            {
                char curr = expression[i];
                char prev = i > 0 ? expression[i - 1] : '\0';

                
                if (char.IsDigit(prev) && curr == '(')
                    result += "*(";
                else if (prev == ')' && char.IsDigit(curr))
                    result += ")*" + curr;
                else
                    result += curr;
            }
            return result;
        }

        private double? EvaluateExpression(string expression)
        {
            try
            {
                expression = PreprocessExpression(expression);
                DataTable dt = new DataTable();
                var value = dt.Compute(expression, "");
                double result = Convert.ToDouble(value);

                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    ShowMathError(expression);
                    return null;
                }

                return result;
            }
            catch (SyntaxErrorException)
            {
                label1.Text = "Syntax Error";
                return null;
            }
            catch (Exception)
            {
                label1.Text = "Invalid Input";
                return null;
            }
        }

        private void ShowMathError(string expression)
        {
            label1.Text = "Math Error";
            label2.Text = expression;
        }
    }
}
