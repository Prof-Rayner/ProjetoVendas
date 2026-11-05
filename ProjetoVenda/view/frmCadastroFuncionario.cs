using ProjetoVenda.controller;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.view
{
    public partial class frmCadastroFuncionario : Form
    {
        private EmployeeController controller;
        public frmCadastroFuncionario()
        {
            InitializeComponent();
            controller = new EmployeeController();
        }

        private void limparCampos()
        {
            this.txtNome.Clear();
            this.txtTelefone.Clear();
            this.txtRua.Clear();
            this.txtNumero.Clear();
            this.txtCep.Clear();
            this.txtComplemento.Clear();
            this.txtUsuario.Clear();
            this.txtSenha.Clear();
            this.txtSenha1.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = this.txtNome.Text;
            string telefone = this.txtTelefone.Text;
            string rua = this.txtRua.Text;
            string numero = this.txtNumero.Text;
            string cep = this.txtCep.Text;
            string complemento = this.txtComplemento.Text;

            string usuario = this.txtUsuario.Text;
            string senha = this.txtSenha.Text;
            string senha1 = this.txtSenha1.Text;

            bool adm = (this.cbxAdm.SelectedIndex == 0)? false: true;
            //bool adm1 = this.cbxAdm.SelectedIndex == 1;
            

            if (senha != senha1)
            {
                MessageBox.Show(
                    "Senhas nao Confere",
                    "Senhas incorretas",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                 );
                return;
            }

            // chamar o controlador do usuario para cadastro
            Employee funcionario = new Employee
            {
                nome = nome,
                telefone = telefone,
                rua = rua,
                numero = numero,
                cep = cep,
                complemento = complemento,
                usuario = usuario,
                senha = senha,
                adm = adm
            };


            bool resp = controller.createEmployee(funcionario);

            if (resp)
            {
                MessageBox.Show("Funcionario Cadastrado Com Sucesso",
                    "Cadastro Funcionario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limparCampos();
                carregarFuncionarios();
            }
            else
            {
                MessageBox.Show("Erro ao Cadastrar Funcionario",
                    "Cadastro Funcionario",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void frmCadastroFuncionario_Load(object sender, EventArgs e)
        {
            carregarFuncionarios();
            this.cbxAdm.SelectedIndex = 0;

        }

        private void carregarFuncionarios()
        {
            List<Employee> lista = controller.listarFuncionarios();
            dgvFuncionarios.DataSource = lista;
            dgvFuncionarios.Columns["senha"].Visible = false;
        }
    }
}
