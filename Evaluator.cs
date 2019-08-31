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
        List<Object> lista;
        public Evaluator()
        {
            InitializeComponent();
        }

        private void TxtExpression_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var parser = new Parser(txtExpression.Text);
                var evaluator = new CodeAnalysis.Evaluator(parser.ParseExpression());

                var result = evaluator.Evaluate();
                lblResult.Text = result.ToString();
            }
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

    }
}
