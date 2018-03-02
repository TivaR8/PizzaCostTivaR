namespace PizzaCostTivaR
{
    partial class frmPizzaCost
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtUsersNumber = new System.Windows.Forms.TextBox();
            this.lblCostAnswer = new System.Windows.Forms.Label();
            this.lblFinalCostText = new System.Windows.Forms.Label();
            this.lblCostText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 53);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(167, 13);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "What is the diameter of the pizza?";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(56, 123);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // txtUsersNumber
            // 
            this.txtUsersNumber.Location = new System.Drawing.Point(257, 50);
            this.txtUsersNumber.Name = "txtUsersNumber";
            this.txtUsersNumber.Size = new System.Drawing.Size(100, 20);
            this.txtUsersNumber.TabIndex = 2;
            this.txtUsersNumber.Text = "5";
            // 
            // lblCostAnswer
            // 
            this.lblCostAnswer.AutoSize = true;
            this.lblCostAnswer.Location = new System.Drawing.Point(211, 222);
            this.lblCostAnswer.Name = "lblCostAnswer";
            this.lblCostAnswer.Size = new System.Drawing.Size(0, 13);
            this.lblCostAnswer.TabIndex = 3;
            // 
            // lblFinalCostText
            // 
            this.lblFinalCostText.AutoSize = true;
            this.lblFinalCostText.Location = new System.Drawing.Point(43, 221);
            this.lblFinalCostText.Name = "lblFinalCostText";
            this.lblFinalCostText.Size = new System.Drawing.Size(208, 13);
            this.lblFinalCostText.TabIndex = 4;
            this.lblFinalCostText.Text = "The final cost of your pizza including tax is ";
            // 
            // lblCostText
            // 
            this.lblCostText.AutoSize = true;
            this.lblCostText.Location = new System.Drawing.Point(281, 220);
            this.lblCostText.Name = "lblCostText";
            this.lblCostText.Size = new System.Drawing.Size(13, 13);
            this.lblCostText.TabIndex = 5;
            this.lblCostText.Text = "$";
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 293);
            this.Controls.Add(this.lblCostText);
            this.Controls.Add(this.lblFinalCostText);
            this.Controls.Add(this.lblCostAnswer);
            this.Controls.Add(this.txtUsersNumber);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblQuestion);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost By Tiva Rait";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtUsersNumber;
        private System.Windows.Forms.Label lblCostAnswer;
        private System.Windows.Forms.Label lblFinalCostText;
        private System.Windows.Forms.Label lblCostText;
    }
}

