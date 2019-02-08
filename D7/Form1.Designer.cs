namespace D7
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
            this.labelCount = new System.Windows.Forms.Label();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(135, 78);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(39, 13);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "Skaits:";
            this.labelCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(176, 75);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(100, 20);
            this.inputNumber.TabIndex = 1;
            this.inputNumber.Text = "1";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(134, 135);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(142, 29);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Notirit";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 239);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.labelCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

