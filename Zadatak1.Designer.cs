namespace WindowsFormsApp3
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
            this.uiActionIzborTroska = new System.Windows.Forms.ComboBox();
            this.uiIspis = new System.Windows.Forms.TextBox();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiCijena = new System.Windows.Forms.TextBox();
            this.uiIzborTroska = new System.Windows.Forms.Label();
            this.uiUpisCijene = new System.Windows.Forms.Label();
            this.uiActionFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiActionIzborTroska
            // 
            this.uiActionIzborTroska.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uiActionIzborTroska.FormattingEnabled = true;
            this.uiActionIzborTroska.Location = new System.Drawing.Point(50, 28);
            this.uiActionIzborTroska.Name = "uiActionIzborTroska";
            this.uiActionIzborTroska.Size = new System.Drawing.Size(121, 21);
            this.uiActionIzborTroska.TabIndex = 0;
            // 
            // uiIspis
            // 
            this.uiIspis.Location = new System.Drawing.Point(50, 95);
            this.uiIspis.Multiline = true;
            this.uiIspis.Name = "uiIspis";
            this.uiIspis.Size = new System.Drawing.Size(166, 111);
            this.uiIspis.TabIndex = 1;
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(242, 93);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(75, 23);
            this.uiActionDodaj.TabIndex = 2;
            this.uiActionDodaj.Text = "Dodaj";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // uiCijena
            // 
            this.uiCijena.Location = new System.Drawing.Point(228, 29);
            this.uiCijena.Name = "uiCijena";
            this.uiCijena.Size = new System.Drawing.Size(100, 20);
            this.uiCijena.TabIndex = 3;
            // 
            // uiIzborTroska
            // 
            this.uiIzborTroska.AutoSize = true;
            this.uiIzborTroska.Location = new System.Drawing.Point(47, 9);
            this.uiIzborTroska.Name = "uiIzborTroska";
            this.uiIzborTroska.Size = new System.Drawing.Size(65, 13);
            this.uiIzborTroska.TabIndex = 4;
            this.uiIzborTroska.Text = "Izbor troska:";
            // 
            // uiUpisCijene
            // 
            this.uiUpisCijene.AutoSize = true;
            this.uiUpisCijene.Location = new System.Drawing.Point(225, 9);
            this.uiUpisCijene.Name = "uiUpisCijene";
            this.uiUpisCijene.Size = new System.Drawing.Size(62, 13);
            this.uiUpisCijene.TabIndex = 5;
            this.uiUpisCijene.Text = "Upis cijene:";
            // 
            // uiActionFilter
            // 
            this.uiActionFilter.Location = new System.Drawing.Point(242, 146);
            this.uiActionFilter.Name = "uiActionFilter";
            this.uiActionFilter.Size = new System.Drawing.Size(75, 23);
            this.uiActionFilter.TabIndex = 6;
            this.uiActionFilter.Text = "Filtriraj";
            this.uiActionFilter.UseVisualStyleBackColor = true;
            this.uiActionFilter.Click += new System.EventHandler(this.uiActionFilter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiActionFilter);
            this.Controls.Add(this.uiUpisCijene);
            this.Controls.Add(this.uiIzborTroska);
            this.Controls.Add(this.uiCijena);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.uiIspis);
            this.Controls.Add(this.uiActionIzborTroska);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiActionIzborTroska;
        private System.Windows.Forms.TextBox uiIspis;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.TextBox uiCijena;
        private System.Windows.Forms.Label uiIzborTroska;
        private System.Windows.Forms.Label uiUpisCijene;
        private System.Windows.Forms.Button uiActionFilter;
    }
}

