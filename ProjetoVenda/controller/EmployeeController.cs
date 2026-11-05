using System;
using System.Collections.Generic;
using System.Text;
using BCrypt.Net;
using ProjetoVenda.model;
using ProjetoVenda.repository;

namespace ProjetoVenda.controller
{
    internal class EmployeeController
    {

        private EmployeeRepository respository;


        public EmployeeController()
        {
            respository = new EmployeeRepository();
        }


        public List<Employee> listarFuncionarios()
        {
            return respository.listarFuncionarios();
        }


        public static bool login(string username, string password)
        {
            EmployeeRepository respository = new EmployeeRepository();
            Employee? resp = respository.getByUsername(username);
            if (resp == null)
            {
                return false;
            }


            bool validatePassword;
            try
            {
                validatePassword = BCrypt.Net.BCrypt.Verify(password, resp.senha);
            }catch(Exception ex)
            {
                validatePassword = false;
            }

            if ( !validatePassword )
            {
                return false;
            }
            // gravar os dados do usuario logado!!!!
            Session.userAuth = resp;
            return true;

        }


        public bool createEmployee(Employee funcionario)
        {

            // fazer verificação se o usuario nao existe
            // solicitar ao respository se o usuario existe
            EmployeeRepository respository = new EmployeeRepository();
            Employee? resp = respository.getByUsername(funcionario.usuario );
            if (resp != null)
            {
                return false;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(funcionario.senha);
            funcionario.senha = hash;
            
            respository.createEmployee(funcionario);
            return true;
        }


        public void deslogar()
        {
            Session.userAuth = null;
        }

        public Employee? usuarioAutenticado()
        {
            return Session.userAuth;
        }

        public bool usuarioAdministrador()
        {
            if (Session.userAuth == null)
            {
                return false;
            }
            return Session.userAuth.adm;
        }

    }
}
