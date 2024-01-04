namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalIdade = new System.Windows.Forms.Button();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCalIdade
            // 
            this.buttonCalIdade.Location = new System.Drawing.Point(178, 55);
            this.buttonCalIdade.Name = "buttonCalIdade";
            this.buttonCalIdade.Size = new System.Drawing.Size(75, 23);
            this.buttonCalIdade.TabIndex = 0;
            this.buttonCalIdade.Text = "button1";
            this.buttonCalIdade.UseVisualStyleBackColor = true;
            this.buttonCalIdade.Click += new System.EventHandler(this.buttonCalIdade_Click);
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(33, 55);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(100, 22);
            this.textBoxData.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 164);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.buttonCalIdade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalIdade;
        private System.Windows.Forms.TextBox textBoxData;
    }
}

