
namespace CourseWork
{
    partial class FormD
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Номер1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Проблема1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фио1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Фио2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Дата1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Хеш";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ФИО работника";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Специальность";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить работника";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить работника";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Поиск работника";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(365, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Назад ко всем работникам";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Номер1,
            this.Проблема1,
            this.Фио1,
            this.Фио2,
            this.Дата1});
            this.dataGridView2.Location = new System.Drawing.Point(610, 46);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.Size = new System.Drawing.Size(564, 207);
            this.dataGridView2.TabIndex = 12;
            // 
            // Номер1
            // 
            this.Номер1.HeaderText = "Дата заявки";
            this.Номер1.MinimumWidth = 8;
            this.Номер1.Name = "Номер1";
            // 
            // Проблема1
            // 
            this.Проблема1.HeaderText = "Описание проблемы";
            this.Проблема1.MinimumWidth = 8;
            this.Проблема1.Name = "Проблема1";
            // 
            // Фио1
            // 
            this.Фио1.HeaderText = "ФИО заказчика";
            this.Фио1.MinimumWidth = 8;
            this.Фио1.Name = "Фио1";
            // 
            // Фио2
            // 
            this.Фио2.HeaderText = "ФИО работника";
            this.Фио2.MinimumWidth = 8;
            this.Фио2.Name = "Фио2";
            // 
            // Дата1
            // 
            this.Дата1.HeaderText = "Номер телефона";
            this.Дата1.MinimumWidth = 8;
            this.Дата1.Name = "Дата1";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(610, 268);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 47);
            this.button8.TabIndex = 14;
            this.button8.Text = "Добавить обработанную заявку";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(763, 268);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 47);
            this.button9.TabIndex = 15;
            this.button9.Text = "Удалить обработанную заявку";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(920, 268);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(92, 47);
            this.button10.TabIndex = 16;
            this.button10.Text = "Поиск по работнику";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1082, 268);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(92, 47);
            this.button11.TabIndex = 17;
            this.button11.Text = "Назад ко всем обработанным заявкам";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(442, 382);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(92, 49);
            this.button12.TabIndex = 18;
            this.button12.Text = "Назад к выбору справочника";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(578, 382);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(92, 49);
            this.button13.TabIndex = 19;
            this.button13.Text = "Выйти и сохранить";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // FormD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1265, 563);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormD";
            this.Text = "FormD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Номер1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Проблема1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фио1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Фио2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Дата1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}