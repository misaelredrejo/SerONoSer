using CapaDatos.DsSerONoSerTableAdapters;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaDatos.DsSerONoSer;

namespace CapaDatos
{
    public class GestionDSet
    {
        DsSerONoSer dsSerONoSer;
        int maxNivel = 0;
        public GestionDSet(out string msg)
        {

            dsSerONoSer = new DsSerONoSer();
            msg = LLenarTablas();

        }
        private string LLenarTablas()
        {
            string error = "";
            List<String> preguntasSin12Respuestas = new List<String>();
            List<String> preguntasSin8Acertadas4Erroneas = new List<String>();
            List<String> nivelesInferioresAlMaximo = new List<String>();

            // Importamos -> using CapaDatosDSet.DsEstadoTableAdapters;
            PreguntasTableAdapter daPreguntas = new PreguntasTableAdapter();
            RespuestasTableAdapter daRespuestas = new RespuestasTableAdapter();
            RespNoValidasTableAdapter daRespNoValidas = new RespNoValidasTableAdapter();
            try
            {
                // LLenamos tablas si se puede acceder a la base de datos.
                daPreguntas.Fill(dsSerONoSer.Preguntas);
                daRespuestas.Fill(dsSerONoSer.Respuestas);
                daRespNoValidas.Fill(dsSerONoSer.RespNoValidas);

                if (dsSerONoSer.Preguntas.Count == 0)
                {
                    return "No hay preguntas\npóngase en contacto con su administrador@";
                }

                maxNivel = dsSerONoSer.Preguntas.Max(drPreguntas => drPreguntas.Nivel);
                bool[] niveles = new bool[maxNivel];
                foreach (var drPregunta in dsSerONoSer.Preguntas)
                {
                    int respValidas = 0;
                    int respNoValidas = 0;
                    foreach (RespuestasRow drRespuesta in drPregunta.GetRespuestasRows())
                    {
                        if (drRespuesta.Valida)
                        {
                            respValidas++;
                        }
                        else respNoValidas++;
                    }

                    int respTotales = respValidas + respNoValidas;
                    if (respTotales != 12)
                    {
                        preguntasSin12Respuestas.Add(drPregunta.NumPregunta.ToString());
                    }
                    if (respValidas != 8 || respNoValidas != 4)
                    {
                        preguntasSin8Acertadas4Erroneas.Add(drPregunta.NumPregunta.ToString());
                    }

                    niveles[drPregunta.Nivel - 1] = true;
                }


                for (int i = 0; i < maxNivel; i++) if (!niveles[i]) nivelesInferioresAlMaximo.Add((i + 1).ToString());

            }
            catch (Exception e)
            {
                return e.Message;
            }
            if (preguntasSin12Respuestas.Count > 0) error += "Pregunta o preguntas sin 12 respuestas: " +String.Join(" ", preguntasSin12Respuestas) + "\n";
            if (preguntasSin8Acertadas4Erroneas.Count > 0) error += "Las siguientes preguntas no tienen 8 respuestas válidas y 4 erróneas: " + String.Join(" ", preguntasSin8Acertadas4Erroneas) + "\n";
            if (nivelesInferioresAlMaximo.Count > 0) error += $"El nivel máximo es {maxNivel} pero no hay preguntas en el nivel o niveles: " + String.Join(" ", nivelesInferioresAlMaximo) + "\n";

            if (!String.IsNullOrWhiteSpace(error)) error += "póngase en contacto con su administrador@";
            return error;
        }
        public List<PreguntaDTO> PreguntasDeNivel(int nivel, out string errorNivelMaximo)
        {
            errorNivelMaximo = "";
            if (nivel > maxNivel)
            {
                errorNivelMaximo = "No existen preguntas de nivel " + nivel + ", máximo nivel -> " + maxNivel;
                return null;
            }

            return dsSerONoSer.Preguntas.Where(drPregunta => drPregunta.Nivel == nivel).Select(drPregunta => new PreguntaDTO(drPregunta.NumPregunta, drPregunta.Enunciado, nivel, drPregunta.GetRespuestasRows().Select(drRespuesta => new RespuestaDTO(drRespuesta.NumPregunta, drRespuesta.NumRespuesta, drRespuesta.PosibleRespuesta, drRespuesta.Valida, drRespuesta.GetRespNoValidasRows().Count() > 0 ? drRespuesta.GetRespNoValidasRows().Select(drRespNoValida => drRespNoValida.Explicacion).SingleOrDefault() : "")).ToArray())).ToList();

        }
    }
}
