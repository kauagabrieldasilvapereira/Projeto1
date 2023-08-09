namespace Projeto1
{
    partial class btnMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(btnMessage));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPront = new System.Windows.Forms.Label();
            this.txbPront = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.btnsent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Olive;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Image = ((System.Drawing.Image)(resources.GetObject("lblNome.Image")));
            this.lblNome.Location = new System.Drawing.Point(345, 154);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPront
            // 
            this.lblPront.AutoSize = true;
            this.lblPront.BackColor = System.Drawing.Color.Black;
            this.lblPront.Location = new System.Drawing.Point(345, 203);
            this.lblPront.Name = "lblPront";
            this.lblPront.Size = new System.Drawing.Size(55, 13);
            this.lblPront.TabIndex = 4;
            this.lblPront.Text = "Prontuario";
            // 
            // txbPront
            // 
            this.txbPront.Location = new System.Drawing.Point(348, 219);
            this.txbPront.Name = "txbPront";
            this.txbPront.Size = new System.Drawing.Size(100, 20);
            this.txbPront.TabIndex = 5;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(348, 170);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 6;
            // 
            // btnsent
            // 
            this.btnsent.ForeColor = System.Drawing.Color.DimGray;
            this.btnsent.Location = new System.Drawing.Point(348, 269);
            this.btnsent.Name = "btnsent";
            this.btnsent.Size = new System.Drawing.Size(75, 23);
            this.btnsent.TabIndex = 7;
            this.btnsent.Text = "Entra";
            this.btnsent.UseVisualStyleBackColor = true;
            this.btnsent.Click += new System.EventHandler(this.btnsent_Click);
            // 
            // btnMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsent);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbPront);
            this.Controls.Add(this.lblPront);
            this.Controls.Add(this.lblNome);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "btnMessage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPront;
        private System.Windows.Forms.TextBox txbPront;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Button btnsent;
    }
}

