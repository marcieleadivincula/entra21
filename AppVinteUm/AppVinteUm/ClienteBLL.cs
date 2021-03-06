﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVinteUm
{
    public class ClienteBLL
    {
        ClienteDAL dal = new ClienteDAL();
        public string insert(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder();
            if (string.IsNullOrWhiteSpace(cliente.Nome))
            {
                erros.AppendLine("O nome deve ser informado.");
            }

            if (cliente.Nome.Length > 60)
            {
                erros.AppendLine("O nome não pode conter mais que 60 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(cliente.CPF))
            {
                erros.AppendLine("O CPF deve ser informada.");
            }
            if (cliente.CPF.Length > 20)
            {
                erros.AppendLine("O CPF não pode conter mais que 20 caracteres.");
            }

            //Não pode haver CPF ou CNPJ repetidos
            if (cliente.CPF.Equals(cliente.CPF) || cliente.CPF.Contains(cliente.CPF))
            {
                erros.AppendLine("Não pode haver CPF repetidos.");
            }

            if (cliente.Idade < 0 || cliente.Idade != 0)
            {
                erros.AppendLine("A idade deve ser informado.");
            }

            if (cliente.Saldo < 0 || cliente.Saldo != 0)
            {
                erros.AppendLine("O saldo deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(cliente.TipoCliente))
            {
                erros.AppendLine("O tipo de cliente deve ser informado.");
            }

            if (cliente.TipoCliente.Length > 20)
            {
                erros.AppendLine("O tipo de cliente conter mais que 20 caracteres.");
            }

            if (cliente.TipoCliente != "Normal")
            {
                erros.AppendLine("O tipo de cliente deve ser NORMAL.");
            }

            if (erros.Length != 0)
            {
                return erros.ToString();
            }
            string respostaDB = dal.insert(cliente);
            return respostaDB;
        }

        public List<Cliente> getAll()
        {
            return dal.getAll();
        }

        public string update(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder();

            if (string.IsNullOrWhiteSpace(cliente.Nome))
            {
                erros.AppendLine("O nome deve ser informado.");
            }

            if (cliente.Nome.Length > 60)
            {
                erros.AppendLine("O nome não pode conter mais que 60 caracteres.");
            }

            if (string.IsNullOrWhiteSpace(cliente.CPF))
            {
                erros.AppendLine("O CPF deve ser informada.");
            }

            //Não pode haver CPF ou CNPJ repetidos
            if (cliente.CPF.Equals(cliente.CPF) || cliente.CPF.Contains(cliente.CPF))
            {
                erros.AppendLine("Não pode haver CPF repetidos.");
            }

            if (cliente.CPF.Length > 20)
            {
                erros.AppendLine("O CPF não pode conter mais que 20 caracteres.");
            }

            if (cliente.Idade < 0 || cliente.Idade != 0)
            {
                erros.AppendLine("A idade deve ser informado.");
            }

            if (cliente.Saldo < 0 || cliente.Saldo != 0)
            {
                erros.AppendLine("O saldo deve ser informado.");
            }

            if (string.IsNullOrWhiteSpace(cliente.TipoCliente))
            {
                erros.AppendLine("O tipo de cliente deve ser informado.");
            }

            if (cliente.TipoCliente.Length > 20)
            {
                erros.AppendLine("O tipo de cliente não pode conter mais que 20 caracteres.");
            }


            if (cliente.TipoCliente != "Normal")
            {
                erros.AppendLine("O tipo de cliente deve ser NORMAL.");
            }


            if (erros.Length != 0)
            {
                return erros.ToString();
            }

            string respostaDB = dal.update(cliente);
            return respostaDB;
        }

        public string delete(Cliente cliente)
        {
            string respostaDB = dal.delete(cliente);
            return respostaDB;
        }

        public Cliente getById(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder();

            if (cliente.Id < 0 || cliente.Id != 0)
            {
                erros.AppendLine("O ID do cliente deve ser informado. ");
            }

            return dal.getById(cliente.Id);
        }

        public Cliente getLastRegister()
        {
            return dal.getLastRegister();
        }

        public Cliente getByCpf(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder();

            if (string.IsNullOrWhiteSpace(cliente.CPF))
            {
                erros.AppendLine("O CPF do cliente deve ser informado. ");
            }

            return dal.getByCpf(cliente.CPF);
        }

        public Cliente getBySumSaldo(Cliente cliente)
        {
            StringBuilder erros = new StringBuilder();

            if (cliente.Saldo < 0 || cliente.Saldo != 0)
            {
                erros.AppendLine("O saldo do cliente deve ser informado. ");
            }

            return dal.getBySumSaldo();
        }

        //public Cliente getBySaldo(Cliente cliente)
        //{
        //    StringBuilder erros = new StringBuilder();

        //    if (cliente.Saldo < 0 || cliente.Saldo != 0)
        //    {
        //        erros.AppendLine("O saldo do cliente deve ser informado. ");
        //    }

        //    return dal.getBySaldo(cliente.Saldo);
        //}
    }
}
