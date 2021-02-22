using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using Entidades;

namespace CapaNegocio
{
    public class GestionNg
    {
        GestionDSet gestionDSet;
        List<PreguntaDTO> preguntas;
        Random rnd;

        public GestionNg(out string error)
        {
             gestionDSet = new GestionDSet(out error);
            rnd = new Random();
        }
        public void PreguntasDeNivel(int nivel, out string error)
        {
             preguntas = gestionDSet.PreguntasDeNivel(nivel, out error);

        }
        public PreguntaDTO ObtenerPreguntaAleatoria()
        {
            int max = preguntas.Count;
            if (max == 0)
            {
                return null;
            }
            int indicePregunta = rnd.Next(0, max);
            PreguntaDTO pregunta = preguntas[indicePregunta];
            preguntas.RemoveAt(indicePregunta);
            return pregunta;
        }
    }
}
