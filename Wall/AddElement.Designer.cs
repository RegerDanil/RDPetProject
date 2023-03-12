namespace Wall
{
    partial class AddElement
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
            this.posY_tb = new System.Windows.Forms.TextBox();
            this.posY_lb = new System.Windows.Forms.Label();
            this.posX_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.height_tb = new System.Windows.Forms.TextBox();
            this.height_lb = new System.Windows.Forms.Label();
            this.width_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // posY_tb
            // 
            this.posY_tb.Location = new System.Drawing.Point(32, 35);
            this.posY_tb.Name = "posY_tb";
            this.posY_tb.Size = new System.Drawing.Size(50, 20);
            this.posY_tb.TabIndex = 7;
            // 
            // posY_lb
            // 
            this.posY_lb.AutoSize = true;
            this.posY_lb.Location = new System.Drawing.Point(12, 38);
            this.posY_lb.Name = "posY_lb";
            this.posY_lb.Size = new System.Drawing.Size(17, 13);
            this.posY_lb.TabIndex = 6;
            this.posY_lb.Text = "Y:";
            // 
            // posX_tb
            // 
            this.posX_tb.Location = new System.Drawing.Point(32, 9);
            this.posX_tb.Name = "posX_tb";
            this.posX_tb.Size = new System.Drawing.Size(50, 20);
            this.posX_tb.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "X:";
            // 
            // height_tb
            // 
            this.height_tb.Location = new System.Drawing.Point(149, 35);
            this.height_tb.Name = "height_tb";
            this.height_tb.Size = new System.Drawing.Size(50, 20);
            this.height_tb.TabIndex = 11;
            // 
            // height_lb
            // 
            this.height_lb.AutoSize = true;
            this.height_lb.Location = new System.Drawing.Point(97, 38);
            this.height_lb.Name = "height_lb";
            this.height_lb.Size = new System.Drawing.Size(45, 13);
            this.height_lb.TabIndex = 10;
            this.height_lb.Text = "Высота";
            // 
            // width_tb
            // 
            this.width_tb.Location = new System.Drawing.Point(149, 9);
            this.width_tb.Name = "width_tb";
            this.width_tb.Size = new System.Drawing.Size(50, 20);
            this.width_tb.TabIndex = 9;
            this.width_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_keyPressed);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Длина";
            // 
            // ok_button
            // 
            this.ok_button.Location = new System.Drawing.Point(134, 71);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 12;
            this.ok_button.Text = "ОК";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(12, 71);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 13;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // AddElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 106);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.height_tb);
            this.Controls.Add(this.height_lb);
            this.Controls.Add(this.width_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.posY_tb);
            this.Controls.Add(this.posY_lb);
            this.Controls.Add(this.posX_tb);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddElement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddElement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox posY_tb;
        private System.Windows.Forms.Label posY_lb;
        private System.Windows.Forms.TextBox posX_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox height_tb;
        private System.Windows.Forms.Label height_lb;
        private System.Windows.Forms.TextBox width_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
    }
}