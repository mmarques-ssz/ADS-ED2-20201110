using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projPOO1
{
    class Coisa
    {
        private int id;
        private string descricao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public Coisa(int id, string descricao)
        {
            this.id = id;
            this.descricao = descricao;
        }

        public Coisa(): this(0, "")
        {
        }

        public string dados()
        {
            return this.id.ToString() + " - " + this.descricao + '\n';
        }

        public override bool Equals(object obj)
        {
            return this.id.Equals(((Coisa)obj).id);
        }
    }
}
