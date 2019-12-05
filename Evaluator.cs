using ExpressionEvaluator.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpressionEvaluator
{
    public partial class Evaluator : Form
    {
        String expression;
        public Evaluator()
        {
            InitializeComponent();
        }

        private void TxtExpression_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {

                try
                {
                    Evaluate();
                    lblStatus.Visible = false;
                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Please enter all the variables needed!";
                    lblStatus.Visible = true;
                }

            }
        }

        private void SubstituteValues(Dictionary<string, string> variablesTable, ref string expression)
        {
            foreach (var variable in variablesTable)
            {
                if (expression.Contains(variable.Key))
                {
                    expression = expression.Replace(variable.Key, variable.Value);
                }
            }
        }

        private bool HasLetters(string expression)
        {
            foreach (var character in expression)
                if (char.IsLetter(character))
                    return true;
                
            return false;
        }

        private void Txts_MouseDown(object sender, MouseEventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text == textbox.Tag.ToString())
            {
                textbox.Text = String.Empty;
                textbox.ForeColor = Color.Black;
            }
        }

        private void Txts_MouseLeave(object sender, EventArgs e)
        {
            var textbox = sender as TextBox;
            if (textbox.Text == String.Empty)
            {
                textbox.Text = textbox.Tag.ToString();
                textbox.ForeColor = Color.DimGray;
            }
        }

        private Dictionary<string, string> GenerateVariablesTable(string assignmentValues)
        {
            var assignments = assignmentValues.Split(',');
            var variables = new Dictionary<string, string>();

            foreach (var assignment in assignments)
            {
                var assignmentSplitted = assignment.Split('=');
                // 0 should be the letter, 1 the value
                variables[assignmentSplitted[0].Trim()] = assignmentSplitted[1].Trim();
            }

            return variables;
        }

        private void BtnEvaluate_Click(object sender, EventArgs e)
        {
            try
            {
                Evaluate();
                lblStatus.Visible = false;
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Please enter all the variables needed!";
                lblStatus.Visible = true;
            }
            
        }

        private void Evaluate()
        {
            expression = txtExpression.Text;
            var values = txtValues.Text;

            Console.WriteLine($"Old Expression: {expression}");

            if (HasLetters(expression))
            {
                if (String.IsNullOrEmpty(values) || values == txtValues.Tag.ToString())
                {
                    lblStatus.Text = "Please fill the values box!";
                    lblStatus.Visible = true;
                }
                else
                {
                    var variablesTable = GenerateVariablesTable(values);
                    SubstituteValues(variablesTable, ref expression);

                    lblStatus.Visible = false;
                }
            }

            var parser = new Parser(expression);
            var evaluator = new CodeAnalysis.Evaluator(parser.ParseExpression());

            var result = evaluator.Evaluate();
            lblResult.Text = result.ToString();
        }
    }
}
