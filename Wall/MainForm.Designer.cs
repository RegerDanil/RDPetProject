namespace Wall
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_1 = new System.Windows.Forms.TextBox();
            this.textBox_2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.calculate_button = new System.Windows.Forms.Button();
            this.add_window = new System.Windows.Forms.Button();
            this.add_door = new System.Windows.Forms.Button();
            this.add_pilar = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.massive_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Длина";
            // 
            // textBox_1
            // 
            this.textBox_1.Location = new System.Drawing.Point(64, 16);
            this.textBox_1.Name = "textBox_1";
            this.textBox_1.Size = new System.Drawing.Size(50, 20);
            this.textBox_1.TabIndex = 1;
            this.textBox_1.Text = "10";
            this.textBox_1.TextChanged += new System.EventHandler(this.tb_textChanged);
            this.textBox_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_key_pressed);
            // 
            // textBox_2
            // 
            this.textBox_2.Location = new System.Drawing.Point(64, 59);
            this.textBox_2.Name = "textBox_2";
            this.textBox_2.Size = new System.Drawing.Size(50, 20);
            this.textBox_2.TabIndex = 3;
            this.textBox_2.Text = "10";
            this.textBox_2.TextChanged += new System.EventHandler(this.tb_textChanged);
            this.textBox_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_key_pressed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Высота";
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(12, 247);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(139, 23);
            this.calculate_button.TabIndex = 4;
            this.calculate_button.Text = "Рассчитать";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // add_window
            // 
            this.add_window.Location = new System.Drawing.Point(12, 94);
            this.add_window.Name = "add_window";
            this.add_window.Size = new System.Drawing.Size(139, 23);
            this.add_window.TabIndex = 5;
            this.add_window.Text = "Добавить окно...";
            this.add_window.UseVisualStyleBackColor = true;
            this.add_window.Click += new System.EventHandler(this.add_window_Click);
            // 
            // add_door
            // 
            this.add_door.Location = new System.Drawing.Point(12, 123);
            this.add_door.Name = "add_door";
            this.add_door.Size = new System.Drawing.Size(139, 23);
            this.add_door.TabIndex = 6;
            this.add_door.Text = "Добавить дверь...";
            this.add_door.UseVisualStyleBackColor = true;
            this.add_door.Click += new System.EventHandler(this.add_door_Click);
            // 
            // add_pilar
            // 
            this.add_pilar.Location = new System.Drawing.Point(12, 152);
            this.add_pilar.Name = "add_pilar";
            this.add_pilar.Size = new System.Drawing.Size(139, 23);
            this.add_pilar.TabIndex = 7;
            this.add_pilar.Text = "Добавить колонну...";
            this.add_pilar.UseVisualStyleBackColor = true;
            this.add_pilar.Click += new System.EventHandler(this.add_pilar_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(12, 181);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(139, 23);
            this.clear_button.TabIndex = 8;
            this.clear_button.Text = "Очистить";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // massive_button
            // 
            this.massive_button.Location = new System.Drawing.Point(12, 218);
            this.massive_button.Name = "massive_button";
            this.massive_button.Size = new System.Drawing.Size(139, 23);
            this.massive_button.TabIndex = 9;
            this.massive_button.Text = "Массив";
            this.massive_button.UseVisualStyleBackColor = true;
            this.massive_button.Click += new System.EventHandler(this.massive_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 282);
            this.Controls.Add(this.massive_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.add_pilar);
            this.Controls.Add(this.add_door);
            this.Controls.Add(this.add_window);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.textBox_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стена";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_1;
        private System.Windows.Forms.TextBox textBox_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button add_window;
        private System.Windows.Forms.Button add_door;
        private System.Windows.Forms.Button add_pilar;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button massive_button;
    }
}

