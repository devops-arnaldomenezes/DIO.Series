using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos

        private Genero Genero ( get; set; );
        private string Titulo ( get; set; );

       private string Descricao ( get; set; );
       
       private int Ano ( get; set; );

    }
}