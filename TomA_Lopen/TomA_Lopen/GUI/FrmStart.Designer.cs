namespace TomA_Lopen
{
    partial class FrmStart
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
            this.btnInschrijven = new System.Windows.Forms.Button();
            this.btnBewerken = new System.Windows.Forms.Button();
            this.btnOpzoeken = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInschrijven
            // 
            this.btnInschrijven.Location = new System.Drawing.Point(12, 12);
            this.btnInschrijven.Name = "btnInschrijven";
            this.btnInschrijven.Size = new System.Drawing.Size(162, 45);
            this.btnInschrijven.TabIndex = 0;
            this.btnInschrijven.Text = "Inschrijven";
            this.btnInschrijven.UseVisualStyleBackColor = true;
            // 
            // btnBewerken
            // 
            this.btnBewerken.Location = new System.Drawing.Point(12, 63);
            this.btnBewerken.Name = "btnBewerken";
            this.btnBewerken.Size = new System.Drawing.Size(162, 45);
            this.btnBewerken.TabIndex = 1;
            this.btnBewerken.Text = "Bewerken";
            this.btnBewerken.UseVisualStyleBackColor = true;
            // 
            // btnOpzoeken
            // 
            this.btnOpzoeken.Location = new System.Drawing.Point(12, 114);
            this.btnOpzoeken.Name = "btnOpzoeken";
            this.btnOpzoeken.Size = new System.Drawing.Size(162, 45);
            this.btnOpzoeken.TabIndex = 2;
            this.btnOpzoeken.Text = "Opzoeken";
            this.btnOpzoeken.UseVisualStyleBackColor = true;
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Location = new System.Drawing.Point(12, 165);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(162, 45);
            this.btnAfsluiten.TabIndex = 3;
            this.btnAfsluiten.Text = "Afsluiten";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 225);
            this.ControlBox = false;
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnOpzoeken);
            this.Controls.Add(this.btnBewerken);
            this.Controls.Add(this.btnInschrijven);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Startmenu: ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInschrijven;
        private System.Windows.Forms.Button btnBewerken;
        private System.Windows.Forms.Button btnOpzoeken;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}

