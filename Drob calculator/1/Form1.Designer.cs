namespace _1
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
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB4 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTplus = new System.Windows.Forms.Button();
            this.BTminus = new System.Windows.Forms.Button();
            this.BTdel = new System.Windows.Forms.Button();
            this.BTmult = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB1.Location = new System.Drawing.Point(28, 27);
            this.TB1.Margin = new System.Windows.Forms.Padding(7);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(41, 33);
            this.TB1.TabIndex = 0;
            // 
            // TB2
            // 
            this.TB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB2.Location = new System.Drawing.Point(28, 85);
            this.TB2.Margin = new System.Windows.Forms.Padding(7);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(41, 33);
            this.TB2.TabIndex = 1;
            // 
            // TB4
            // 
            this.TB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB4.Location = new System.Drawing.Point(225, 85);
            this.TB4.Margin = new System.Windows.Forms.Padding(7);
            this.TB4.Name = "TB4";
            this.TB4.Size = new System.Drawing.Size(41, 33);
            this.TB4.TabIndex = 3;
            // 
            // TB3
            // 
            this.TB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB3.Location = new System.Drawing.Point(225, 27);
            this.TB3.Margin = new System.Windows.Forms.Padding(7);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(41, 33);
            this.TB3.TabIndex = 2;
            // 
            // TB5
            // 
            this.TB5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB5.Location = new System.Drawing.Point(321, 55);
            this.TB5.Margin = new System.Windows.Forms.Padding(7);
            this.TB5.Name = "TB5";
            this.TB5.Size = new System.Drawing.Size(128, 33);
            this.TB5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(280, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "=";
            // 
            // BTplus
            // 
            this.BTplus.Location = new System.Drawing.Point(83, 16);
            this.BTplus.Margin = new System.Windows.Forms.Padding(7);
            this.BTplus.Name = "BTplus";
            this.BTplus.Size = new System.Drawing.Size(54, 51);
            this.BTplus.TabIndex = 7;
            this.BTplus.Text = "+";
            this.BTplus.UseVisualStyleBackColor = true;
            this.BTplus.Click += new System.EventHandler(this.BTplus_Click);
            // 
            // BTminus
            // 
            this.BTminus.Location = new System.Drawing.Point(151, 16);
            this.BTminus.Margin = new System.Windows.Forms.Padding(7);
            this.BTminus.Name = "BTminus";
            this.BTminus.Size = new System.Drawing.Size(54, 51);
            this.BTminus.TabIndex = 8;
            this.BTminus.Text = "-";
            this.BTminus.UseVisualStyleBackColor = true;
            this.BTminus.Click += new System.EventHandler(this.BTminus_Click);
            // 
            // BTdel
            // 
            this.BTdel.Location = new System.Drawing.Point(151, 81);
            this.BTdel.Margin = new System.Windows.Forms.Padding(7);
            this.BTdel.Name = "BTdel";
            this.BTdel.Size = new System.Drawing.Size(54, 51);
            this.BTdel.TabIndex = 10;
            this.BTdel.Text = "/";
            this.BTdel.UseVisualStyleBackColor = true;
            this.BTdel.Click += new System.EventHandler(this.BTdel_Click);
            // 
            // BTmult
            // 
            this.BTmult.Location = new System.Drawing.Point(83, 81);
            this.BTmult.Margin = new System.Windows.Forms.Padding(7);
            this.BTmult.Name = "BTmult";
            this.BTmult.Size = new System.Drawing.Size(54, 51);
            this.BTmult.TabIndex = 9;
            this.BTmult.Text = "x";
            this.BTmult.UseVisualStyleBackColor = true;
            this.BTmult.Click += new System.EventHandler(this.BTmult_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(22, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 10);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(219, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 10);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 148);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTdel);
            this.Controls.Add(this.BTmult);
            this.Controls.Add(this.BTminus);
            this.Controls.Add(this.BTplus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB5);
            this.Controls.Add(this.TB4);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Drobi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB4;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTplus;
        private System.Windows.Forms.Button BTminus;
        private System.Windows.Forms.Button BTdel;
        private System.Windows.Forms.Button BTmult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

