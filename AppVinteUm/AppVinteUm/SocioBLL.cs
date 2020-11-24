using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public class SocioBLL: ClienteBLL
    {
        SocioDAL dal = new SocioDAL();
        public string insert(Socio socio)
        {
            StringBuilder erros = new StringBuilder();

            if (string.IsNullOrWhiteSpace(socio.Nome))
            {
                erros.AppendLine("O nome deve ser informado.");
            }

            if (socio.Nome.Length > 60)
            {
                erros.AppendLine("O nome não pode conter mais que 60 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(socio.CPF))
            {
                erros.AppendLine("O CPF deve ser informada.");
            }

            //Não pode haver CPF ou CNPJ repetidos
            //if (string.IsNullOrEmpty(socio.CPF))
            //{
            //    erros.AppendLine("");
            //}

            //if (string.Compare())
            //{
            //    erros.AppendLine("Não pode haver CPF ou CNPJ repetidos.");
            //}

            if (socio.CPF.Length > 20)
            {
                erros.AppendLine("O CPF não pode conter mais que 20 caracteres.");
            }

            if (socio.Idade < 0 || socio.Idade != 0)
            {
                erros.AppendLine("A idade deve ser informado.");
            }

            if (socio.Saldo < 0 || socio.Saldo != 0)
            {
                erros.AppendLine("O saldo deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(socio.TipoCliente))
            {
                erros.AppendLine("O tipo de cliente deve ser informado.");
            }

            if (socio.TipoCliente.Length > 20)
            {
                erros.AppendLine("O tipo de cliente conter mais que 20 caracteres.");
            }

            if (socio.QtdAcoes < 0 || socio.QtdAcoes != 0)
            {
                erros.AppendLine("A quantidade de ações deve ser informado.");
            }

            //qtdAcoes de um Cliente é no máximo 4.95% da loja
            if (socio.QtdAcoes > .0495)
            {
                erros.AppendLine("A quantidade de ações não poder ser maior que 4.95%");
            }

            //não pode haver mais do que 10 Cliente Sócio
            if (socio.GetAcoes() > 10)
            {
                erros.AppendLine("A quantidade de ações não poder ser maior que 40%");
            }


            //não pode haver mais do que 10 Cliente Sócio
            if (socio.GetAcoes() > 10)
            {
                erros.AppendLine("A quantidade de sócios não poder ser maior que 10");
            }

            if (erros.Length != 0)
            {
                return erros.ToString();
            }
            string respostaDB = dal.insert(socio);
            return respostaDB;
        }

        public List<Socio> getAll()
        {
            return dal.getAll();
        }

        public string update(Socio socio)
        {
            StringBuilder erros = new StringBuilder();

            if (string.IsNullOrWhiteSpace(socio.Nome))
            {
                erros.AppendLine("O nome deve ser informado.");
            }

            if (socio.Nome.Length > 60)
            {
                erros.AppendLine("O nome não pode conter mais que 60 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(socio.CPF))
            {
                erros.AppendLine("O CPF deve ser informada.");
            }
            if (socio.CPF.Length > 20)
            {
                erros.AppendLine("O CPF não pode conter mais que 20 caracteres.");
            }

            if (socio.Idade < 0 || socio.Idade != 0)
            {
                erros.AppendLine("A idade deve ser informado.");
            }

            if (socio.Saldo < 0 || socio.Saldo != 0)
            {
                erros.AppendLine("O saldo deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(socio.TipoCliente))
            {
                erros.AppendLine("O tipo de cliente deve ser informado.");
            }

            if (socio.TipoCliente.Length > 20)
            {
                erros.AppendLine("O tipo de cliente conter mais que 20 caracteres.");
            }

            if (socio.QtdAcoes < 0 || socio.QtdAcoes != 0)
            {
                erros.AppendLine("A quantidade de ações deve ser informado.");
            }

            if (socio.QtdAcoes > .0495)
            {
                erros.AppendLine("A quantidade de ações não poder ser maior que 4.95%");
            }

            if (erros.Length != 0)
            {
                return erros.ToString();
            }

            string respostaDB = dal.update(socio);
            return respostaDB;
        }

        public string delete(Socio socio)
        {
            string respostaDB = dal.delete(socio);
            return respostaDB;
        }

        public Cliente getById(Socio socio)
        {
            StringBuilder erros = new StringBuilder();

            if (socio.Id < 0 || socio.Id != 0)
            {
                erros.AppendLine("O ID do sócio deve ser informado. ");
            }

            return dal.getById(socio.Id);
        }

        public Socio getLastRegister()
        {
            return dal.getLastRegister();
        }
    }
}
