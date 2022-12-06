namespace Student
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
            this.lblBrojIndeksa = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblGodinaUpisa = new System.Windows.Forms.Label();
            this.lblGodinaRodjenja = new System.Windows.Forms.Label();
            this.txtIndeks = new System.Windows.Forms.MaskedTextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtGodinaUpisa = new System.Windows.Forms.MaskedTextBox();
            this.txtGodinaRodjenja = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBrojIndeksa
            // 
            this.lblBrojIndeksa.AutoSize = true;
            this.lblBrojIndeksa.Location = new System.Drawing.Point(80, 58);
            this.lblBrojIndeksa.Name = "lblBrojIndeksa";
            this.lblBrojIndeksa.Size = new System.Drawing.Size(88, 16);
            this.lblBrojIndeksa.TabIndex = 0;
            this.lblBrojIndeksa.Text = "Broj indeksa: ";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(80, 93);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(35, 16);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime: ";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(80, 132);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(56, 16);
            this.lblPrezime.TabIndex = 2;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblGodinaUpisa
            // 
            this.lblGodinaUpisa.AutoSize = true;
            this.lblGodinaUpisa.Location = new System.Drawing.Point(80, 174);
            this.lblGodinaUpisa.Name = "lblGodinaUpisa";
            this.lblGodinaUpisa.Size = new System.Drawing.Size(109, 16);
            this.lblGodinaUpisa.TabIndex = 3;
            this.lblGodinaUpisa.Text = "Upisana godina: ";
            // 
            // lblGodinaRodjenja
            // 
            this.lblGodinaRodjenja.AutoSize = true;
            this.lblGodinaRodjenja.Location = new System.Drawing.Point(80, 220);
            this.lblGodinaRodjenja.Name = "lblGodinaRodjenja";
            this.lblGodinaRodjenja.Size = new System.Drawing.Size(109, 16);
            this.lblGodinaRodjenja.TabIndex = 4;
            this.lblGodinaRodjenja.Text = "Godina rodjenja: ";
            // 
            // txtIndeks
            // 
            this.txtIndeks.Location = new System.Drawing.Point(235, 52);
            this.txtIndeks.Mask = "999";
            this.txtIndeks.Name = "txtIndeks";
            this.txtIndeks.Size = new System.Drawing.Size(100, 22);
            this.txtIndeks.TabIndex = 5;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(235, 87);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 22);
            this.txtIme.TabIndex = 6;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(235, 126);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 22);
            this.txtPrezime.TabIndex = 7;
            // 
            // txtGodinaUpisa
            // 
            this.txtGodinaUpisa.Location = new System.Drawing.Point(235, 168);
            this.txtGodinaUpisa.Mask = "9";
            this.txtGodinaUpisa.Name = "txtGodinaUpisa";
            this.txtGodinaUpisa.Size = new System.Drawing.Size(100, 22);
            this.txtGodinaUpisa.TabIndex = 8;
            // 
            // txtGodinaRodjenja
            // 
            this.txtGodinaRodjenja.Location = new System.Drawing.Point(235, 217);
            this.txtGodinaRodjenja.Mask = "9999";
            this.txtGodinaRodjenja.Name = "txtGodinaRodjenja";
            this.txtGodinaRodjenja.Size = new System.Drawing.Size(100, 22);
            this.txtGodinaRodjenja.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(299, 287);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 54);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Sacuvaj u folder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtGodinaRodjenja);
            this.Controls.Add(this.txtGodinaUpisa);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtIndeks);
            this.Controls.Add(this.lblGodinaRodjenja);
            this.Controls.Add(this.lblGodinaUpisa);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblBrojIndeksa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrojIndeksa;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblGodinaUpisa;
        private System.Windows.Forms.Label lblGodinaRodjenja;
        private System.Windows.Forms.MaskedTextBox txtIndeks;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.MaskedTextBox txtGodinaUpisa;
        private System.Windows.Forms.MaskedTextBox txtGodinaRodjenja;
        private System.Windows.Forms.Button btnSave;
    }
}

