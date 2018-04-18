namespace SKLEPCRUD
{
    partial class FormStart
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.open_laptopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // open_laptopy
            // 
            this.open_laptopy.Location = new System.Drawing.Point(13, 13);
            this.open_laptopy.Name = "open_laptopy";
            this.open_laptopy.Size = new System.Drawing.Size(75, 23);
            this.open_laptopy.TabIndex = 0;
            this.open_laptopy.Text = "Laptopy";
            this.open_laptopy.UseVisualStyleBackColor = true;
            this.open_laptopy.Click += new System.EventHandler(this.open_laptopy_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.open_laptopy);
            this.Name = "FormStart";
            this.Text = "FormularzStartowy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button open_laptopy;
    }
}

