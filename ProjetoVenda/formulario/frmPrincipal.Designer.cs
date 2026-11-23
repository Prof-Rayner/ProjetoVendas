namespace ProjetoVenda.formulario
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            lblUsername = new Label();
            btnCadFuncionario = new Button();
            btnCadProduto = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtPerfil = new Button();
            btnSair = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnCadVenda = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblTitulo = new Label();
            painelPrincipal = new Panel();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(3, 252);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(97, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "nome do usuario";
            // 
            // btnCadFuncionario
            // 
            btnCadFuncionario.Font = new Font("Segoe UI", 16F);
            btnCadFuncionario.Image = Properties.Resources.funcionariopng_32x32;
            btnCadFuncionario.Location = new Point(3, 167);
            btnCadFuncionario.Name = "btnCadFuncionario";
            btnCadFuncionario.Size = new Size(133, 82);
            btnCadFuncionario.TabIndex = 1;
            btnCadFuncionario.Text = "Funcionario";
            btnCadFuncionario.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCadFuncionario.UseVisualStyleBackColor = true;
            btnCadFuncionario.Click += btnCadFuncionario_Click;
            // 
            // btnCadProduto
            // 
            btnCadProduto.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadProduto.Font = new Font("Segoe UI", 16F);
            btnCadProduto.Image = Properties.Resources.produtos_de_higiene;
            btnCadProduto.Location = new Point(3, 3);
            btnCadProduto.Name = "btnCadProduto";
            btnCadProduto.Size = new Size(133, 78);
            btnCadProduto.TabIndex = 2;
            btnCadProduto.Text = "Produtos";
            btnCadProduto.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCadProduto.UseVisualStyleBackColor = true;
            btnCadProduto.Click += btnCadProduto_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(154, 579);
            panel2.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(txtPerfil);
            flowLayoutPanel1.Controls.Add(btnSair);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(4, 405);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(146, 170);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // txtPerfil
            // 
            txtPerfil.Font = new Font("Segoe UI", 16F);
            txtPerfil.Image = Properties.Resources.perfil1_32x32;
            txtPerfil.Location = new Point(3, 3);
            txtPerfil.Name = "txtPerfil";
            txtPerfil.Size = new Size(133, 79);
            txtPerfil.TabIndex = 4;
            txtPerfil.Text = "Perfil";
            txtPerfil.TextImageRelation = TextImageRelation.TextAboveImage;
            txtPerfil.UseVisualStyleBackColor = true;
            txtPerfil.Click += txtPerfil_Click;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 16F);
            btnSair.Image = Properties.Resources.sair1_32x32;
            btnSair.Location = new Point(3, 88);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(133, 79);
            btnSair.TabIndex = 3;
            btnSair.Text = "Sair";
            btnSair.TextImageRelation = TextImageRelation.TextAboveImage;
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnCadProduto);
            flowLayoutPanel2.Controls.Add(btnCadVenda);
            flowLayoutPanel2.Controls.Add(btnCadFuncionario);
            flowLayoutPanel2.Controls.Add(lblUsername);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(4, 84);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(146, 491);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // btnCadVenda
            // 
            btnCadVenda.Font = new Font("Segoe UI", 16F);
            btnCadVenda.Image = Properties.Resources.venda;
            btnCadVenda.Location = new Point(3, 87);
            btnCadVenda.Name = "btnCadVenda";
            btnCadVenda.Size = new Size(133, 74);
            btnCadVenda.TabIndex = 5;
            btnCadVenda.Text = "Venda";
            btnCadVenda.TextImageRelation = TextImageRelation.TextAboveImage;
            btnCadVenda.UseVisualStyleBackColor = true;
            btnCadVenda.Click += btnCadVenda_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(146, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(154, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 80);
            panel1.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(716, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo da Tela";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // painelPrincipal
            // 
            painelPrincipal.Dock = DockStyle.Fill;
            painelPrincipal.Location = new Point(154, 80);
            painelPrincipal.Name = "painelPrincipal";
            painelPrincipal.Size = new Size(716, 499);
            painelPrincipal.TabIndex = 6;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 579);
            Controls.Add(painelPrincipal);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            Text = "Tela Inicial";
            Load += frmPrincipal_Load;
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblUsername;
        private Button btnCadFuncionario;
        private Button btnCadProduto;
        private Panel panel2;
        private Panel panel1;
        private Panel painelPrincipal;
        private Button btnSair;
        private Button txtPerfil;
        private Button btnCadVenda;
        private Label lblTitulo;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}