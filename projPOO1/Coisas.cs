using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projPOO1
{
    class Coisas
    {
        private Coisa[] coisas;
        private int max;
        private int qtde;

        public int Max
        {
            get { return max; }
        }

        public int Qtde
        {
            get { return qtde; }
        }

        public Coisas(int max)
        {
            this.max = max;
            this.qtde = 0;
            this.coisas = new Coisa[this.max];
            for (int i = 0; i < this.max; ++i)
            {
                this.coisas[i] = new Coisa(-1, "...");
            }
        }

        public string mostraCoisas()
        {
            string ret = "";
            foreach (Coisa c in this.coisas)
            {
                ret += c.dados();
            }
            ret += "-------------------------";
            return ret;
        }

        public bool addCoisa(Coisa coisa)
        {
            bool podeAdicionar = (this.qtde < this.max);
            if (podeAdicionar)
            {
                this.coisas[this.qtde] = coisa;
                this.qtde++;
            }
            return podeAdicionar;
        }

        public bool delCoisa(Coisa coisa)
        {
            bool temCoisa = false;
            foreach (Coisa c in this.coisas)
            {
                if (c.Equals(coisa))
                {
                    c.Id = -1;
                    c.Descricao = "...";
                    temCoisa = true;
                }
            }
            return temCoisa;
        }

        public Coisa searchCoisa(Coisa coisa)
        {
            Coisa coisaAchada = new Coisa(-1, "");
            int i = 0;
            while (i<this.max && !this.coisas[i].Equals(coisa))
            {
                i++;
            }
            if (i < this.max)
            {
                coisaAchada = this.coisas[i];
            }
            return coisaAchada;
        }


    }
}
