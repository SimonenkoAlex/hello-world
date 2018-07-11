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
            this.Addition = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.Logarithm = new System.Windows.Forms.Button();
            this.Cosine = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Tangent = new System.Windows.Forms.Button();
            this.Arcsine = new System.Windows.Forms.Button();
            this.Arccosine = new System.Windows.Forms.Button();
            this.Arctangent = new System.Windows.Forms.Button();
            this.Exponent = new System.Windows.Forms.Button();
            this.Indicative = new System.Windows.Forms.Button();
            this.Hyperbolic = new System.Windows.Forms.Button();
            this.Negative = new System.Windows.Forms.Button();
            this.Module = new System.Windows.Forms.Button();
            this.Log10 = new System.Windows.Forms.Button();
            this.Indicative10 = new System.Windows.Forms.Button();
            this.Powerxy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(324, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 2;
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addition.Location = new System.Drawing.Point(15, 160);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(87, 30);
            this.Addition.TabIndex = 3;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.btn_Click);
            // 
            // Subtraction
            // 
            this.Subtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Subtraction.Location = new System.Drawing.Point(15, 125);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(87, 30);
            this.Subtraction.TabIndex = 4;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.btn_Click);
            // 
            // Multiplication
            // 
            this.Multiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Multiplication.Location = new System.Drawing.Point(15, 89);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(87, 30);
            this.Multiplication.TabIndex = 5;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.btn_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Division.Location = new System.Drawing.Point(15, 53);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(87, 30);
            this.Division.TabIndex = 6;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.btn_Click);
            // 
            // Sinus
            // 
            this.Sinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sinus.Location = new System.Drawing.Point(201, 52);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(87, 30);
            this.Sinus.TabIndex = 7;
            this.Sinus.Text = "SIN";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Logarithm
            // 
            this.Logarithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Logarithm.Location = new System.Drawing.Point(201, 124);
            this.Logarithm.Name = "Logarithm";
            this.Logarithm.Size = new System.Drawing.Size(87, 30);
            this.Logarithm.TabIndex = 8;
            this.Logarithm.Text = "LN";
            this.Logarithm.UseVisualStyleBackColor = true;
            this.Logarithm.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Cosine
            // 
            this.Cosine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cosine.Location = new System.Drawing.Point(294, 52);
            this.Cosine.Name = "Cosine";
            this.Cosine.Size = new System.Drawing.Size(87, 30);
            this.Cosine.TabIndex = 9;
            this.Cosine.Text = "COS";
            this.Cosine.UseVisualStyleBackColor = true;
            this.Cosine.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Power
            // 
            this.Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Power.Location = new System.Drawing.Point(201, 160);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(87, 30);
            this.Power.TabIndex = 10;
            this.Power.Text = "x^2";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Tangent
            // 
            this.Tangent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tangent.Location = new System.Drawing.Point(387, 52);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(87, 30);
            this.Tangent.TabIndex = 11;
            this.Tangent.Text = "TAN";
            this.Tangent.UseVisualStyleBackColor = true;
            this.Tangent.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Arcsine
            // 
            this.Arcsine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arcsine.Location = new System.Drawing.Point(201, 88);
            this.Arcsine.Name = "Arcsine";
            this.Arcsine.Size = new System.Drawing.Size(87, 30);
            this.Arcsine.TabIndex = 12;
            this.Arcsine.Text = "ARCSIN";
            this.Arcsine.UseVisualStyleBackColor = true;
            this.Arcsine.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Arccosine
            // 
            this.Arccosine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arccosine.Location = new System.Drawing.Point(294, 88);
            this.Arccosine.Name = "Arccosine";
            this.Arccosine.Size = new System.Drawing.Size(87, 30);
            this.Arccosine.TabIndex = 13;
            this.Arccosine.Text = "ARCCOS";
            this.Arccosine.UseVisualStyleBackColor = true;
            this.Arccosine.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Arctangent
            // 
            this.Arctangent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Arctangent.Location = new System.Drawing.Point(387, 88);
            this.Arctangent.Name = "Arctangent";
            this.Arctangent.Size = new System.Drawing.Size(87, 30);
            this.Arctangent.TabIndex = 15;
            this.Arctangent.Text = "ARCTAN";
            this.Arctangent.UseVisualStyleBackColor = true;
            this.Arctangent.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Exponent
            // 
            this.Exponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exponent.Location = new System.Drawing.Point(294, 126);
            this.Exponent.Name = "Exponent";
            this.Exponent.Size = new System.Drawing.Size(87, 30);
            this.Exponent.TabIndex = 16;
            this.Exponent.Text = "e^x";
            this.Exponent.UseVisualStyleBackColor = true;
            this.Exponent.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Indicative
            // 
            this.Indicative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Indicative.Location = new System.Drawing.Point(387, 126);
            this.Indicative.Name = "Indicative";
            this.Indicative.Size = new System.Drawing.Size(87, 30);
            this.Indicative.TabIndex = 17;
            this.Indicative.Text = "2^x";
            this.Indicative.UseVisualStyleBackColor = true;
            this.Indicative.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Hyperbolic
            // 
            this.Hyperbolic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Hyperbolic.Location = new System.Drawing.Point(294, 160);
            this.Hyperbolic.Name = "Hyperbolic";
            this.Hyperbolic.Size = new System.Drawing.Size(87, 30);
            this.Hyperbolic.TabIndex = 18;
            this.Hyperbolic.Text = "1/x";
            this.Hyperbolic.UseVisualStyleBackColor = true;
            this.Hyperbolic.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Negative
            // 
            this.Negative.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Negative.Location = new System.Drawing.Point(387, 160);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(87, 30);
            this.Negative.TabIndex = 19;
            this.Negative.Text = "-x";
            this.Negative.UseVisualStyleBackColor = true;
            this.Negative.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Module
            // 
            this.Module.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Module.Location = new System.Drawing.Point(108, 160);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(87, 30);
            this.Module.TabIndex = 20;
            this.Module.Text = "|x|";
            this.Module.UseVisualStyleBackColor = true;
            this.Module.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Log10
            // 
            this.Log10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log10.Location = new System.Drawing.Point(108, 126);
            this.Log10.Name = "Log10";
            this.Log10.Size = new System.Drawing.Size(87, 30);
            this.Log10.TabIndex = 21;
            this.Log10.Text = "LOG10";
            this.Log10.UseVisualStyleBackColor = true;
            this.Log10.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Indicative10
            // 
            this.Indicative10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Indicative10.Location = new System.Drawing.Point(108, 89);
            this.Indicative10.Name = "Indicative10";
            this.Indicative10.Size = new System.Drawing.Size(87, 30);
            this.Indicative10.TabIndex = 22;
            this.Indicative10.Text = "10^x";
            this.Indicative10.UseVisualStyleBackColor = true;
            this.Indicative10.Click += new System.EventHandler(this.btn_ClickOneArgument);
            // 
            // Powerxy
            // 
            this.Powerxy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Powerxy.Location = new System.Drawing.Point(109, 53);
            this.Powerxy.Name = "Powerxy";
            this.Powerxy.Size = new System.Drawing.Size(87, 30);
            this.Powerxy.TabIndex = 23;
            this.Powerxy.Text = "x^y";
            this.Powerxy.UseVisualStyleBackColor = true;
            this.Powerxy.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(483, 202);
            this.Controls.Add(this.Powerxy);
            this.Controls.Add(this.Indicative10);
            this.Controls.Add(this.Log10);
            this.Controls.Add(this.Module);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.Hyperbolic);
            this.Controls.Add(this.Indicative);
            this.Controls.Add(this.Exponent);
            this.Controls.Add(this.Arctangent);
            this.Controls.Add(this.Arccosine);
            this.Controls.Add(this.Arcsine);
            this.Controls.Add(this.Tangent);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Cosine);
            this.Controls.Add(this.Logarithm);
            this.Controls.Add(this.Sinus);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplication);
            this.Controls.Add(this.Subtraction);
            this.Controls.Add(this.Addition);
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
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Logarithm;
        private System.Windows.Forms.Button Cosine;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button Tangent;
        private System.Windows.Forms.Button Arcsine;
        private System.Windows.Forms.Button Arccosine;
        private System.Windows.Forms.Button Arctangent;
        private System.Windows.Forms.Button Exponent;
        private System.Windows.Forms.Button Indicative;
        private System.Windows.Forms.Button Hyperbolic;
        private System.Windows.Forms.Button Negative;
        private System.Windows.Forms.Button Module;
        private System.Windows.Forms.Button Log10;
        private System.Windows.Forms.Button Indicative10;
        private System.Windows.Forms.Button Powerxy;
    }
}

