namespace LINQ
{
    partial class frmEmployeeGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnOrderByName = new System.Windows.Forms.Button();
            this.btnSelectName = new System.Windows.Forms.Button();
            this.btnSelectNameSurname = new System.Windows.Forms.Button();
            this.btnSelectAge = new System.Windows.Forms.Button();
            this.btnSelectMultiple = new System.Windows.Forms.Button();
            this.btnSelectLength = new System.Windows.Forms.Button();
            this.btnSelectCompareLength = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployees
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployees.Location = new System.Drawing.Point(340, 13);
            this.dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployees.Size = new System.Drawing.Size(786, 384);
            this.dgvEmployees.TabIndex = 0;
            // 
            // btnOrderByName
            // 
            this.btnOrderByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderByName.Location = new System.Drawing.Point(72, 12);
            this.btnOrderByName.Name = "btnOrderByName";
            this.btnOrderByName.Size = new System.Drawing.Size(139, 30);
            this.btnOrderByName.TabIndex = 1;
            this.btnOrderByName.Text = "Order By Name";
            this.btnOrderByName.UseVisualStyleBackColor = true;
            this.btnOrderByName.Click += new System.EventHandler(this.btnOrderByName_Click);
            // 
            // btnSelectName
            // 
            this.btnSelectName.Location = new System.Drawing.Point(9, 72);
            this.btnSelectName.Name = "btnSelectName";
            this.btnSelectName.Size = new System.Drawing.Size(111, 29);
            this.btnSelectName.TabIndex = 2;
            this.btnSelectName.Text = "Button 1";
            this.btnSelectName.UseVisualStyleBackColor = true;
            this.btnSelectName.Click += new System.EventHandler(this.btnSelectName_click);
            // 
            // btnSelectNameSurname
            // 
            this.btnSelectNameSurname.Location = new System.Drawing.Point(154, 74);
            this.btnSelectNameSurname.Name = "btnSelectNameSurname";
            this.btnSelectNameSurname.Size = new System.Drawing.Size(106, 26);
            this.btnSelectNameSurname.TabIndex = 3;
            this.btnSelectNameSurname.Text = "Button 2";
            this.btnSelectNameSurname.UseVisualStyleBackColor = true;
            this.btnSelectNameSurname.Click += new System.EventHandler(this.btnSelectNameSurname_click);
            // 
            // btnSelectAge
            // 
            this.btnSelectAge.Location = new System.Drawing.Point(9, 128);
            this.btnSelectAge.Name = "btnSelectAge";
            this.btnSelectAge.Size = new System.Drawing.Size(110, 29);
            this.btnSelectAge.TabIndex = 4;
            this.btnSelectAge.Text = "Button 3";
            this.btnSelectAge.UseVisualStyleBackColor = true;
            this.btnSelectAge.Click += new System.EventHandler(this.btnSelectAge_click);
            // 
            // btnSelectMultiple
            // 
            this.btnSelectMultiple.Location = new System.Drawing.Point(154, 128);
            this.btnSelectMultiple.Name = "btnSelectMultiple";
            this.btnSelectMultiple.Size = new System.Drawing.Size(106, 28);
            this.btnSelectMultiple.TabIndex = 5;
            this.btnSelectMultiple.Text = "Button 4";
            this.btnSelectMultiple.UseVisualStyleBackColor = true;
            this.btnSelectMultiple.Click += new System.EventHandler(this.btnSelectMultiple_click);
            // 
            // btnSelectLength
            // 
            this.btnSelectLength.Location = new System.Drawing.Point(9, 182);
            this.btnSelectLength.Name = "btnSelectLength";
            this.btnSelectLength.Size = new System.Drawing.Size(109, 26);
            this.btnSelectLength.TabIndex = 6;
            this.btnSelectLength.Text = "Button 5";
            this.btnSelectLength.UseVisualStyleBackColor = true;
            this.btnSelectLength.Click += new System.EventHandler(this.btnSelectLength_click);
            // 
            // btnSelectCompareLength
            // 
            this.btnSelectCompareLength.Location = new System.Drawing.Point(154, 182);
            this.btnSelectCompareLength.Name = "btnSelectCompareLength";
            this.btnSelectCompareLength.Size = new System.Drawing.Size(106, 25);
            this.btnSelectCompareLength.TabIndex = 7;
            this.btnSelectCompareLength.Text = "Button 6";
            this.btnSelectCompareLength.UseVisualStyleBackColor = true;
            this.btnSelectCompareLength.Click += new System.EventHandler(this.btnSelectCompareLength_click);
            // 
            // frmEmployeeGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 409);
            this.Controls.Add(this.btnSelectCompareLength);
            this.Controls.Add(this.btnSelectLength);
            this.Controls.Add(this.btnSelectMultiple);
            this.Controls.Add(this.btnSelectAge);
            this.Controls.Add(this.btnSelectNameSurname);
            this.Controls.Add(this.btnSelectName);
            this.Controls.Add(this.btnOrderByName);
            this.Controls.Add(this.dgvEmployees);
            this.Name = "frmEmployeeGrid";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnOrderByName;
        private System.Windows.Forms.Button btnSelectName;
        private System.Windows.Forms.Button btnSelectNameSurname;
        private System.Windows.Forms.Button btnSelectAge;
        private System.Windows.Forms.Button btnSelectMultiple;
        private System.Windows.Forms.Button btnSelectLength;
        private System.Windows.Forms.Button btnSelectCompareLength;
    }
}

