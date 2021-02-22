using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PreguntaDTO
    {

        public int NumPregunta { get; set; }
        public string Enunciado { get; set; }
        public int Nivel { get; set; }
        public RespuestaDTO[] Respuestas { get; set; }

        public PreguntaDTO(int numPregunta, string enunciado, int nivel, RespuestaDTO[] respuestas)
        {
            NumPregunta = numPregunta;
            Enunciado = enunciado;
            Nivel = nivel;
            Respuestas = respuestas;
        }
    }
}
