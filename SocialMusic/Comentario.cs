using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMusic
{
    public class Comentario
    {
        public int TxID { get; set; }

        public Guid PessoaID { get; set; }

        public string Texto { get; set; }

        public DateTime Horario { get; set; }


    }
}
