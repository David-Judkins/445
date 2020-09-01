namespace NumberSortApp
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
            this.Title = new System.Windows.Forms.Label();
            this.Prompt = new System.Windows.Forms.Label();
            this.ListInput = new System.Windows.Forms.TextBox();
            this.SortButton = new System.Windows.Forms.Button();
            this.StringPrint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(90, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(176, 21);
            this.Title.TabIndex = 0;
            this.Title.Text = "Sort A List of Numbers";
            // 
            // Prompt
            // 
            this.Prompt.AutoSize = true;
            this.Prompt.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prompt.Location = new System.Drawing.Point(12, 47);
            this.Prompt.Name = "Prompt";
            this.Prompt.Size = new System.Drawing.Size(173, 34);
            this.Prompt.TabIndex = 1;
            this.Prompt.Text = "Comma Separated List of\r\nUnsorted Numbers (Ex. 2,5,1)\r\n";
            // 
            // ListInput
            // 
            this.ListInput.Location = new System.Drawing.Point(191, 61);
            this.ListInput.Name = "ListInput";
            this.ListInput.Size = new System.Drawing.Size(166, 20);
            this.ListInput.TabIndex = 2;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(15, 98);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(161, 23);
            this.SortButton.TabIndex = 3;
            this.SortButton.Text = "SortButton";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StringPrint
            // 
            this.StringPrint.AutoSize = true;
            this.StringPrint.Location = new System.Drawing.Point(211, 103);
            this.StringPrint.Name = "StringPrint";
            this.StringPrint.Size = new System.Drawing.Size(118, 13);
            this.StringPrint.TabIndex = 4;
            this.StringPrint.Text = "Sorted String Print Here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 133);
            this.Controls.Add(this.StringPrint);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.ListInput);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Prompt;
        private System.Windows.Forms.TextBox ListInput;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Label StringPrint;
    }
}

