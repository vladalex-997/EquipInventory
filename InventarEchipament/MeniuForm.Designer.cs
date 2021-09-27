
namespace InventarEchipament
{
    partial class MeniuForm
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
            this.buttonAngajati = new System.Windows.Forms.Button();
            this.buttonVizualizare = new System.Windows.Forms.Button();
            this.buttonEchipament = new System.Windows.Forms.Button();
            this.labelAplicatie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxTipuri = new System.Windows.Forms.TextBox();
            this.buttonDeschide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAngajati
            // 
            this.buttonAngajati.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAngajati.Location = new System.Drawing.Point(44, 329);
            this.buttonAngajati.Name = "buttonAngajati";
            this.buttonAngajati.Size = new System.Drawing.Size(403, 166);
            this.buttonAngajati.TabIndex = 0;
            this.buttonAngajati.Text = "Introducere / Modificare Angajati";
            this.buttonAngajati.UseVisualStyleBackColor = true;
            this.buttonAngajati.Click += new System.EventHandler(this.buttonAngajati_Click);
            // 
            // buttonVizualizare
            // 
            this.buttonVizualizare.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVizualizare.Location = new System.Drawing.Point(510, 329);
            this.buttonVizualizare.Name = "buttonVizualizare";
            this.buttonVizualizare.Size = new System.Drawing.Size(347, 166);
            this.buttonVizualizare.TabIndex = 1;
            this.buttonVizualizare.Text = "Vizualizare / Export Excel";
            this.buttonVizualizare.UseVisualStyleBackColor = true;
            this.buttonVizualizare.Click += new System.EventHandler(this.buttonVizualizare_Click);
            // 
            // buttonEchipament
            // 
            this.buttonEchipament.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEchipament.Location = new System.Drawing.Point(920, 329);
            this.buttonEchipament.Name = "buttonEchipament";
            this.buttonEchipament.Size = new System.Drawing.Size(399, 166);
            this.buttonEchipament.TabIndex = 2;
            this.buttonEchipament.Text = "Introducere / Modificare Echipament";
            this.buttonEchipament.UseVisualStyleBackColor = true;
            this.buttonEchipament.Click += new System.EventHandler(this.buttonEchipament_Click);
            // 
            // labelAplicatie
            // 
            this.labelAplicatie.AutoSize = true;
            this.labelAplicatie.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAplicatie.Location = new System.Drawing.Point(295, 75);
            this.labelAplicatie.Name = "labelAplicatie";
            this.labelAplicatie.Size = new System.Drawing.Size(972, 90);
            this.labelAplicatie.TabIndex = 3;
            this.labelAplicatie.Text = "APLICATIE ECHIPAMENT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 619);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Parola Adaugare Noi Tipuri :";
            // 
            // tbxTipuri
            // 
            this.tbxTipuri.Location = new System.Drawing.Point(322, 619);
            this.tbxTipuri.Name = "tbxTipuri";
            this.tbxTipuri.Size = new System.Drawing.Size(169, 30);
            this.tbxTipuri.TabIndex = 5;
            // 
            // buttonDeschide
            // 
            this.buttonDeschide.Location = new System.Drawing.Point(510, 604);
            this.buttonDeschide.Name = "buttonDeschide";
            this.buttonDeschide.Size = new System.Drawing.Size(109, 58);
            this.buttonDeschide.TabIndex = 6;
            this.buttonDeschide.Text = "Deschide";
            this.buttonDeschide.UseVisualStyleBackColor = true;
            this.buttonDeschide.Click += new System.EventHandler(this.buttonDeschide_Click);
            // 
            // MeniuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.buttonDeschide);
            this.Controls.Add(this.tbxTipuri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAplicatie);
            this.Controls.Add(this.buttonEchipament);
            this.Controls.Add(this.buttonVizualizare);
            this.Controls.Add(this.buttonAngajati);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MeniuForm";
            this.Text = "Meniu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MeniuForm_FormClosing);
            this.Load += new System.EventHandler(this.MeniuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAngajati;
        private System.Windows.Forms.Button buttonVizualizare;
        private System.Windows.Forms.Button buttonEchipament;
        private System.Windows.Forms.Label labelAplicatie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxTipuri;
        private System.Windows.Forms.Button buttonDeschide;
    }
}

