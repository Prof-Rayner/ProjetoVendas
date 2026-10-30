namespace ProjetoVenda.view
{
    partial class frmPerfil
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
            label1 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtRua = new TextBox();
            label4 = new Label();
            txtNumero = new TextBox();
            label5 = new Label();
            txtCep = new TextBox();
            label6 = new Label();
            txtComplemento = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            txtUsuario = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(15, 37);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(358, 23);
            txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(15, 113);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(240, 23);
            txtTelefone.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 95);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 27);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "Rua";
            // 
            // txtRua
            // 
            txtRua.Location = new Point(22, 45);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(416, 23);
            txtRua.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(499, 27);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 6;
            label4.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(499, 45);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(205, 23);
            txtNumero.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 96);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 8;
            label5.Text = "Cep";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(22, 114);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(166, 23);
            txtCep.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 96);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 10;
            label6.Text = "Complemento";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(252, 114);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(452, 23);
            txtComplemento.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconeUsuario;
            pictureBox1.Location = new Point(30, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRua);
            groupBox1.Controls.Add(txtComplemento);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(txtCep);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(30, 217);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(711, 158);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Endereço";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(txtNome);
            groupBox2.Controls.Add(txtTelefone);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(217, 29);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(524, 157);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Funcionario";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtUsuario);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(30, 391);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(704, 130);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sistema";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(22, 47);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(232, 23);
            txtUsuario.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 29);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 12;
            label7.Text = "txtUsuario";
            // 
            // frmPerfil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 594);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Name = "frmPerfil";
            Text = "frmPerfil";
            Load += frmPerfil_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private Label label2;
        private Label label3;
        private TextBox txtRua;
        private Label label4;
        private TextBox txtNumero;
        private Label label5;
        private TextBox txtCep;
        private Label label6;
        private TextBox txtComplemento;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label7;
        private TextBox txtUsuario;
    }
}