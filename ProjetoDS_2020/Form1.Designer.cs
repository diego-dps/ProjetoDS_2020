namespace UI_ProjetoDS_2020
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonAcesar = new System.Windows.Forms.Button();
			this.maskedTextBoxUsuario = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBoxSenha = new System.Windows.Forms.MaskedTextBox();
			this.linkLabelRecuperarSenha = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 172);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Usuário";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 295);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 37);
			this.label2.TabIndex = 3;
			this.label2.Text = "Senha";
			// 
			// buttonAcesar
			// 
			this.buttonAcesar.Location = new System.Drawing.Point(106, 436);
			this.buttonAcesar.Name = "buttonAcesar";
			this.buttonAcesar.Size = new System.Drawing.Size(86, 48);
			this.buttonAcesar.TabIndex = 4;
			this.buttonAcesar.Text = "Acessar";
			this.buttonAcesar.UseVisualStyleBackColor = true;
			// 
			// maskedTextBoxUsuario
			// 
			this.maskedTextBoxUsuario.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
			this.maskedTextBoxUsuario.Location = new System.Drawing.Point(31, 234);
			this.maskedTextBoxUsuario.Name = "maskedTextBoxUsuario";
			this.maskedTextBoxUsuario.Size = new System.Drawing.Size(249, 35);
			this.maskedTextBoxUsuario.TabIndex = 5;
			// 
			// maskedTextBoxSenha
			// 
			this.maskedTextBoxSenha.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
			this.maskedTextBoxSenha.Location = new System.Drawing.Point(31, 350);
			this.maskedTextBoxSenha.Name = "maskedTextBoxSenha";
			this.maskedTextBoxSenha.Size = new System.Drawing.Size(249, 35);
			this.maskedTextBoxSenha.TabIndex = 6;
			// 
			// linkLabelRecuperarSenha
			// 
			this.linkLabelRecuperarSenha.AutoSize = true;
			this.linkLabelRecuperarSenha.Location = new System.Drawing.Point(169, 511);
			this.linkLabelRecuperarSenha.Name = "linkLabelRecuperarSenha";
			this.linkLabelRecuperarSenha.Size = new System.Drawing.Size(111, 13);
			this.linkLabelRecuperarSenha.TabIndex = 7;
			this.linkLabelRecuperarSenha.TabStop = true;
			this.linkLabelRecuperarSenha.Text = "Esqueci Minha Senha";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ProjetoDS_2020.Properties.Resources.banco;
			this.pictureBox1.Location = new System.Drawing.Point(331, 170);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(250, 261);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(150, 39);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(306, 47);
			this.label3.TabIndex = 9;
			this.label3.Text = "BANCO DA HORA";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Brown;
			this.ClientSize = new System.Drawing.Size(618, 574);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.linkLabelRecuperarSenha);
			this.Controls.Add(this.maskedTextBoxSenha);
			this.Controls.Add(this.maskedTextBoxUsuario);
			this.Controls.Add(this.buttonAcesar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonAcesar;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxUsuario;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxSenha;
		private System.Windows.Forms.LinkLabel linkLabelRecuperarSenha;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
	}
}

