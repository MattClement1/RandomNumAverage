namespace RandomNumAverage
{
    partial class frmRandomNumAverage
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.lstNumList = new System.Windows.Forms.ListBox();
            this.lblNumbersUsed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(348, 16);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Click the button to find the average of 10 random numbers:";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(147, 37);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Click Me";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lstNumList
            // 
            this.lstNumList.FormattingEnabled = true;
            this.lstNumList.Location = new System.Drawing.Point(124, 92);
            this.lstNumList.Name = "lstNumList";
            this.lstNumList.Size = new System.Drawing.Size(120, 134);
            this.lstNumList.TabIndex = 2;
            // 
            // lblNumbersUsed
            // 
            this.lblNumbersUsed.AutoSize = true;
            this.lblNumbersUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumbersUsed.Location = new System.Drawing.Point(135, 73);
            this.lblNumbersUsed.Name = "lblNumbersUsed";
            this.lblNumbersUsed.Size = new System.Drawing.Size(99, 16);
            this.lblNumbersUsed.TabIndex = 3;
            this.lblNumbersUsed.Text = "Numbers used:";
            // 
            // frmRandomNumAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 238);
            this.Controls.Add(this.lblNumbersUsed);
            this.Controls.Add(this.lstNumList);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmRandomNumAverage";
            this.Text = "Random Number Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.ListBox lstNumList;
        private System.Windows.Forms.Label lblNumbersUsed;
    }
}

