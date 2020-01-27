namespace TestesEpplus
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
            this.btnEmite = new System.Windows.Forms.Button();
            this.btnAltere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmite
            // 
            this.btnEmite.Location = new System.Drawing.Point(102, 123);
            this.btnEmite.Name = "btnEmite";
            this.btnEmite.Size = new System.Drawing.Size(75, 23);
            this.btnEmite.TabIndex = 0;
            this.btnEmite.Text = "Emita";
            this.btnEmite.UseVisualStyleBackColor = true;
            this.btnEmite.Click += new System.EventHandler(this.btnEmite_Click);
            // 
            // btnAltere
            // 
            this.btnAltere.Location = new System.Drawing.Point(102, 183);
            this.btnAltere.Name = "btnAltere";
            this.btnAltere.Size = new System.Drawing.Size(79, 22);
            this.btnAltere.TabIndex = 1;
            this.btnAltere.Text = "Altere";
            this.btnAltere.UseVisualStyleBackColor = true;
            this.btnAltere.Click += new System.EventHandler(this.btnAltere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 332);
            this.Controls.Add(this.btnAltere);
            this.Controls.Add(this.btnEmite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmite;
        private System.Windows.Forms.Button btnAltere;
    }
}