namespace Lab3
{
    partial class Form1
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
            this.enterPriceLabel = new System.Windows.Forms.Label();
            this.tipRate1Label = new System.Windows.Forms.Label();
            this.tipRate2Label = new System.Windows.Forms.Label();
            this.tipRate3Label = new System.Windows.Forms.Label();
            this.tipRate1OutputLabel = new System.Windows.Forms.Label();
            this.tipRate2OutputLabel = new System.Windows.Forms.Label();
            this.tipRate3OutputLabel = new System.Windows.Forms.Label();
            this.calculateTipBtn = new System.Windows.Forms.Button();
            this.inputPriceTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterPriceLabel
            // 
            this.enterPriceLabel.AutoSize = true;
            this.enterPriceLabel.Location = new System.Drawing.Point(34, 44);
            this.enterPriceLabel.Name = "enterPriceLabel";
            this.enterPriceLabel.Size = new System.Drawing.Size(98, 13);
            this.enterPriceLabel.TabIndex = 2;
            this.enterPriceLabel.Text = "Enter price of meal:";
            // 
            // tipRate1Label
            // 
            this.tipRate1Label.AutoSize = true;
            this.tipRate1Label.Location = new System.Drawing.Point(105, 106);
            this.tipRate1Label.Name = "tipRate1Label";
            this.tipRate1Label.Size = new System.Drawing.Size(27, 13);
            this.tipRate1Label.TabIndex = 3;
            this.tipRate1Label.Text = "15%";
            // 
            // tipRate2Label
            // 
            this.tipRate2Label.AutoSize = true;
            this.tipRate2Label.Location = new System.Drawing.Point(105, 140);
            this.tipRate2Label.Name = "tipRate2Label";
            this.tipRate2Label.Size = new System.Drawing.Size(27, 13);
            this.tipRate2Label.TabIndex = 5;
            this.tipRate2Label.Text = "18%";
            // 
            // tipRate3Label
            // 
            this.tipRate3Label.AutoSize = true;
            this.tipRate3Label.Location = new System.Drawing.Point(105, 177);
            this.tipRate3Label.Name = "tipRate3Label";
            this.tipRate3Label.Size = new System.Drawing.Size(27, 13);
            this.tipRate3Label.TabIndex = 7;
            this.tipRate3Label.Text = "20%";
            // 
            // tipRate1OutputLabel
            // 
            this.tipRate1OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipRate1OutputLabel.Location = new System.Drawing.Point(138, 106);
            this.tipRate1OutputLabel.Name = "tipRate1OutputLabel";
            this.tipRate1OutputLabel.Size = new System.Drawing.Size(100, 19);
            this.tipRate1OutputLabel.TabIndex = 4;
            this.tipRate1OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipRate2OutputLabel
            // 
            this.tipRate2OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipRate2OutputLabel.Location = new System.Drawing.Point(138, 139);
            this.tipRate2OutputLabel.Name = "tipRate2OutputLabel";
            this.tipRate2OutputLabel.Size = new System.Drawing.Size(100, 20);
            this.tipRate2OutputLabel.TabIndex = 6;
            this.tipRate2OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipRate3OutputLabel
            // 
            this.tipRate3OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipRate3OutputLabel.Location = new System.Drawing.Point(138, 176);
            this.tipRate3OutputLabel.Name = "tipRate3OutputLabel";
            this.tipRate3OutputLabel.Size = new System.Drawing.Size(100, 20);
            this.tipRate3OutputLabel.TabIndex = 8;
            this.tipRate3OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateTipBtn
            // 
            this.calculateTipBtn.Location = new System.Drawing.Point(138, 220);
            this.calculateTipBtn.Name = "calculateTipBtn";
            this.calculateTipBtn.Size = new System.Drawing.Size(82, 23);
            this.calculateTipBtn.TabIndex = 1;
            this.calculateTipBtn.Text = "Calculate Tip";
            this.calculateTipBtn.UseVisualStyleBackColor = true;
            this.calculateTipBtn.Click += new System.EventHandler(this.calculateTipBtn_Click);
            // 
            // inputPriceTextbox
            // 
            this.inputPriceTextbox.Location = new System.Drawing.Point(138, 41);
            this.inputPriceTextbox.Name = "inputPriceTextbox";
            this.inputPriceTextbox.Size = new System.Drawing.Size(100, 20);
            this.inputPriceTextbox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.inputPriceTextbox);
            this.Controls.Add(this.calculateTipBtn);
            this.Controls.Add(this.tipRate3OutputLabel);
            this.Controls.Add(this.tipRate2OutputLabel);
            this.Controls.Add(this.tipRate1OutputLabel);
            this.Controls.Add(this.tipRate3Label);
            this.Controls.Add(this.tipRate2Label);
            this.Controls.Add(this.tipRate1Label);
            this.Controls.Add(this.enterPriceLabel);
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterPriceLabel;
        private System.Windows.Forms.Label tipRate1Label;
        private System.Windows.Forms.Label tipRate2Label;
        private System.Windows.Forms.Label tipRate3Label;
        private System.Windows.Forms.Label tipRate1OutputLabel;
        private System.Windows.Forms.Label tipRate2OutputLabel;
        private System.Windows.Forms.Label tipRate3OutputLabel;
        private System.Windows.Forms.Button calculateTipBtn;
        private System.Windows.Forms.TextBox inputPriceTextbox;
    }
}

