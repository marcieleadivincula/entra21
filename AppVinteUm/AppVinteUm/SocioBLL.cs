using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public class SocioBLL
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
            if (socio.CPF.Equals(socio.CPF) || socio.CPF.Contains(socio.CPF))
            {
                erros.AppendLine("Não pode haver CPF repetidos. EQUALS");
            }

            if (socio.CPF.Contains(socio.CPF))
            {
                erros.AppendLine("Não pode haver CPF repetidos. CONTAINS");
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

            //DEVE VALIDAR O TIPO ANTES DE INSERIR NA TABELA  - REVER
            if (!socio.TipoCliente.Equals("Sócio"))
            {
                erros.AppendLine("O tipo de cliente deve ser SÓCIO.");
            }

            if (socio.QtdAcoes < 0 || socio.QtdAcoes != 0)
            {
                erros.AppendLine("A quantidade de ações deve ser informado.");
            }

            if (socio.QtdAcoes > .0495) //REVER
            {
                erros.AppendLine("A quantidade de ações não poder ser maior que 4.95%");
            }

            if (socio.QtdAcoes > .495) //REVER
            {
                erros.AppendLine("O total da quantidade de ações não poder ser maior que 49.5%");
            }

            if (socio.Id > 10)
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

            //Não pode haver CPF ou CNPJ repetidos
            if (socio.CPF.Equals(socio.CPF) || socio.CPF.Contains(socio.CPF))
            {
                erros.AppendLine("Não pode haver CPF repetidos. EQUALS");
            }

            if (socio.CPF.Contains(socio.CPF))
            {
                erros.AppendLine("Não pode haver CPF repetidos. CONTAINS");
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

            //DEVE VALIDAR O TIPO ANTES DE INSERIR NA TABELA  - REVER
            if (!socio.TipoCliente.Equals("Sócio"))
            {
                erros.AppendLine("O tipo de cliente deve ser SÓCIO.");
            }


            if (socio.QtdAcoes < 0 || socio.QtdAcoes != 0)
            {
                erros.AppendLine("A quantidade de ações deve ser informado.");
            }

            if (socio.QtdAcoes < 0 || socio.QtdAcoes != 0)
            {
                erros.AppendLine("A quantidade de ações deve ser informado.");
            }

            if (socio.QtdAcoes > .0495) //REVER
            {
                erros.AppendLine("A quantidade de ações não poder ser maior que 4.95%");
            }

            if (socio.QtdAcoes > .495) //REVER
            {
                erros.AppendLine("O total da quantidade de ações não poder ser maior que 49.5%");
            }

            if (socio.Id > 10)
            {
                erros.AppendLine("A quantidade de sócios não poder ser maior que 10");
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

        public Socio getBySumSaldo(Socio socio)
        {
            StringBuilder erros = new StringBuilder();

            if (socio.Id < 0 || socio.Id != 0)
            {
                erros.AppendLine("O saldo do sócio deve ser informado. ");
            }

            return dal.getById(socio.Id);
        }
    }
}
