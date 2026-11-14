using System;
using System.Collections.Generic;
using System.Text;
using BCrypt.Net;
using ProjetoVenda.modelo;
using ProjetoVenda.repositorio;

namespace ProjetoVenda.controle
{
    internal class FuncionarioControle
    {

        private FuncionarioRepositorio repositorio;


        public FuncionarioControle()
        {
            repositorio = new FuncionarioRepositorio();
        }


        public List<Funcionario> listarFuncionarios()
        {
            return repositorio.listarFuncionarios();
        }


        public static bool autenticar(string nomeDeUsuario, string senha)
        {
            FuncionarioRepositorio respository = new FuncionarioRepositorio();
            Funcionario? funcionario = respository.pegarPorNomeDeUsuario(nomeDeUsuario);
            if (funcionario == null)
            {
                return false;
            }

            bool validarSenha;
            try
            {
                validarSenha = BCrypt.Net.BCrypt.Verify(senha, funcionario.senha);
            }catch(Exception ex)
            {
                validarSenha = false;
            }

            if ( !validarSenha )
            {
                return false;
            }
            // gravar os dados do usuario logado!!!!
            Sessao.usuarioAutenticado = funcionario;
            return true;
        }


        public bool criarFuncionario(Funcionario funcionario)
        {

            // fazer verificação se o usuario nao existe
            // solicitar ao respository se o usuario existe
            FuncionarioRepositorio respository = new FuncionarioRepositorio();
            Funcionario? resposta = respository.pegarPorNomeDeUsuario(funcionario.usuario);
            if (resposta != null)
            {
                return false;
            }

            string senhaCriptografada = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = senhaCriptografada;
            
            respository.criarFuncionario(funcionario);
            return true;
        }


        public void deslogar()
        {
            Sessao.usuarioAutenticado = null;
        }

        public Funcionario? usuarioAutenticado()
        {
            return Sessao.usuarioAutenticado;
        }

        public bool usuarioAdministrador()
        {
            if (Sessao.usuarioAutenticado == null)
            {
                return false;
            }
            return Sessao.usuarioAutenticado.adm;
        }

    }
}
