using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosOOpt102
{
    class Estacionamento
    {
        private string _nomeDono;
        private string _placaCarro;

        public Estacionamento(string nomeDono, string placaCarro)
        {
            this._nomeDono = nomeDono;
            this._placaCarro = placaCarro;
        }

        public void SetNomeDono(string nomeDono)
        {
            this._nomeDono = nomeDono;
        }

        public string GetNomeDono()
        {
            return this._nomeDono;
        }

        public void SetPlacaCarro(string placaCarro)
        {
            this._placaCarro = placaCarro;
        }

        public string GetPlacaCarro()
        {
            return this._placaCarro;
        }
    }
}
