namespace ExpressionEvaluator
{
    partial class Evaluator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtExpression = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.txtValues = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExpression
            // 
            this.txtExpression.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpression.ForeColor = System.Drawing.Color.DimGray;
            this.txtExpression.Location = new System.Drawing.Point(17, 26);
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(837, 24);
            this.txtExpression.TabIndex = 0;
            this.txtExpression.Tag = "Expression...";
            this.txtExpression.Text = "Expression...";
            this.txtExpression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtExpression_KeyDown);
            this.txtExpression.Leave += new System.EventHandler(this.Txts_MouseLeave);
            this.txtExpression.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txts_MouseDown);
            this.txtExpression.MouseLeave += new System.EventHandler(this.Txts_MouseLeave);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(54, 108);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 1;
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquals.Location = new System.Drawing.Point(12, 108);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(36, 25);
            this.lblEquals.TabIndex = 2;
            this.lblEquals.Text = " = ";
            // 
            // txtValues
            // 
            this.txtValues.AcceptsReturn = true;
            this.txtValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValues.ForeColor = System.Drawing.Color.DimGray;
            this.txtValues.Location = new System.Drawing.Point(17, 198);
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(837, 24);
            this.txtValues.TabIndex = 3;
            this.txtValues.Tag = "Eg. x = 10, y=20, Y = -15, z = 12.4";
            this.txtValues.Text = "Eg. x = 10, y=20, Y = -15, z = 12.4";
            this.txtValues.Leave += new System.EventHandler(this.Txts_MouseLeave);
            this.txtValues.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txts_MouseDown);
            this.txtValues.MouseLeave += new System.EventHandler(this.Txts_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comma separated values:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblStatus.ForeColor = System.Drawing.Color.Brown;
            this.lblStatus.Location = new System.Drawing.Point(13, 253);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 24);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "label2";
            this.lblStatus.Visible = false;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEvaluate.FlatAppearance.BorderSize = 0;
            this.btnEvaluate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEvaluate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluate.ForeColor = System.Drawing.Color.White;
            this.btnEvaluate.Location = new System.Drawing.Point(17, 57);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(161, 33);
            this.btnEvaluate.TabIndex = 6;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = false;
            this.btnEvaluate.Click += new System.EventHandler(this.BtnEvaluate_Click);
            // 
            // Evaluator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(875, 289);
            this.Controls.Add(this.btnEvaluate);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValues);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtExpression);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(891, 328);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(891, 328);
            this.Name = "Evaluator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpression;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnEvaluate;
    }
}