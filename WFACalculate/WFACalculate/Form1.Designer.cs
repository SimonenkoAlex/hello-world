namespace WFACalculate
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnPow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(143, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(273, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(105, 53);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(87, 30);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(201, 53);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(87, 30);
            this.btnMultiplication.TabIndex = 5;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(294, 53);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(87, 30);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(13, 90);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(87, 30);
            this.btnSin.TabIndex = 7;
            this.btnSin.Text = "SIN";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(201, 90);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(87, 30);
            this.btnLog.TabIndex = 8;
            this.btnLog.Text = "LN";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(106, 89);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(87, 30);
            this.btnCos.TabIndex = 9;
            this.btnCos.Text = "COS";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // btnPow
            // 
            this.btnPow.Location = new System.Drawing.Point(294, 90);
            this.btnPow.Name = "btnPow";
            this.btnPow.Size = new System.Drawing.Size(87, 30);
            this.btnPow.TabIndex = 10;
            this.btnPow.Text = "x^2";
            this.btnPow.UseVisualStyleBackColor = true;
            this.btnPow.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 161);
            this.Controls.Add(this.btnPow);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnPow;
    }
}

