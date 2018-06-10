namespace ItroSort
{
    partial class Start
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
            this.Create = new System.Windows.Forms.Button();
            this.Intro = new System.Windows.Forms.Button();
            this.Binary = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Pyramidal = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.DataGridView();
            this.comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(268, 4);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 0;
            this.Create.Text = "Создать";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.button1_Click);
            // 
            // Intro
            // 
            this.Intro.Enabled = false;
            this.Intro.Location = new System.Drawing.Point(15, 37);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(75, 23);
            this.Intro.TabIndex = 1;
            this.Intro.Text = "Интро";
            this.Intro.UseVisualStyleBackColor = true;
            this.Intro.Click += new System.EventHandler(this.button2_Click);
            // 
            // Binary
            // 
            this.Binary.Enabled = false;
            this.Binary.Location = new System.Drawing.Point(96, 37);
            this.Binary.Name = "Binary";
            this.Binary.Size = new System.Drawing.Size(75, 23);
            this.Binary.TabIndex = 2;
            this.Binary.Text = "Бинарная";
            this.Binary.UseVisualStyleBackColor = true;
            this.Binary.Click += new System.EventHandler(this.button3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(142, 7);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество элементов";
            // 
            // Pyramidal
            // 
            this.Pyramidal.Enabled = false;
            this.Pyramidal.Location = new System.Drawing.Point(178, 37);
            this.Pyramidal.Name = "Pyramidal";
            this.Pyramidal.Size = new System.Drawing.Size(94, 23);
            this.Pyramidal.TabIndex = 5;
            this.Pyramidal.Text = "Пирамидальная";
            this.Pyramidal.UseVisualStyleBackColor = true;
            this.Pyramidal.Click += new System.EventHandler(this.button4_Click);
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comment,
            this.data});
            this.table.Location = new System.Drawing.Point(12, 66);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.Size = new System.Drawing.Size(327, 278);
            this.table.TabIndex = 6;
            // 
            // comment
            // 
            this.comment.HeaderText = "Комментарий";
            this.comment.Name = "comment";
            this.comment.ReadOnly = true;
            // 
            // data
            // 
            this.data.HeaderText = "Массив";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 356);
            this.Controls.Add(this.table);
            this.Controls.Add(this.Pyramidal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Binary);
            this.Controls.Add(this.Intro);
            this.Controls.Add(this.Create);
            this.MinimumSize = new System.Drawing.Size(367, 395);
            this.Name = "Start";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        public System.Windows.Forms.Button Create;
        public System.Windows.Forms.Button Intro;
        public System.Windows.Forms.Button Binary;
        public System.Windows.Forms.Button Pyramidal;
    }
}

