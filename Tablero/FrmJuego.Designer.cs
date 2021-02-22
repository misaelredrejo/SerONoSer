namespace Tablero
{
    partial class FrmJuego
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblRespuestaValida = new System.Windows.Forms.Label();
            this.lblEnunciado = new System.Windows.Forms.Label();
            this.btnRespuesta12 = new System.Windows.Forms.Button();
            this.btnRespuesta11 = new System.Windows.Forms.Button();
            this.btnRespuesta10 = new System.Windows.Forms.Button();
            this.btnRespuesta9 = new System.Windows.Forms.Button();
            this.btnRespuesta8 = new System.Windows.Forms.Button();
            this.btnRespuesta7 = new System.Windows.Forms.Button();
            this.btnRespuesta6 = new System.Windows.Forms.Button();
            this.btnRespuesta5 = new System.Windows.Forms.Button();
            this.btnRespuesta4 = new System.Windows.Forms.Button();
            this.btnRespuesta3 = new System.Windows.Forms.Button();
            this.btnRespuesta2 = new System.Windows.Forms.Button();
            this.btnRespuesta1 = new System.Windows.Forms.Button();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.tmrTiempoTotal = new System.Windows.Forms.Timer(this.components);
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRespuestaValida
            // 
            this.lblRespuestaValida.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lblRespuestaValida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblRespuestaValida.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespuestaValida.Location = new System.Drawing.Point(84, 644);
            this.lblRespuestaValida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespuestaValida.Name = "lblRespuestaValida";
            this.lblRespuestaValida.Size = new System.Drawing.Size(1060, 68);
            this.lblRespuestaValida.TabIndex = 29;
            this.lblRespuestaValida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnunciado
            // 
            this.lblEnunciado.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lblEnunciado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblEnunciado.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunciado.Location = new System.Drawing.Point(83, 14);
            this.lblEnunciado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnunciado.Name = "lblEnunciado";
            this.lblEnunciado.Size = new System.Drawing.Size(1060, 68);
            this.lblEnunciado.TabIndex = 28;
            this.lblEnunciado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRespuesta12
            // 
            this.btnRespuesta12.Enabled = false;
            this.btnRespuesta12.Location = new System.Drawing.Point(895, 463);
            this.btnRespuesta12.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta12.Name = "btnRespuesta12";
            this.btnRespuesta12.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta12.TabIndex = 27;
            this.btnRespuesta12.Tag = "respuesta";
            this.btnRespuesta12.UseVisualStyleBackColor = true;
            this.btnRespuesta12.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta11
            // 
            this.btnRespuesta11.Enabled = false;
            this.btnRespuesta11.Location = new System.Drawing.Point(624, 463);
            this.btnRespuesta11.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta11.Name = "btnRespuesta11";
            this.btnRespuesta11.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta11.TabIndex = 26;
            this.btnRespuesta11.Tag = "respuesta";
            this.btnRespuesta11.UseVisualStyleBackColor = true;
            this.btnRespuesta11.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta10
            // 
            this.btnRespuesta10.Enabled = false;
            this.btnRespuesta10.Location = new System.Drawing.Point(352, 463);
            this.btnRespuesta10.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta10.Name = "btnRespuesta10";
            this.btnRespuesta10.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta10.TabIndex = 25;
            this.btnRespuesta10.Tag = "respuesta";
            this.btnRespuesta10.UseVisualStyleBackColor = true;
            this.btnRespuesta10.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta9
            // 
            this.btnRespuesta9.Enabled = false;
            this.btnRespuesta9.Location = new System.Drawing.Point(79, 463);
            this.btnRespuesta9.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta9.Name = "btnRespuesta9";
            this.btnRespuesta9.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta9.TabIndex = 24;
            this.btnRespuesta9.Tag = "respuesta";
            this.btnRespuesta9.UseVisualStyleBackColor = true;
            this.btnRespuesta9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta8
            // 
            this.btnRespuesta8.Enabled = false;
            this.btnRespuesta8.Location = new System.Drawing.Point(895, 290);
            this.btnRespuesta8.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta8.Name = "btnRespuesta8";
            this.btnRespuesta8.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta8.TabIndex = 23;
            this.btnRespuesta8.Tag = "respuesta";
            this.btnRespuesta8.UseVisualStyleBackColor = true;
            this.btnRespuesta8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta7
            // 
            this.btnRespuesta7.Enabled = false;
            this.btnRespuesta7.Location = new System.Drawing.Point(624, 290);
            this.btnRespuesta7.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta7.Name = "btnRespuesta7";
            this.btnRespuesta7.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta7.TabIndex = 22;
            this.btnRespuesta7.Tag = "respuesta";
            this.btnRespuesta7.UseVisualStyleBackColor = true;
            this.btnRespuesta7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta6
            // 
            this.btnRespuesta6.Enabled = false;
            this.btnRespuesta6.Location = new System.Drawing.Point(352, 290);
            this.btnRespuesta6.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta6.Name = "btnRespuesta6";
            this.btnRespuesta6.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta6.TabIndex = 21;
            this.btnRespuesta6.Tag = "respuesta";
            this.btnRespuesta6.UseVisualStyleBackColor = true;
            this.btnRespuesta6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta5
            // 
            this.btnRespuesta5.Enabled = false;
            this.btnRespuesta5.Location = new System.Drawing.Point(79, 290);
            this.btnRespuesta5.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta5.Name = "btnRespuesta5";
            this.btnRespuesta5.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta5.TabIndex = 20;
            this.btnRespuesta5.Tag = "respuesta";
            this.btnRespuesta5.UseVisualStyleBackColor = true;
            this.btnRespuesta5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta4
            // 
            this.btnRespuesta4.Enabled = false;
            this.btnRespuesta4.Location = new System.Drawing.Point(895, 122);
            this.btnRespuesta4.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta4.Name = "btnRespuesta4";
            this.btnRespuesta4.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta4.TabIndex = 19;
            this.btnRespuesta4.Tag = "respuesta";
            this.btnRespuesta4.UseVisualStyleBackColor = true;
            this.btnRespuesta4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta3
            // 
            this.btnRespuesta3.Enabled = false;
            this.btnRespuesta3.Location = new System.Drawing.Point(624, 122);
            this.btnRespuesta3.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta3.Name = "btnRespuesta3";
            this.btnRespuesta3.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta3.TabIndex = 18;
            this.btnRespuesta3.Tag = "respuesta";
            this.btnRespuesta3.UseVisualStyleBackColor = true;
            this.btnRespuesta3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta2
            // 
            this.btnRespuesta2.Enabled = false;
            this.btnRespuesta2.Location = new System.Drawing.Point(352, 122);
            this.btnRespuesta2.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta2.Name = "btnRespuesta2";
            this.btnRespuesta2.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta2.TabIndex = 17;
            this.btnRespuesta2.Tag = "respuesta";
            this.btnRespuesta2.UseVisualStyleBackColor = true;
            this.btnRespuesta2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRespuesta1
            // 
            this.btnRespuesta1.Enabled = false;
            this.btnRespuesta1.Location = new System.Drawing.Point(79, 122);
            this.btnRespuesta1.Margin = new System.Windows.Forms.Padding(4);
            this.btnRespuesta1.Name = "btnRespuesta1";
            this.btnRespuesta1.Size = new System.Drawing.Size(249, 146);
            this.btnRespuesta1.TabIndex = 16;
            this.btnRespuesta1.Tag = "respuesta";
            this.btnRespuesta1.UseVisualStyleBackColor = true;
            this.btnRespuesta1.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackgroundImage = global::Tablero.Properties.Resources.reset;
            this.btnComenzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnComenzar.Location = new System.Drawing.Point(1201, 327);
            this.btnComenzar.Margin = new System.Windows.Forms.Padding(4);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(147, 78);
            this.btnComenzar.TabIndex = 32;
            this.btnComenzar.Text = "Re/&Comenzar";
            this.btnComenzar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackgroundImage = global::Tablero.Properties.Resources.exit;
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFinalizar.Location = new System.Drawing.Point(1201, 220);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(147, 75);
            this.btnFinalizar.TabIndex = 31;
            this.btnFinalizar.Text = "&Finalizar";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // tmrTiempoTotal
            // 
            this.tmrTiempoTotal.Tick += new System.EventHandler(this.tmrTiempoTotal_Tick);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lblTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTiempo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(1249, 501);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(79, 68);
            this.lblTiempo.TabIndex = 33;
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNivel
            // 
            this.lblNivel.AccessibleRole = System.Windows.Forms.AccessibleRole.Border;
            this.lblNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblNivel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(1249, 60);
            this.lblNivel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(79, 68);
            this.lblNivel.TabIndex = 34;
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1264, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nivel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1217, 463);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tiempo restante";
            // 
            // FrmJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 724);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.lblRespuestaValida);
            this.Controls.Add(this.lblEnunciado);
            this.Controls.Add(this.btnRespuesta12);
            this.Controls.Add(this.btnRespuesta11);
            this.Controls.Add(this.btnRespuesta10);
            this.Controls.Add(this.btnRespuesta9);
            this.Controls.Add(this.btnRespuesta8);
            this.Controls.Add(this.btnRespuesta7);
            this.Controls.Add(this.btnRespuesta6);
            this.Controls.Add(this.btnRespuesta5);
            this.Controls.Add(this.btnRespuesta4);
            this.Controls.Add(this.btnRespuesta3);
            this.Controls.Add(this.btnRespuesta2);
            this.Controls.Add(this.btnRespuesta1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmJuego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.FrmJuego_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnFinalizar;
        internal System.Windows.Forms.Label lblRespuestaValida;
        internal System.Windows.Forms.Label lblEnunciado;
        internal System.Windows.Forms.Button btnRespuesta12;
        internal System.Windows.Forms.Button btnRespuesta11;
        internal System.Windows.Forms.Button btnRespuesta10;
        internal System.Windows.Forms.Button btnRespuesta9;
        internal System.Windows.Forms.Button btnRespuesta8;
        internal System.Windows.Forms.Button btnRespuesta7;
        internal System.Windows.Forms.Button btnRespuesta6;
        internal System.Windows.Forms.Button btnRespuesta5;
        internal System.Windows.Forms.Button btnRespuesta4;
        internal System.Windows.Forms.Button btnRespuesta3;
        internal System.Windows.Forms.Button btnRespuesta2;
        internal System.Windows.Forms.Button btnRespuesta1;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Timer tmrTiempoTotal;
        internal System.Windows.Forms.Label lblTiempo;
        internal System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

