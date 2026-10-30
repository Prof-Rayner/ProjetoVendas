using ProjetoVenda.controller;
using ProjetoVenda.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVenda.view
{
    public partial class frmPerfil : Form
    {
        private EmployeeController controle;
        private Employee? funcionario;

        public frmPerfil()
        {
            InitializeComponent();
            controle = new EmployeeController();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            funcionario = controle.usuarioAutenticado();
            if (funcionario != null)
            {
                carregarDados();
            }
        }

        private void carregarDados()
        {
            txtNome.Text = funcionario.nome;
            txtTelefone.Text = funcionario.telefone;
            txtRua.Text = funcionario.rua;
            txtNumero.Text = funcionario.numero;
            txtCep.Text = funcionario.cep;
            txtComplemento.Text = funcionario.complemento;

            txtUsuario.Text = funcionario.usuario;
        }
    }
}
