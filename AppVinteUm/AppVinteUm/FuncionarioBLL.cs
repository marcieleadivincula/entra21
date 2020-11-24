using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public class FuncionarioBLL
    {
        FuncionarioDAL dal = new FuncionarioDAL();
        public string insert(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(funcionario.Nome))
            {
                erros.AppendLine("O nome do funcionário deve ser informado.");
            }

            if (funcionario.Nome.Length > 60)
            {
                erros.AppendLine("O nome do funcionário não pode conter mais que 60 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(funcionario.CPF))
            {
                erros.AppendLine("O CPF deve ser informada.");
            }
            if (funcionario.CPF.Length > 20)
            {
                erros.AppendLine("O CPF não pode conter mais que 20 caracteres.");
            }

            //Não pode haver CPF ou CNPJ repetidos
            if (funcionario.CPF.Equals(funcionario.CPF))
            {
                erros.AppendLine("Não pode haver CPF repetidos.");
            }

            if (funcionario.Idade < 0 || funcionario.Idade != 0)
            {
                erros.AppendLine("A idade do funcionário deve ser informado.");
            }

            if (funcionario.SalarioPorHora < 0 || funcionario.SalarioPorHora != 0)
            {
                erros.AppendLine("O salário por hora do funcionário deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(funcionario.Cargo))
            {
                erros.AppendLine("O cargo do funcionário deve ser informado.");
            }
            if (funcionario.Cargo.Length > 60)
            {
                erros.AppendLine("O cargo do funcionário não pode conter mais que 60 caracteres.");
            }

            if (funcionario.Saldo < 0 || funcionario.Saldo != 0)
            {
                erros.AppendLine("O saldo do funcionário deve ser informado.");
            }

            if (erros.Length != 0)
            {
                return erros.ToString();
            }

            string respostaDB = dal.insert(funcionario);
            return respostaDB;
        }

        public List<Funcionario> getAll()
        {
            return dal.getAll();
        }

        public string Atualizar(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder();

            if (string.IsNullOrWhiteSpace(funcionario.Nome))
            {
                erros.AppendLine("O nome do funcionário deve ser informado.");
            }

            if (funcionario.Nome.Length > 60)
            {
                erros.AppendLine("O nome do funcionário não pode conter mais que 60 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(funcionario.CPF))
            {
                erros.AppendLine("O CPF deve ser informada.");
            }

            //Não pode haver CPF ou CNPJ repetidos
            if (funcionario.CPF.Equals(funcionario.CPF))
            {
                erros.AppendLine("Não pode haver CPF repetidos.");
            }

            if (funcionario.CPF.Length > 20)
            {
                erros.AppendLine("O CPF não pode conter mais que 20 caracteres.");
            }

            if (funcionario.Idade < 0 || funcionario.Idade != 0)
            {
                erros.AppendLine("A idade do funcionário deve ser informado.");
            }

            if (funcionario.SalarioPorHora < 0 || funcionario.SalarioPorHora != 0)
            {
                erros.AppendLine("O salário por hora do funcionário deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(funcionario.Cargo))
            {
                erros.AppendLine("O cargo do funcionário deve ser informado.");
            }
            if (funcionario.Cargo.Length > 60)
            {
                erros.AppendLine("O cargo do funcionário não pode conter mais que 60 caracteres.");
            }

            if (funcionario.Saldo < 0 || funcionario.Saldo != 0)
            {
                erros.AppendLine("O saldo do funcionário deve ser informado.");
            }

            if (erros.Length != 0)
            {
                return erros.ToString();
            }

            string respostaDB = dal.update(funcionario);
            return respostaDB;
        }

        public string delete(Funcionario funcionario)
        {
            string respostaDB = dal.delete(funcionario);
            return respostaDB;
        }
        public Funcionario getById(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder();

            if (funcionario.Id < 0 || funcionario.Id != 0)
            {
                erros.AppendLine("O ID do funcionario deve ser informado. ");
            }

            return dal.getById(funcionario.Id);
        }

        public Funcionario getLastRegister()
        {
            return dal.getLastRegister();
        }

        public Funcionario getBySumSaldo(Funcionario funcionario)
        {
            StringBuilder erros = new StringBuilder();

            if (funcionario.Saldo < 0 || funcionario.Saldo != 0)
            {
                erros.AppendLine("O saldo do funcionário deve ser informado. ");
            }

            return dal.getBySumSaldo();
        }
    }
}
