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
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.GhostWhite;
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Image = ((System.Drawing.Image)(resources.GetObject("lblNome.Image")));
            this.lblNome.Location = new System.Drawing.Point(372, 113);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(87, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome de usuario";
            this.lblNome.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPront
            // 
            this.lblPront.AutoSize = true;
            this.lblPront.BackColor = System.Drawing.Color.Black;
            this.lblPront.Location = new System.Drawing.Point(395, 158);
            this.lblPront.Name = "lblPront";
            this.lblPront.Size = new System.Drawing.Size(36, 13);
            this.lblPront.TabIndex = 4;
            this.lblPront.Text = "E-Mail";
            this.lblPront.Click += new System.EventHandler(this.lblPront_Click);
            // 
            // txbPront
            // 
            this.txbPront.Location = new System.Drawing.Point(362, 174);
            this.txbPront.Name = "txbPront";
            this.txbPront.Size = new System.Drawing.Size(100, 20);
            this.txbPront.TabIndex = 5;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(362, 129);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 6;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // btnsent
            // 
            this.btnsent.ForeColor = System.Drawing.Color.DimGray;
            this.btnsent.Location = new System.Drawing.Point(375, 248);
            this.btnsent.Name = "btnsent";
            this.btnsent.Size = new System.Drawing.Size(75, 23);
            this.btnsent.TabIndex = 7;
            this.btnsent.Text = "Cadastrar";
            this.btnsent.UseVisualStyleBackColor = true;
            this.btnsent.Click += new System.EventHandler(this.btnsent_Click);
            // 
            // txbSenha
            // 
            this.txbSenha.Location = new System.Drawing.Point(362, 222);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.Size = new System.Drawing.Size(100, 20);
            this.txbSenha.TabIndex = 9;
            this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(372, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Senha númerica";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Purple;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(332, 357);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "A REDE DE TODAS AS REDES";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(375, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.btnsent);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.txbPront);
            this.Controls.Add(this.lblPront);
            this.Controls.Add(this.lblNome);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "btnMessage";
            this.Text = "login";
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
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

