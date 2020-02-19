namespace WindowsFormsApp
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
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNazwisko = new System.Windows.Forms.Label();
            this.nazwisko = new System.Windows.Forms.TextBox();
            this.textBoxWiek = new System.Windows.Forms.TextBox();
            this.llll = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(126, 34);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imie:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.AutoSize = true;
            this.textBoxNazwisko.Location = new System.Drawing.Point(38, 104);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(53, 13);
            this.textBoxNazwisko.TabIndex = 2;
            this.textBoxNazwisko.Text = "Nazwisko";
            // 
            // nazwisko
            // 
            this.nazwisko.Location = new System.Drawing.Point(126, 97);
            this.nazwisko.Name = "nazwisko";
            this.nazwisko.Size = new System.Drawing.Size(100, 20);
            this.nazwisko.TabIndex = 3;
            this.nazwisko.TextChanged += new System.EventHandler(this.nazwisko_TextChanged);
            // 
            // textBoxWiek
            // 
            this.textBoxWiek.Location = new System.Drawing.Point(126, 171);
            this.textBoxWiek.Name = "textBoxWiek";
            this.textBoxWiek.Size = new System.Drawing.Size(100, 20);
            this.textBoxWiek.TabIndex = 4;
            // 
            // llll
            // 
            this.llll.AutoSize = true;
            this.llll.Location = new System.Drawing.Point(38, 178);
            this.llll.Name = "llll";
            this.llll.Size = new System.Drawing.Size(32, 13);
            this.llll.TabIndex = 5;
            this.llll.Text = "Wiek";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.Location = new System.Drawing.Point(126, 293);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(38, 13);
            this.labelWynik.TabIndex = 7;
            this.labelWynik.Text = "label 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 361);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.llll);
            this.Controls.Add(this.textBoxWiek);
            this.Controls.Add(this.nazwisko);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxImie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textBoxNazwisko;
        private System.Windows.Forms.TextBox nazwisko;
        private System.Windows.Forms.TextBox textBoxWiek;
        private System.Windows.Forms.Label llll;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelWynik;
    }
}

