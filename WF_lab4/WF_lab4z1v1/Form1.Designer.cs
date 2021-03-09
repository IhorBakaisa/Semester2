
namespace WF_lab4z1v1
{
    partial class WF_lab4z1v1
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
            this.label2 = new System.Windows.Forms.Label();
            this.rowNumber = new System.Windows.Forms.NumericUpDown();
            this.colNumber = new System.Windows.Forms.NumericUpDown();
            this.matrix_DG = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rowNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість рядків матриці";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кількість стовпців матриці";
            // 
            // rowNumber
            // 
            this.rowNumber.Location = new System.Drawing.Point(231, 24);
            this.rowNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowNumber.Name = "rowNumber";
            this.rowNumber.Size = new System.Drawing.Size(150, 27);
            this.rowNumber.TabIndex = 2;
            this.rowNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rowNumber.ValueChanged += new System.EventHandler(this.rowNumber_ValueChanged);
            // 
            // colNumber
            // 
            this.colNumber.Location = new System.Drawing.Point(231, 63);
            this.colNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colNumber.Name = "colNumber";
            this.colNumber.Size = new System.Drawing.Size(150, 27);
            this.colNumber.TabIndex = 3;
            this.colNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colNumber.ValueChanged += new System.EventHandler(this.colNumber_ValueChanged);
            // 
            // matrix_DG
            // 
            this.matrix_DG.AllowUserToAddRows = false;
            this.matrix_DG.AllowUserToDeleteRows = false;
            this.matrix_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrix_DG.ColumnHeadersVisible = false;
            this.matrix_DG.Location = new System.Drawing.Point(387, 12);
            this.matrix_DG.Name = "matrix_DG";
            this.matrix_DG.RowHeadersVisible = false;
            this.matrix_DG.RowHeadersWidth = 51;
            this.matrix_DG.RowTemplate.Height = 29;
            this.matrix_DG.Size = new System.Drawing.Size(401, 288);
            this.matrix_DG.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Виконати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(466, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сума від’ємних елементів матриці з обома парними індексами =";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(493, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 31);
            this.button2.TabIndex = 8;
            this.button2.Text = "Згенерувати рандомно";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WF_lab4z1v1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.matrix_DG);
            this.Controls.Add(this.colNumber);
            this.Controls.Add(this.rowNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WF_lab4z1v1";
            this.Text = "WF_lab4z1v1";
            this.Load += new System.EventHandler(this.WF_lab4z1v1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rowNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrix_DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown rowNumber;
        private System.Windows.Forms.NumericUpDown colNumber;
        private System.Windows.Forms.DataGridView matrix_DG;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}

