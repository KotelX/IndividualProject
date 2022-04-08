namespace IndividualProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MyArray = new System.Windows.Forms.DataGridView();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.NumericUpDown();
            this.Division = new System.Windows.Forms.NumericUpDown();
            this.Composition = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GetArr = new System.Windows.Forms.Button();
            this.SumArray = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueByIndex = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ArraySize = new System.Windows.Forms.NumericUpDown();
            this.DivArray = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Division)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Composition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SumArray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueByIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArraySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivArray)).BeginInit();
            this.SuspendLayout();
            // 
            // MyArray
            // 
            this.MyArray.AllowUserToAddRows = false;
            this.MyArray.AllowUserToDeleteRows = false;
            this.MyArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyArray.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value});
            this.MyArray.Location = new System.Drawing.Point(12, 12);
            this.MyArray.Name = "MyArray";
            this.MyArray.ReadOnly = true;
            this.MyArray.RowHeadersVisible = false;
            this.MyArray.Size = new System.Drawing.Size(76, 426);
            this.MyArray.TabIndex = 0;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // Index
            // 
            this.Index.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Index.Location = new System.Drawing.Point(170, 12);
            this.Index.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(52, 31);
            this.Index.TabIndex = 1;
            this.Index.ValueChanged += new System.EventHandler(this.Index_ValueChanged);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Division.Location = new System.Drawing.Point(170, 50);
            this.Division.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(52, 31);
            this.Division.TabIndex = 5;
            this.Division.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Composition
            // 
            this.Composition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Composition.Location = new System.Drawing.Point(170, 87);
            this.Composition.Name = "Composition";
            this.Composition.Size = new System.Drawing.Size(52, 31);
            this.Composition.TabIndex = 6;
            this.Composition.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(140, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(145, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(100, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Index";
            // 
            // GetArr
            // 
            this.GetArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetArr.Location = new System.Drawing.Point(136, 340);
            this.GetArr.Name = "GetArr";
            this.GetArr.Size = new System.Drawing.Size(138, 61);
            this.GetArr.TabIndex = 12;
            this.GetArr.Text = "Расчитать";
            this.GetArr.UseVisualStyleBackColor = true;
            this.GetArr.Click += new System.EventHandler(this.GetArr_Click);
            // 
            // SumArray
            // 
            this.SumArray.AllowUserToAddRows = false;
            this.SumArray.AllowUserToDeleteRows = false;
            this.SumArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SumArray.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.SumArray.Location = new System.Drawing.Point(329, 12);
            this.SumArray.Name = "SumArray";
            this.SumArray.RowHeadersVisible = false;
            this.SumArray.Size = new System.Drawing.Size(76, 402);
            this.SumArray.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Value";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // ValueByIndex
            // 
            this.ValueByIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueByIndex.Location = new System.Drawing.Point(242, 14);
            this.ValueByIndex.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ValueByIndex.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ValueByIndex.Name = "ValueByIndex";
            this.ValueByIndex.Size = new System.Drawing.Size(52, 31);
            this.ValueByIndex.TabIndex = 14;
            this.ValueByIndex.ValueChanged += new System.EventHandler(this.ValueByIndex_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(100, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Size";
            // 
            // ArraySize
            // 
            this.ArraySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArraySize.Location = new System.Drawing.Point(170, 407);
            this.ArraySize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ArraySize.Name = "ArraySize";
            this.ArraySize.Size = new System.Drawing.Size(52, 31);
            this.ArraySize.TabIndex = 15;
            this.ArraySize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ArraySize.ValueChanged += new System.EventHandler(this.ArraySize_ValueChanged);
            // 
            // DivArray
            // 
            this.DivArray.AllowUserToAddRows = false;
            this.DivArray.AllowUserToDeleteRows = false;
            this.DivArray.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DivArray.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.DivArray.Location = new System.Drawing.Point(411, 12);
            this.DivArray.Name = "DivArray";
            this.DivArray.RowHeadersVisible = false;
            this.DivArray.Size = new System.Drawing.Size(76, 402);
            this.DivArray.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(352, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "+";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(438, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DivArray);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ArraySize);
            this.Controls.Add(this.ValueByIndex);
            this.Controls.Add(this.SumArray);
            this.Controls.Add(this.GetArr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Composition);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.MyArray);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MyArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Division)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Composition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SumArray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValueByIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArraySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DivArray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MyArray;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.NumericUpDown Index;
        private System.Windows.Forms.NumericUpDown Division;
        private System.Windows.Forms.NumericUpDown Composition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button GetArr;
        private System.Windows.Forms.DataGridView SumArray;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.NumericUpDown ValueByIndex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ArraySize;
        private System.Windows.Forms.DataGridView DivArray;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

