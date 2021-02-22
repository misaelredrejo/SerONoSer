using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Tablero
{
    public partial class FrmJuego : Form
    {
        GestionNg gestionNg;
        int acertadas = 0;
        int falladas = 0;
        int nivel = 0;
        int segundos = 0;
        public FrmJuego()
        {
            InitializeComponent();
        }
        private void FrmJuego_Load(object sender, EventArgs e)
        {
            
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            gestionNg = new GestionNg(out string errorNivelMaximo);
            if (!String.IsNullOrWhiteSpace(errorNivelMaximo))
            {
                MessageBox.Show(errorNivelMaximo, "ERROR");
                return;
            }

            string strNivel;
            do
            {
                strNivel = Interaction.InputBox("Nivel", "Nivel", "1");
            } while (!int.TryParse(strNivel, out nivel));

            lblNivel.Text = strNivel;
            nivel = int.Parse(strNivel);
            gestionNg.PreguntasDeNivel(nivel, out string errorPregsDeNivel);
            if (!String.IsNullOrWhiteSpace(errorPregsDeNivel))
            {
                MessageBox.Show(errorPregsDeNivel, "ERROR");
                return;
            }
            SacarPreguntaAlazar();

        }
        private void SacarPreguntaAlazar()
        {
            lblRespuestaValida.Text = null;
            ResetearBotonesRespuesta();
            acertadas = 0;
            falladas = 0;
            PreguntaDTO pregunta = gestionNg.ObtenerPreguntaAleatoria();
            if (pregunta == null)
            {
                nivel++;
                gestionNg.PreguntasDeNivel(nivel, out string pregsDeNivelError);
                if (!String.IsNullOrWhiteSpace(pregsDeNivelError))
                {
                    MessageBox.Show("No quedan más niveles", "FIN DEL JUEGO");
                    this.Close();
                    return;
                }
                SacarPreguntaAlazar();
                lblNivel.Text = nivel.ToString();
                return;

            }
            lblEnunciado.Text = pregunta.Enunciado;
            int indexRespuesta = 0;

            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Tag != null && btn.Name.ToString().ToLower().Contains("btnrespuesta"))
                {
                    btn.Text = pregunta.Respuestas[indexRespuesta].PosibleRespuesta;
                    btn.Tag = pregunta.Respuestas[indexRespuesta++].Explicacion;
                }
            }
            
            segundos = 15;
            lblTiempo.Text = segundos.ToString();
            tmrTiempoTotal.Interval = 1000;
            tmrTiempoTotal.Start();

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.Enabled = false;
            if (btn.Tag != null && String.IsNullOrEmpty(btn.Tag.ToString()))
            {
                btn.BackColor = Color.Green;
                lblRespuestaValida.Text = null;
                acertadas++;
                if (acertadas == 8)
                {
                    tmrTiempoTotal.Stop();
                    if (MessageBox.Show("Has acertado las 8 respuestas válidas, ¿deseas continuar con otra pregunta?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SacarPreguntaAlazar();
                    }
                }
            } else
            {
                btn.BackColor = Color.Red;
                lblRespuestaValida.Text = btn.Tag.ToString();
                falladas++;
                if (falladas == 4)
                {
                    tmrTiempoTotal.Stop();
                    if (MessageBox.Show("Has fallado las 4 respuestas erróneas, ¿deseas continuar con otra pregunta?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SacarPreguntaAlazar();
                    }
                }
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmrTiempoTotal_Tick(object sender, EventArgs e)
        {
            segundos--;
            lblTiempo.Text = segundos.ToString();
            if (segundos == 0)
            {
                tmrTiempoTotal.Stop();

                if (MessageBox.Show("Te has quedado sin tiempo para esta pregunta, ¿deseas continuar con otra pregunta? No finalizará el programa", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SacarPreguntaAlazar();
                } 
            }
            
        }

        private void ResetearBotonesRespuesta()
        {
            foreach (Button btn in this.Controls.OfType<Button>())
            {
                if (btn.Tag != null && btn.Name.ToString().ToLower().Contains("btnrespuesta"))
                {
                    btn.BackColor = default;
                    btn.Tag = "";
                    btn.Enabled = true;
                }
            }
        }
    }
}