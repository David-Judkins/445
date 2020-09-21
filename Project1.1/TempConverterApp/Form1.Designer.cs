namespace TempConverterApp
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
            this.ctof = new System.Windows.Forms.Label();
            this.ftoc = new System.Windows.Forms.Label();
            this.EnterC = new System.Windows.Forms.Label();
            this.EnterF = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.ConvertF = new System.Windows.Forms.Button();
            this.ConvertC = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(104, 8);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(161, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Temperature Converter (C° to F°)";
            // 
            // ctof
            // 
            this.ctof.AutoSize = true;
            this.ctof.Location = new System.Drawing.Point(55, 31);
            this.ctof.Name = "ctof";
            this.ctof.Size = new System.Drawing.Size(43, 13);
            this.ctof.TabIndex = 1;
            this.ctof.Text = "C° to F°";
            // 
            // ftoc
            // 
            this.ftoc.AutoSize = true;
            this.ftoc.Location = new System.Drawing.Point(267, 31);
            this.ftoc.Name = "ftoc";
            this.ftoc.Size = new System.Drawing.Size(43, 13);
            this.ftoc.TabIndex = 2;
            this.ftoc.Text = "F° to C°";
            // 
            // EnterC
            // 
            this.EnterC.AutoSize = true;
            this.EnterC.Location = new System.Drawing.Point(12, 54);
            this.EnterC.Name = "EnterC";
            this.EnterC.Size = new System.Drawing.Size(115, 13);
            this.EnterC.TabIndex = 3;
            this.EnterC.Text = "Enter Temperature (C°)";
            // 
            // EnterF
            // 
            this.EnterF.AutoSize = true;
            this.EnterF.Location = new System.Drawing.Point(227, 54);
            this.EnterF.Name = "EnterF";
            this.EnterF.Size = new System.Drawing.Size(114, 13);
            this.EnterF.TabIndex = 4;
            this.EnterF.Text = "Enter Temperature (F°)";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(347, 52);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(39, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(133, 52);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown2.TabIndex = 6;
            // 
            // ConvertF
            // 
            this.ConvertF.Location = new System.Drawing.Point(15, 80);
            this.ConvertF.Name = "ConvertF";
            this.ConvertF.Size = new System.Drawing.Size(112, 23);
            this.ConvertF.TabIndex = 7;
            this.ConvertF.Text = "Convert to F°";
            this.ConvertF.UseVisualStyleBackColor = true;
            this.ConvertF.Click += new System.EventHandler(this.ConvertF_Click);
            // 
            // ConvertC
            // 
            this.ConvertC.Location = new System.Drawing.Point(230, 80);
            this.ConvertC.Name = "ConvertC";
            this.ConvertC.Size = new System.Drawing.Size(111, 23);
            this.ConvertC.TabIndex = 8;
            this.ConvertC.Text = "Convert to C°";
            this.ConvertC.UseVisualStyleBackColor = true;
            this.ConvertC.Click += new System.EventHandler(this.ConvertC_Click);
            // 
            // F
            // 
            this.F.AutoSize = true;
            this.F.Location = new System.Drawing.Point(133, 85);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(0, 13);
            this.F.TabIndex = 9;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(347, 85);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(0, 13);
            this.C.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 114);
            this.Controls.Add(this.C);
            this.Controls.Add(this.F);
            this.Controls.Add(this.ConvertC);
            this.Controls.Add(this.ConvertF);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.EnterF);
            this.Controls.Add(this.EnterC);
            this.Controls.Add(this.ftoc);
            this.Controls.Add(this.ctof);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ctof;
        private System.Windows.Forms.Label ftoc;
        private System.Windows.Forms.Label EnterC;
        private System.Windows.Forms.Label EnterF;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button ConvertF;
        private System.Windows.Forms.Button ConvertC;
        private System.Windows.Forms.Label F;
        private System.Windows.Forms.Label C;
    }
}