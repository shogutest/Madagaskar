namespace Kalkulator
{
    partial class Form1
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Dodawanie = new System.Windows.Forms.Button();
            this.Odejmowanie = new System.Windows.Forms.Button();
            this.Mnozenie = new System.Windows.Forms.Button();
            this.Dzielenie = new System.Windows.Forms.Button();
            this.Wyjscie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(94, 23);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(94, 67);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtWynik
            // 
            this.txtWynik.Location = new System.Drawing.Point(431, 45);
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.ReadOnly = true;
            this.txtWynik.Size = new System.Drawing.Size(100, 20);
            this.txtWynik.TabIndex = 2;
            this.txtWynik.TextChanged += new System.EventHandler(this.txtWynik_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczba A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "LiczbaB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wynik obliczen";
            // 
            // Dodawanie
            // 
            this.Dodawanie.Location = new System.Drawing.Point(269, 23);
            this.Dodawanie.Name = "Dodawanie";
            this.Dodawanie.Size = new System.Drawing.Size(75, 23);
            this.Dodawanie.TabIndex = 6;
            this.Dodawanie.Text = "dodawanie";
            this.Dodawanie.UseVisualStyleBackColor = true;
            this.Dodawanie.Click += new System.EventHandler(this.Dodawanie_Click);
            // 
            // Odejmowanie
            // 
            this.Odejmowanie.Location = new System.Drawing.Point(269, 53);
            this.Odejmowanie.Name = "Odejmowanie";
            this.Odejmowanie.Size = new System.Drawing.Size(75, 23);
            this.Odejmowanie.TabIndex = 7;
            this.Odejmowanie.Text = "odejmowanie";
            this.Odejmowanie.UseVisualStyleBackColor = true;
            this.Odejmowanie.Click += new System.EventHandler(this.Odejmowanie_Click);
            // 
            // Mnozenie
            // 
            this.Mnozenie.Location = new System.Drawing.Point(269, 83);
            this.Mnozenie.Name = "Mnozenie";
            this.Mnozenie.Size = new System.Drawing.Size(75, 23);
            this.Mnozenie.TabIndex = 8;
            this.Mnozenie.Text = "mnozenie";
            this.Mnozenie.UseVisualStyleBackColor = true;
            this.Mnozenie.Click += new System.EventHandler(this.Mnozenie_Click);
            // 
            // Dzielenie
            // 
            this.Dzielenie.Location = new System.Drawing.Point(269, 113);
            this.Dzielenie.Name = "Dzielenie";
            this.Dzielenie.Size = new System.Drawing.Size(75, 23);
            this.Dzielenie.TabIndex = 9;
            this.Dzielenie.Text = "dzielenie";
            this.Dzielenie.UseVisualStyleBackColor = true;
            this.Dzielenie.Click += new System.EventHandler(this.Dzielenie_Click);
            // 
            // Wyjscie
            // 
            this.Wyjscie.Location = new System.Drawing.Point(269, 173);
            this.Wyjscie.Name = "Wyjscie";
            this.Wyjscie.Size = new System.Drawing.Size(75, 23);
            this.Wyjscie.TabIndex = 11;
            this.Wyjscie.Text = "wyjscie";
            this.Wyjscie.UseVisualStyleBackColor = true;
            this.Wyjscie.Click += new System.EventHandler(this.Wyjscie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 261);
            this.Controls.Add(this.Wyjscie);
            this.Controls.Add(this.Dzielenie);
            this.Controls.Add(this.Mnozenie);
            this.Controls.Add(this.Odejmowanie);
            this.Controls.Add(this.Dodawanie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWynik);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Dodawanie;
        private System.Windows.Forms.Button Odejmowanie;
        private System.Windows.Forms.Button Mnozenie;
        private System.Windows.Forms.Button Dzielenie;
        private System.Windows.Forms.Button Wyjscie;
    }
}

