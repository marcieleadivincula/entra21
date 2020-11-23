using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicalLayer
{
    public class FuncionarioBLL
    {

        FuncionarioDAL dal = new FuncionarioDAL();
        public string Inserir(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(funcionario.Nome))
            {
                erros.AppendLine("O nome deve ser informado.");
            }

            if (funcionario.Nome.Length > 50)
            {
                erros.AppendLine("O nome não pode conter mais que 50 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(funcionario.Senha))
            {
                erros.AppendLine("A senha deve ser informada.");
            }
            if (funcionario.Senha.Length > 50)
            {
                erros.AppendLine("A senha não pode conter mais que 50 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(funcionario.Usuario))
            {
                erros.AppendLine("O usuário deve ser informado.");
            }
            if (funcionario.Usuario.Length > 50)
            {
                erros.AppendLine("O usuário não pode conter mais que 50 caracteres.");
            }

            if (erros.Length != 0)
            {
                return erros.ToString();
            }
            string respostaDB = dal.Inserir(funcionario);
            return respostaDB;
        }

        public void Autenticar(string user, string senha)
        {
            Funcionario f = dal.Autenticar(user, senha);
            if (f == null)
            {
                throw new Exception("Usuário e/ou senha inválidos.");
            }
            Parametros.FuncionarioLogado = f;
        }

        public List<Funcionario> LerTodos()
        {
            return dal.LerTodos();
        }

        public string Atualizar(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder();

            if (funcionario.Usuario.Length > 50)
            {
                erros.AppendLine("O usuário não pode conter mais que 50 caracteres. ");
            }

            if (string.IsNullOrWhiteSpace(funcionario.Usuario))
            {
                erros.AppendLine("O usuário deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(funcionario.Senha))
            {
                erros.AppendLine("A senha deve ser informada.");
            }

            if (funcionario.Senha.Length > 50)
            {
                erros.AppendLine("A senha não pode conter mais que 50 caracteres. ");
            }

            string respostaDB = dal.Atualizar(funcionario);
            return respostaDB;
        }

        public string Deletar(Funcionario funcionario)
        {
            string respostaDB = dal.Deletar(funcionario);
            return respostaDB;
        }

    }
}
