namespace Lab3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTablucia = new System.Windows.Forms.Button();
            this.buttonCalculatePolinom = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonCalculateAtPoint = new System.Windows.Forms.Button();
            this.buttonFillTableFromFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxPolynom = new System.Windows.Forms.TextBox();
            this.buttonFillTableWithTabulation = new System.Windows.Forms.Button();
            this.tableInterpolationPoints = new System.Windows.Forms.DataGridView();
            this.x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableInterpolationPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Кількість вузлів:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "5";
            // 
            // buttonTablucia
            // 
            this.buttonTablucia.Location = new System.Drawing.Point(12, 38);
            this.buttonTablucia.Name = "buttonTablucia";
            this.buttonTablucia.Size = new System.Drawing.Size(157, 40);
            this.buttonTablucia.TabIndex = 2;
            this.buttonTablucia.Text = "Створити таблицю розділених різниць";
            this.buttonTablucia.UseVisualStyleBackColor = true;
            this.buttonTablucia.Click += new System.EventHandler(this.buttonCreateTable_Click);
            // 
            // buttonCalculatePolinom
            // 
            this.buttonCalculatePolinom.Location = new System.Drawing.Point(88, 84);
            this.buttonCalculatePolinom.Name = "buttonCalculatePolinom";
            this.buttonCalculatePolinom.Size = new System.Drawing.Size(94, 53);
            this.buttonCalculatePolinom.TabIndex = 3;
            this.buttonCalculatePolinom.Text = "Обчислити розділені різниці";
            this.buttonCalculatePolinom.UseVisualStyleBackColor = true;
            this.buttonCalculatePolinom.Click += new System.EventHandler(this.buttonCalculatePolynom_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Точка інтерполяції: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 5;
            // 
            // buttonCalculateAtPoint
            // 
            this.buttonCalculateAtPoint.Location = new System.Drawing.Point(2, 169);
            this.buttonCalculateAtPoint.Name = "buttonCalculateAtPoint";
            this.buttonCalculateAtPoint.Size = new System.Drawing.Size(170, 30);
            this.buttonCalculateAtPoint.TabIndex = 6;
            this.buttonCalculateAtPoint.Text = "Додати точку";
            this.buttonCalculateAtPoint.UseVisualStyleBackColor = true;
            this.buttonCalculateAtPoint.Click += new System.EventHandler(this.buttonCalculateAtPoint_Click);
            // 
            // buttonFillTableFromFile
            // 
            this.buttonFillTableFromFile.Location = new System.Drawing.Point(2, 324);
            this.buttonFillTableFromFile.Name = "buttonFillTableFromFile";
            this.buttonFillTableFromFile.Size = new System.Drawing.Size(206, 30);
            this.buttonFillTableFromFile.TabIndex = 7;
            this.buttonFillTableFromFile.Text = "Зчитатити дані  з файлу";
            this.buttonFillTableFromFile.UseVisualStyleBackColor = true;
            this.buttonFillTableFromFile.Click += new System.EventHandler(this.buttonFillTableFromFile_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // textBoxPolynom
            // 
            this.textBoxPolynom.Location = new System.Drawing.Point(15, 267);
            this.textBoxPolynom.Multiline = true;
            this.textBoxPolynom.Name = "textBoxPolynom";
            this.textBoxPolynom.ReadOnly = true;
            this.textBoxPolynom.Size = new System.Drawing.Size(157, 41);
            this.textBoxPolynom.TabIndex = 8;
            this.textBoxPolynom.TextChanged += new System.EventHandler(this.textBoxPolynom_TextChanged);
            // 
            // buttonFillTableWithTabulation
            // 
            this.buttonFillTableWithTabulation.Location = new System.Drawing.Point(-2, 84);
            this.buttonFillTableWithTabulation.Name = "buttonFillTableWithTabulation";
            this.buttonFillTableWithTabulation.Size = new System.Drawing.Size(84, 53);
            this.buttonFillTableWithTabulation.TabIndex = 9;
            this.buttonFillTableWithTabulation.Text = "Табуляція функції";
            this.buttonFillTableWithTabulation.UseVisualStyleBackColor = true;
            this.buttonFillTableWithTabulation.Click += new System.EventHandler(this.buttonFillTableWithTabulation_Click);
            // 
            // tableInterpolationPoints
            // 
            this.tableInterpolationPoints.AllowUserToAddRows = false;
            this.tableInterpolationPoints.AllowUserToDeleteRows = false;
            this.tableInterpolationPoints.AllowUserToResizeColumns = false;
            this.tableInterpolationPoints.AllowUserToResizeRows = false;
            this.tableInterpolationPoints.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.tableInterpolationPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableInterpolationPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.x,
            this.y,
            this.Column1,
            this.Column2,
            this.Column3});
            this.tableInterpolationPoints.Location = new System.Drawing.Point(481, 32);
            this.tableInterpolationPoints.Name = "tableInterpolationPoints";
            this.tableInterpolationPoints.ReadOnly = true;
            this.tableInterpolationPoints.RowHeadersVisible = false;
            this.tableInterpolationPoints.Size = new System.Drawing.Size(461, 237);
            this.tableInterpolationPoints.TabIndex = 10;
            // 
            // x
            // 
            this.x.Frozen = true;
            this.x.HeaderText = "x";
            this.x.Name = "x";
            this.x.ReadOnly = true;
            this.x.Width = 50;
            // 
            // y
            // 
            this.y.Frozen = true;
            this.y.HeaderText = "L(x)";
            this.y.Name = "y";
            this.y.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "F(x)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            dataGridViewCellStyle55.Format = "E4";
            dataGridViewCellStyle55.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle55;
            this.Column2.HeaderText = "W(x)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle56.Format = "E4";
            dataGridViewCellStyle56.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle56;
            this.Column3.HeaderText = "| F(x) - L(x) |";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(941, 384);
            this.Controls.Add(this.tableInterpolationPoints);
            this.Controls.Add(this.buttonFillTableWithTabulation);
            this.Controls.Add(this.textBoxPolynom);
            this.Controls.Add(this.buttonFillTableFromFile);
            this.Controls.Add(this.buttonCalculateAtPoint);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCalculatePolinom);
            this.Controls.Add(this.buttonTablucia);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Інтерполяція функцій многочленом Ньютона";
            ((System.ComponentModel.ISupportInitialize)(this.tableInterpolationPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTablucia;
        private System.Windows.Forms.Button buttonCalculatePolinom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonCalculateAtPoint;
        private System.Windows.Forms.Button buttonFillTableFromFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxPolynom;
        private System.Windows.Forms.Button buttonFillTableWithTabulation;
        private System.Windows.Forms.DataGridView tableInterpolationPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn x;
        private System.Windows.Forms.DataGridViewTextBoxColumn y;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

