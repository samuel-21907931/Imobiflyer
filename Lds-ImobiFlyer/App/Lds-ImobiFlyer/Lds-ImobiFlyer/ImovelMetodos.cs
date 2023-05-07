using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lds_ImobiFlyer
{
    internal class ImovelMetodos
    {
        private const string STRVAZIA = "";
        private int id;
        private DateOnly data;
        private string? tipologia;
        private decimal valor;
        private string? localidade;
        private string? finalidade;
        private char status;

        // ******* status *******
        public int Getstatus()
        {
            return status;
        }

        public void Setstatus(char value)
        {
            status = value;
        }

        // ******* id *******
        public int Getid()
        {
            return id;
        }

        public void Setid(int value)
        {
            id = value;
        }

        // ******* data *******
        public DateOnly GetData()
        {
            return data;
        }

        public void SetData(DateOnly value)
        {
            data = value;
        }


        // ******* tipologia *******
        public string Gettipologia()
        {
            if (tipologia != null)
            {
                return tipologia;
            }
            tipologia = STRVAZIA;
            return tipologia;
        }

        public void Settipologia(string value)
        {
            if (value == null)
            {
                tipologia = STRVAZIA;
            }
            else
            {
                tipologia = value;
            }
        }


        // ******* valor *******
        public decimal Getvalor()
        {
            return valor;
        }

        public void Setvalor(decimal value)
        {
            valor = value;
        }


        // ******* localidade *******
        public string Getlocalidade()
        {
            if (localidade != null)
                return localidade;

            localidade = STRVAZIA;
            return localidade;
        }

        public void Setlocalidade(string value)
        {
            if (value == null)
                localidade = STRVAZIA;
            else
                localidade = value;
        }

        // ******* finalidade *******
        public string Getfinalidade()
        {
            if (finalidade != null)
                return finalidade;

            finalidade = STRVAZIA;
            return finalidade;
        }

        public void Setfinalidade(string value)
        {
            if (value == null)
                finalidade = STRVAZIA;
            else
                finalidade = value;
        }

    }
}
