using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Lds_ImobiFlyer.Model
{
    public enum StatusPossiveis { A, V, D, X };
    public class Imovel
    {
        private int id;
        private string? dataMov;
        private decimal valor;
        private string? tipologia;
        private string? localidade;
        private string? finalidade;
        private char status;

        public int Id { get { return id; } set { id = value; } }
        public string DataMov { get { return dataMov; } set { dataMov = value; } }
        public decimal Valor { get { return valor; } set { valor = value; } }
        public string Tipologia { get { return tipologia; } set { tipologia = value; } }
        public string Localidade { get { return localidade; } set { localidade = value; } }
        public string Finalidade { get { return finalidade; } set { finalidade = value; } }
        public char Status { get { return status; } set { status = value; } }

        public override string ToString() { return "Imovel"; }

        public Imovel Clone()
        {
            Imovel i = new Imovel();
            i.id = id;
            i.dataMov = dataMov;
            i.valor = valor;    
            i.tipologia = tipologia;    
            i.localidade = localidade;
            i.finalidade = finalidade;
            i.status = status;
            return i;
        }



    }
}
