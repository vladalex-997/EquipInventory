
namespace InventarEchipament
{
    partial class Vizualizare
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonBackViz = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxCodSAP = new System.Windows.Forms.TextBox();
            this.tbxResponsabil = new System.Windows.Forms.TextBox();
            this.tbxTipAngajat = new System.Windows.Forms.TextBox();
            this.tbxNume = new System.Windows.Forms.TextBox();
            this.buttonFiltrare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackViz
            // 
            this.buttonBackViz.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackViz.Location = new System.Drawing.Point(40, 654);
            this.buttonBackViz.Name = "buttonBackViz";
            this.buttonBackViz.Size = new System.Drawing.Size(252, 66);
            this.buttonBackViz.TabIndex = 1;
            this.buttonBackViz.Text = "Inapoi Meniu Principal";
            this.buttonBackViz.UseVisualStyleBackColor = true;
            this.buttonBackViz.Click += new System.EventHandler(this.buttonBackViz_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cod SAP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Responsabil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(893, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tip Angajat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nume";
            // 
            // tbxCodSAP
            // 
            this.tbxCodSAP.Location = new System.Drawing.Point(126, 103);
            this.tbxCodSAP.Name = "tbxCodSAP";
            this.tbxCodSAP.Size = new System.Drawing.Size(142, 30);
            this.tbxCodSAP.TabIndex = 7;
            // 
            // tbxResponsabil
            // 
            this.tbxResponsabil.Location = new System.Drawing.Point(728, 101);
            this.tbxResponsabil.Name = "tbxResponsabil";
            this.tbxResponsabil.Size = new System.Drawing.Size(159, 30);
            this.tbxResponsabil.TabIndex = 8;
            // 
            // tbxTipAngajat
            // 
            this.tbxTipAngajat.Location = new System.Drawing.Point(1001, 101);
            this.tbxTipAngajat.Name = "tbxTipAngajat";
            this.tbxTipAngajat.Size = new System.Drawing.Size(87, 30);
            this.tbxTipAngajat.TabIndex = 9;
            // 
            // tbxNume
            // 
            this.tbxNume.Location = new System.Drawing.Point(374, 101);
            this.tbxNume.Name = "tbxNume";
            this.tbxNume.Size = new System.Drawing.Size(207, 30);
            this.tbxNume.TabIndex = 10;
            // 
            // buttonFiltrare
            // 
            this.buttonFiltrare.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFiltrare.Location = new System.Drawing.Point(1152, 83);
            this.buttonFiltrare.Name = "buttonFiltrare";
            this.buttonFiltrare.Size = new System.Drawing.Size(154, 62);
            this.buttonFiltrare.TabIndex = 11;
            this.buttonFiltrare.Text = "Filtrare";
            this.buttonFiltrare.UseVisualStyleBackColor = true;
            this.buttonFiltrare.Click += new System.EventHandler(this.buttonFiltrare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(554, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 49);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vizualizare";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(40, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1266, 456);
            this.dataGridView1.TabIndex = 13;
            // 
            // buttonExport
            // 
            this.buttonExport.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.Location = new System.Drawing.Point(1152, 19);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(154, 47);
            this.buttonExport.TabIndex = 14;
            this.buttonExport.Text = "Export Excel";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // Vizualizare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.buttonExport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonFiltrare);
            this.Controls.Add(this.tbxNume);
            this.Controls.Add(this.tbxTipAngajat);
            this.Controls.Add(this.tbxResponsabil);
            this.Controls.Add(this.tbxCodSAP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBackViz);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vizualizare";
            this.Text = "Vizualizare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vizualizare_FormClosing);
            this.Load += new System.EventHandler(this.Vizualizare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackViz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxCodSAP;
        private System.Windows.Forms.TextBox tbxResponsabil;
        private System.Windows.Forms.TextBox tbxTipAngajat;
        private System.Windows.Forms.TextBox tbxNume;
        private System.Windows.Forms.Button buttonFiltrare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExport;
    }
}