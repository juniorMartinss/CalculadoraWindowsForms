namespace ProjetoCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Subtrair = new System.Windows.Forms.Button();
            this.Multiplicacao = new System.Windows.Forms.Button();
            this.Divisao = new System.Windows.Forms.Button();
            this.Pontencia = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.raizQuadrada = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PrimeiroNumero = new System.Windows.Forms.Label();
            this.segundoNumero = new System.Windows.Forms.Label();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Subtrair
            // 
            this.Subtrair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Subtrair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Subtrair.BackgroundImage")));
            this.Subtrair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Subtrair.Font = new System.Drawing.Font("Shamber", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtrair.ForeColor = System.Drawing.Color.White;
            this.Subtrair.Location = new System.Drawing.Point(185, 119);
            this.Subtrair.Name = "Subtrair";
            this.Subtrair.Size = new System.Drawing.Size(98, 59);
            this.Subtrair.TabIndex = 1;
            this.Subtrair.UseVisualStyleBackColor = false;
            this.Subtrair.Click += new System.EventHandler(this.Subtrair_Click);
            // 
            // Multiplicacao
            // 
            this.Multiplicacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Multiplicacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Multiplicacao.BackgroundImage")));
            this.Multiplicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Multiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiplicacao.Font = new System.Drawing.Font("Shamber", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacao.ForeColor = System.Drawing.Color.White;
            this.Multiplicacao.Location = new System.Drawing.Point(289, 119);
            this.Multiplicacao.Name = "Multiplicacao";
            this.Multiplicacao.Size = new System.Drawing.Size(98, 59);
            this.Multiplicacao.TabIndex = 2;
            this.Multiplicacao.UseVisualStyleBackColor = false;
            this.Multiplicacao.Click += new System.EventHandler(this.Multiplicacao_Click);
            // 
            // Divisao
            // 
            this.Divisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Divisao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Divisao.BackgroundImage")));
            this.Divisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Divisao.Font = new System.Drawing.Font("Shamber", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divisao.ForeColor = System.Drawing.Color.White;
            this.Divisao.Location = new System.Drawing.Point(81, 184);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(98, 59);
            this.Divisao.TabIndex = 3;
            this.Divisao.UseVisualStyleBackColor = false;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // Pontencia
            // 
            this.Pontencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Pontencia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pontencia.BackgroundImage")));
            this.Pontencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Pontencia.Font = new System.Drawing.Font("Shamber", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pontencia.ForeColor = System.Drawing.Color.White;
            this.Pontencia.Location = new System.Drawing.Point(289, 184);
            this.Pontencia.Name = "Pontencia";
            this.Pontencia.Size = new System.Drawing.Size(98, 59);
            this.Pontencia.TabIndex = 5;
            this.Pontencia.UseVisualStyleBackColor = false;
            this.Pontencia.Click += new System.EventHandler(this.Pontencia_Click);
            // 
            // Soma
            // 
            this.Soma.AccessibleDescription = "Botão utilizado para soma";
            this.Soma.AccessibleName = "Soma";
            this.Soma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Soma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Soma.BackgroundImage")));
            this.Soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Soma.Cursor = System.Windows.Forms.Cursors.No;
            this.Soma.Font = new System.Drawing.Font("Shamber", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soma.ForeColor = System.Drawing.Color.White;
            this.Soma.Location = new System.Drawing.Point(81, 119);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(98, 59);
            this.Soma.TabIndex = 0;
            this.Soma.UseVisualStyleBackColor = false;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // raizQuadrada
            // 
            this.raizQuadrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.raizQuadrada.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("raizQuadrada.BackgroundImage")));
            this.raizQuadrada.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.raizQuadrada.Font = new System.Drawing.Font("Shamber", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raizQuadrada.ForeColor = System.Drawing.Color.White;
            this.raizQuadrada.Location = new System.Drawing.Point(185, 184);
            this.raizQuadrada.Name = "raizQuadrada";
            this.raizQuadrada.Size = new System.Drawing.Size(98, 59);
            this.raizQuadrada.TabIndex = 6;
            this.raizQuadrada.UseVisualStyleBackColor = false;
            this.raizQuadrada.Click += new System.EventHandler(this.raizQuadrada_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(81, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 37);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(242, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 37);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PrimeiroNumero
            // 
            this.PrimeiroNumero.AutoSize = true;
            this.PrimeiroNumero.Font = new System.Drawing.Font("Shamber", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrimeiroNumero.Location = new System.Drawing.Point(75, 28);
            this.PrimeiroNumero.Name = "PrimeiroNumero";
            this.PrimeiroNumero.Size = new System.Drawing.Size(155, 35);
            this.PrimeiroNumero.TabIndex = 9;
            this.PrimeiroNumero.Text = "Primeiro número";
            // 
            // segundoNumero
            // 
            this.segundoNumero.AutoSize = true;
            this.segundoNumero.Font = new System.Drawing.Font("Shamber", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundoNumero.Location = new System.Drawing.Point(236, 28);
            this.segundoNumero.Name = "segundoNumero";
            this.segundoNumero.Size = new System.Drawing.Size(161, 35);
            this.segundoNumero.TabIndex = 10;
            this.segundoNumero.Text = "Segundo número";
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(76, 269);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 26);
            this.Resultado.TabIndex = 11;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 356);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.segundoNumero);
            this.Controls.Add(this.PrimeiroNumero);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.raizQuadrada);
            this.Controls.Add(this.Pontencia);
            this.Controls.Add(this.Divisao);
            this.Controls.Add(this.Multiplicacao);
            this.Controls.Add(this.Subtrair);
            this.Controls.Add(this.Soma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Subtrair;
        private System.Windows.Forms.Button Multiplicacao;
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.Button Pontencia;
        private System.Windows.Forms.Button raizQuadrada;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label PrimeiroNumero;
        private System.Windows.Forms.Label segundoNumero;
        private System.Windows.Forms.Label Resultado;
    }
}

