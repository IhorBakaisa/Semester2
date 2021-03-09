
namespace WF_lab4z4v1
{
    partial class WF_lab4z4v1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.rowcolNumber = new System.Windows.Forms.NumericUpDown();
            this.matrix = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rowcolNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість рядків та стовпців матриці";
            // 
            // rowcolNumber
            // 
            this.rowcolNumber.Location = new System.Drawing.Point(278, 24);
            this.rowcolNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowcolNumber.Name = "rowcolNumber";
            this.rowcolNumber.Size = new System.Drawing.Size(150, 27);
            this.rowcolNumber.TabIndex = 2;
            this.rowcolNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowcolNumber.ValueChanged += new System.EventHandler(this.rowcolNumber_ValueChanged);
            // 
            // matrix
            // 
            this.matrix.AllowUserToAddRows = false;
            this.matrix.AllowUserToDeleteRows = false;
            this.matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix.Location = new System.Drawing.Point(12, 57);
            this.matrix.Name = "matrix";
            this.matrix.RowHeadersWidth = 51;
            this.matrix.RowTemplate.Height = 29;
            this.matrix.Size = new System.Drawing.Size(776, 264);
            this.matrix.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 28);
            this.button1.TabIndex = 5;
            this.button1.Text = "Згенерувати рандомно";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(429, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Розмістити елементи парних рядків у порядку зростання.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WF_lab4z4v1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matrix);
            this.Controls.Add(this.rowcolNumber);
            this.Controls.Add(this.label1);
            this.Name = "WF_lab4z4v1";
            this.Text = "WF_lab4z4v1";
            this.Load += new System.EventHandler(this.WF_lab4z4v1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rowcolNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown rowcolNumber;
        private System.Windows.Forms.DataGridView matrix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

