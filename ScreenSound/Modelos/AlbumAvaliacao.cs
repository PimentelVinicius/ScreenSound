using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    public class AlbumAvaliacao
    {
        public AlbumAvaliacao()
        {
        }

        public AlbumAvaliacao(int nota)
        {
            if (nota < 0) nota = 0;
            if (nota > 10) nota = 10;
            AlbumAvaliacaoNota = nota;
        }
        public int AlbumAvaliacaoId { get; set; }
        public int AlbumAvaliacaoNota { get; set; }
        public virtual Album album { get; set; }



        public static AlbumAvaliacao Parse(string texto)
        {
            int nota = int.Parse(texto);
            return new AlbumAvaliacao(nota);
        }
    }
}


