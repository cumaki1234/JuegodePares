namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Paneljuego = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonFacil = new System.Windows.Forms.RadioButton();
            this.ButtonNumeros = new System.Windows.Forms.RadioButton();
            this.ButtonNormal = new System.Windows.Forms.RadioButton();
            this.ButtonAnimales = new System.Windows.Forms.RadioButton();
            this.ButtonDificil = new System.Windows.Forms.RadioButton();
            this.ButtonFrutas = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Paneljuego
            // 
            this.Paneljuego.Location = new System.Drawing.Point(12, 12);
            this.Paneljuego.Name = "Paneljuego";
            this.Paneljuego.Size = new System.Drawing.Size(500, 426);
            this.Paneljuego.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Intentos:";
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(568, 302);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(175, 49);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar Juego";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Location = new System.Drawing.Point(628, 73);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(13, 13);
            this.lblRecord.TabIndex = 3;
            this.lblRecord.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dificultad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modo:";
            // 
            // ButtonFacil
            // 
            this.ButtonFacil.AutoSize = true;
            this.ButtonFacil.Location = new System.Drawing.Point(9, 77);
            this.ButtonFacil.Name = "ButtonFacil";
            this.ButtonFacil.Size = new System.Drawing.Size(47, 17);
            this.ButtonFacil.TabIndex = 6;
            this.ButtonFacil.TabStop = true;
            this.ButtonFacil.Text = "Facil";
            this.ButtonFacil.UseVisualStyleBackColor = true;
            this.ButtonFacil.CheckedChanged += new System.EventHandler(this.ButtonFacil_CheckedChanged);
            // 
            // ButtonNumeros
            // 
            this.ButtonNumeros.AutoSize = true;
            this.ButtonNumeros.Location = new System.Drawing.Point(6, 32);
            this.ButtonNumeros.Name = "ButtonNumeros";
            this.ButtonNumeros.Size = new System.Drawing.Size(67, 17);
            this.ButtonNumeros.TabIndex = 9;
            this.ButtonNumeros.TabStop = true;
            this.ButtonNumeros.Text = "Numeros";
            this.ButtonNumeros.UseVisualStyleBackColor = true;
            this.ButtonNumeros.CheckedChanged += new System.EventHandler(this.ButtonNumeros_CheckedChanged);
            // 
            // ButtonNormal
            // 
            this.ButtonNormal.AutoSize = true;
            this.ButtonNormal.Location = new System.Drawing.Point(9, 55);
            this.ButtonNormal.Name = "ButtonNormal";
            this.ButtonNormal.Size = new System.Drawing.Size(58, 17);
            this.ButtonNormal.TabIndex = 5;
            this.ButtonNormal.TabStop = true;
            this.ButtonNormal.Text = "Normal";
            this.ButtonNormal.UseVisualStyleBackColor = true;
            this.ButtonNormal.CheckedChanged += new System.EventHandler(this.ButtonNormal_CheckedChanged);
            // 
            // ButtonAnimales
            // 
            this.ButtonAnimales.AutoSize = true;
            this.ButtonAnimales.Location = new System.Drawing.Point(6, 55);
            this.ButtonAnimales.Name = "ButtonAnimales";
            this.ButtonAnimales.Size = new System.Drawing.Size(67, 17);
            this.ButtonAnimales.TabIndex = 10;
            this.ButtonAnimales.TabStop = true;
            this.ButtonAnimales.Text = "Animales";
            this.ButtonAnimales.UseVisualStyleBackColor = true;
            this.ButtonAnimales.CheckedChanged += new System.EventHandler(this.ButtonAnimales_CheckedChanged);
            // 
            // ButtonDificil
            // 
            this.ButtonDificil.AutoSize = true;
            this.ButtonDificil.Location = new System.Drawing.Point(9, 32);
            this.ButtonDificil.Name = "ButtonDificil";
            this.ButtonDificil.Size = new System.Drawing.Size(50, 17);
            this.ButtonDificil.TabIndex = 4;
            this.ButtonDificil.TabStop = true;
            this.ButtonDificil.Text = "Dificil";
            this.ButtonDificil.UseVisualStyleBackColor = true;
            this.ButtonDificil.CheckedChanged += new System.EventHandler(this.ButtonDificil_CheckedChanged);
            // 
            // ButtonFrutas
            // 
            this.ButtonFrutas.AutoSize = true;
            this.ButtonFrutas.Location = new System.Drawing.Point(6, 77);
            this.ButtonFrutas.Name = "ButtonFrutas";
            this.ButtonFrutas.Size = new System.Drawing.Size(54, 17);
            this.ButtonFrutas.TabIndex = 11;
            this.ButtonFrutas.TabStop = true;
            this.ButtonFrutas.Text = "Frutas";
            this.ButtonFrutas.UseVisualStyleBackColor = true;
            this.ButtonFrutas.CheckedChanged += new System.EventHandler(this.ButtonFrutas_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonDificil);
            this.groupBox1.Controls.Add(this.ButtonNormal);
            this.groupBox1.Controls.Add(this.ButtonFacil);
            this.groupBox1.Location = new System.Drawing.Point(568, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ButtonFrutas);
            this.groupBox2.Controls.Add(this.ButtonNumeros);
            this.groupBox2.Controls.Add(this.ButtonAnimales);
            this.groupBox2.Location = new System.Drawing.Point(568, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Paneljuego);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Paneljuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton ButtonFacil;
        private System.Windows.Forms.RadioButton ButtonNumeros;
        private System.Windows.Forms.RadioButton ButtonNormal;
        private System.Windows.Forms.RadioButton ButtonAnimales;
        private System.Windows.Forms.RadioButton ButtonDificil;
        private System.Windows.Forms.RadioButton ButtonFrutas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

