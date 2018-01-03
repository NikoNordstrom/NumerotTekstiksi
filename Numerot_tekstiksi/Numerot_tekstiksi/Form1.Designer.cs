namespace Numerot_tekstiksi
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
            this.alkuperainenTeksti = new System.Windows.Forms.TextBox();
            this.muunnettuTeksti = new System.Windows.Forms.TextBox();
            this.muunnaNappi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // alkuperainenTeksti
            // 
            this.alkuperainenTeksti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alkuperainenTeksti.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.alkuperainenTeksti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alkuperainenTeksti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alkuperainenTeksti.Location = new System.Drawing.Point(12, 28);
            this.alkuperainenTeksti.Name = "alkuperainenTeksti";
            this.alkuperainenTeksti.Size = new System.Drawing.Size(560, 22);
            this.alkuperainenTeksti.TabIndex = 0;
            // 
            // muunnettuTeksti
            // 
            this.muunnettuTeksti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.muunnettuTeksti.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.muunnettuTeksti.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.muunnettuTeksti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muunnettuTeksti.Location = new System.Drawing.Point(12, 116);
            this.muunnettuTeksti.Name = "muunnettuTeksti";
            this.muunnettuTeksti.Size = new System.Drawing.Size(560, 22);
            this.muunnettuTeksti.TabIndex = 2;
            // 
            // muunnaNappi
            // 
            this.muunnaNappi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.muunnaNappi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.muunnaNappi.FlatAppearance.BorderSize = 0;
            this.muunnaNappi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muunnaNappi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muunnaNappi.Location = new System.Drawing.Point(492, 56);
            this.muunnaNappi.Name = "muunnaNappi";
            this.muunnaNappi.Size = new System.Drawing.Size(80, 30);
            this.muunnaNappi.TabIndex = 1;
            this.muunnaNappi.Text = "Muunna";
            this.muunnaNappi.UseVisualStyleBackColor = false;
            this.muunnaNappi.Click += new System.EventHandler(this.muunnaNappi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alkuperäinen teksti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Muutettu teksti:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(584, 163);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muunnaNappi);
            this.Controls.Add(this.muunnettuTeksti);
            this.Controls.Add(this.alkuperainenTeksti);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerot tekstiksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox alkuperainenTeksti;
        private System.Windows.Forms.TextBox muunnettuTeksti;
        private System.Windows.Forms.Button muunnaNappi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

