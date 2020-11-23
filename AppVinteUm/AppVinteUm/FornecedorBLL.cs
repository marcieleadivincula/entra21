using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public class FornecedorBLL
    {
        FornecedorDAL dal = new FornecedorDAL();
        public string insert(Fornecedor fornecedor)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(fornecedor.Nome))
            {
                erros.AppendLine("O nome do fornecedor deve ser informado.");
            }

            if (fornecedor.Nome.Length > 60)
            {
                erros.AppendLine("O nome do fornecedor não pode conter mais que 60 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(fornecedor.CNPJ))
            {
                erros.AppendLine("O CNPJ deve ser informada.");
            }
            if (fornecedor.CNPJ.Length > 30)
            {
                erros.AppendLine("O CNPJ não pode conter mais que 30 caracteres.");
            }

            if (fornecedor.TipoDeProduto < 0 || fornecedor.TipoDeProduto != 0)
            {
                erros.AppendLine("O tipo de produto deve ser informado.");
            }

            if (fornecedor.QuantidadeFornecidaAoMes < 0 || fornecedor.QuantidadeFornecidaAoMes != 0)
            {
                erros.AppendLine("A quantidade fornecida ao mês deve ser informado.");
            }

            if (erros.Length != 0)
            {
                return erros.ToString();
            }
            string respostaDB = dal.insert(fornecedor);
            return respostaDB;
        }

        public List<Fornecedor> getAll()
        {
            return dal.getAll();
        }

        public string update(Fornecedor fornecedor)
        {
            StringBuilder erros = new StringBuilder();

            if (string.IsNullOrWhiteSpace(fornecedor.Nome))
            {
                erros.AppendLine("O nome do fornecedor deve ser informado.");
            }

            if (fornecedor.Nome.Length > 60)
            {
                erros.AppendLine("O nome do fornecedor não pode conter mais que 60 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(fornecedor.CNPJ))
            {
                erros.AppendLine("O CNPJ deve ser informada.");
            }
            if (fornecedor.CNPJ.Length > 30)
            {
                erros.AppendLine("O CNPJ não pode conter mais que 30 caracteres.");
            }

            if (fornecedor.TipoDeProduto < 0 || fornecedor.TipoDeProduto != 0)
            {
                erros.AppendLine("O tipo de produto deve ser informado.");
            }

            if (fornecedor.QuantidadeFornecidaAoMes < 0 || fornecedor.QuantidadeFornecidaAoMes != 0)
            {
                erros.AppendLine("A quantidade fornecida ao mês deve ser informado.");
            }

            if (erros.Length != 0)
            {
                return erros.ToString();
            }

            string respostaDB = dal.update(fornecedor);
            return respostaDB;
        }

        public string delete(Fornecedor fornecedor)
        {
            string respostaDB = dal.delete(fornecedor);
            return respostaDB;
        }

        public Fornecedor getById(Fornecedor fornecedor)
        {
            StringBuilder erros = new StringBuilder();

            if (fornecedor.Id < 0 || fornecedor.Id != 0)
            {
                erros.AppendLine("O ID do fornecedor deve ser informado. ");
            }

            return dal.getById(fornecedor.Id);
        }

        public Fornecedor getLastRegister()
        {
            return dal.getLastRegister();
        }
    }
}
