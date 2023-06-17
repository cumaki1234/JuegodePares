using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int TamanioColumnasFilas = 4;
        int Movimientos = 5;
        int CantidadDeCartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;

        public Form1()
        {
            InitializeComponent();
            ButtonNormal.Checked = true;
            ButtonAnimales.Checked = true;  
            
        }

        

        public void iniciarJuego()
        {
            timer1.Enabled = false;
            timer1.Stop();
            CantidadDeCartasVolteadas =0;
            Paneljuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();

            for(int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAletorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAletorio.Next());
            foreach(string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamanioColumnasFilas;
            tablaPanel.ColumnCount= TamanioColumnasFilas;
            for(int i=0;i<TamanioColumnasFilas;i++)
            {
                var Porcentaje=150f/(float)TamanioColumnasFilas-10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent,Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;
            for (var i=0;i<TamanioColumnasFilas;i++)
            {
                for(var j=0;j<TamanioColumnasFilas;j++)
                {
                    var CartasJUego = new PictureBox();
                    CartasJUego.Name = string.Format("{0}", contadorFichas);
                    CartasJUego.Dock = DockStyle.Fill;
                    CartasJUego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJUego.Image = Properties.Resources.XD;
                    CartasJUego.Cursor = Cursors.Hand;
                    CartasJUego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(CartasJUego, j, i);
                    contadorFichas++;
                }

            }
            tablaPanel.Dock = DockStyle.Fill;
            Paneljuego.Controls.Add (tablaPanel);
        }


        public void iniciarJuegoFrutas()
        {
            timer2.Enabled = false;
            timer2.Stop();
            CantidadDeCartasVolteadas = 0;
            Paneljuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();

            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAletorio = new Random();

            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAletorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamanioColumnasFilas;
            tablaPanel.ColumnCount = TamanioColumnasFilas;
            for (int i = 0; i < TamanioColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamanioColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;
            for (var i = 0; i < TamanioColumnasFilas; i++)
            {
                for (var j = 0; j < TamanioColumnasFilas; j++)
                {
                    var CartasJUego = new PictureBox();
                    CartasJUego.Name = string.Format("{0}", contadorFichas);
                    CartasJUego.Dock = DockStyle.Fill;
                    CartasJUego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJUego.Image = Properties.Resources.XD2;
                    CartasJUego.Cursor = Cursors.Hand;
                    CartasJUego.Click += btnCartaFRU_Click;
                    tablaPanel.Controls.Add(CartasJUego, j, i);
                    contadorFichas++;
                }

            }
            tablaPanel.Dock = DockStyle.Fill;
            Paneljuego.Controls.Add(tablaPanel);
        }

        public void iniciarJuegoNumeros()
        {
            timer3.Enabled = false;
            timer3.Stop();
            CantidadDeCartasVolteadas = 0;
            Paneljuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();

            for (int i = 0; i < 8; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAletorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAletorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = TamanioColumnasFilas;
            tablaPanel.ColumnCount = TamanioColumnasFilas;
            for (int i = 0; i < TamanioColumnasFilas; i++)
            {
                var Porcentaje = 150f / (float)TamanioColumnasFilas - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
            int contadorFichas = 1;
            for (var i = 0; i < TamanioColumnasFilas; i++)
            {
                for (var j = 0; j < TamanioColumnasFilas; j++)
                {
                    var CartasJUego = new PictureBox();
                    CartasJUego.Name = string.Format("{0}", contadorFichas);
                    CartasJUego.Dock = DockStyle.Fill;
                    CartasJUego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJUego.Image = Properties.Resources.XD3;
                    CartasJUego.Cursor = Cursors.Hand;
                    CartasJUego.Click += btnCartaNUM_Click;
                    tablaPanel.Controls.Add(CartasJUego, j, i);
                    contadorFichas++;
                }

            }
            tablaPanel.Dock = DockStyle.Fill;
            Paneljuego.Controls.Add(tablaPanel);
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (ButtonAnimales.Checked)
            {
                iniciarJuego();
            }else if (ButtonFrutas.Checked)
            {
                iniciarJuegoFrutas();
            }else if (ButtonNumeros.Checked)
            {
                iniciarJuegoNumeros();  
            }
            if (ButtonDificil.Checked && Movimientos > 0)
            {
                lblRecord.Text = "5";
                Movimientos = 5;

            }
            else if (ButtonNormal.Checked && Movimientos >0)
            {
                lblRecord.Text = "10";
                Movimientos = 10;
            }
            else if (ButtonFacil.Checked && Movimientos > 0)
            {
                lblRecord.Text = "15";
                Movimientos = 15;
            }

        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            
            if (CartasSeleccionadas.Count < 2)
            {
                var CartasSeleccionadasUsuario = (PictureBox)sender;
                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                if (CartasSeleccionadas.Count == 2)
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);
                    if (Carta1 != Carta2)
                    {
                        Movimientos--;
                        lblRecord.Text = Convert.ToString(Movimientos);
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    { 
                        CantidadDeCartasVolteadas++;
                        if (CantidadDeCartasVolteadas > 7)
                        {
                            MessageBox.Show("El juego termino");
                        }
                        CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();
                    }
                    if (Movimientos <= 0)
                    {
                        MessageBox.Show("se agotaron los intentos");
                        iniciarJuego();
                    }
                    if (ButtonDificil.Checked && Movimientos == 0)
                    {
                        lblRecord.Text = "5";
                        Movimientos = 5;

                    }
                    else if (ButtonNormal.Checked && Movimientos == 0)
                    {
                        lblRecord.Text = "10";
                        Movimientos = 10;
                    }
                    else if (ButtonFacil.Checked && Movimientos == 0)
                    {
                        lblRecord.Text = "15";
                        Movimientos = 15;
                    }
                }
               
               
            

            }

        }
        private void btnCartaFRU_Click(object sender, EventArgs e)
        {
            if (CartasSeleccionadas.Count < 2)
            {
                var CartasSeleccionadasUsuario = (PictureBox)sender;
                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagenFru(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                if (CartasSeleccionadas.Count == 2)
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);
                    if (Carta1 != Carta2)
                    {
                        Movimientos--;
                        lblRecord.Text = Convert.ToString(Movimientos);
                        timer2.Enabled = true;
                        timer2.Start();
                    }
                    else
                    {
                        CantidadDeCartasVolteadas++;
                        if (CantidadDeCartasVolteadas > 7)
                        {
                            MessageBox.Show("El juego termino");
                        }
                        CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();
                    }
                    if (Movimientos <= 0)
                    {
                        MessageBox.Show("se agotaron los intentos");
                        iniciarJuegoFrutas();
                    }
                    if (ButtonDificil.Checked && Movimientos == 0)
                    {
                        lblRecord.Text = "5";
                        Movimientos = 5;

                    }
                    else if (ButtonNormal.Checked && Movimientos == 0)
                    {
                        lblRecord.Text = "10";
                        Movimientos = 10;
                    }
                    else if (ButtonFacil.Checked && Movimientos == 0)
                    {
                        lblRecord.Text = "15";
                        Movimientos = 15;
                    }
                }




            }
        }

        private void btnCartaNUM_Click(object sender, EventArgs e)
        {
            if (CartasSeleccionadas.Count < 2)
            {
                var CartasSeleccionadasUsuario = (PictureBox)sender;
                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagenNum(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                if (CartasSeleccionadas.Count == 2)
                {
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);
                    if (Carta1 != Carta2)
                    {
                        Movimientos--;
                        lblRecord.Text = Convert.ToString(Movimientos);
                        timer3.Enabled = true;
                        timer3.Start();
                    }
                    else
                    {
                        CantidadDeCartasVolteadas++;
                        if (CantidadDeCartasVolteadas > 7)
                        {
                            MessageBox.Show("El juego termino");
                        }
                        CartaTemporal1.Enabled = false; CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();
                    }
                    if (Movimientos <= 0)
                    {
                        MessageBox.Show("se agotaron los intentos");
                        iniciarJuegoNumeros();
                    }
                    if (ButtonDificil.Checked && Movimientos == 0)
                    {
                        lblRecord.Text = "5";
                        Movimientos = 5;

                    }
                    else if (ButtonNormal.Checked && Movimientos == 0)
                    {
                        lblRecord.Text = "10";
                        Movimientos = 10;
                    }
                    else if (ButtonFacil.Checked && Movimientos == 0)
                    {
                        lblRecord.Text = "15";
                        Movimientos = 15;
                    }
                }




            }
        }
        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);
            switch (NumeroImagen)
            {
                case 0: TmpImg = Properties.Resources.img8;
                    break;
                default:TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img"+NumeroImagen);
                    break;
            }
        return TmpImg;
        }


        public Bitmap RecuperarImagenFru(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);
            switch (NumeroImagen)
            {
                case 0:
                    TmpImg = Properties.Resources.imga8;
                    break;
                default:
                    TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("imga" + NumeroImagen);
                    break;
            }
            return TmpImg;
        }

        public Bitmap RecuperarImagenNum(int NumeroImagen)
        {
            Bitmap TmpImg = new Bitmap(200, 100);
            switch (NumeroImagen)
            {
                case 0:
                    TmpImg = Properties.Resources.imgn8;
                    break;
                default:
                    TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("imgn" + NumeroImagen);
                    break;
            }
            return TmpImg;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ButtonAnimales.Checked)
            {
                int TiempoVirarCarta = 1;
                if (TiempoVirarCarta == 1)
                {
                    CartaTemporal1.Image = Properties.Resources.XD;
                    CartaTemporal2.Image = Properties.Resources.XD;
                    CartasSeleccionadas.Clear();
                    TiempoVirarCarta = 0;
                    timer1.Stop();
                }
            }
        }

        private void ButtonNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (ButtonNormal.Checked)
            {
                lblRecord.Text = "10";
                Movimientos = 10;
                if (ButtonAnimales.Checked)
                {

                    iniciarJuego();
                }
                else if (ButtonFrutas.Checked)
                {
                    iniciarJuegoFrutas();
                }
                else if (ButtonNumeros.Checked)
                {
                    iniciarJuegoNumeros();
                }
            } 
        }

        private void ButtonDificil_CheckedChanged(object sender, EventArgs e)
        {
            if (ButtonDificil.Checked)
            {
                lblRecord.Text = "5";
                Movimientos = 5;
                if (ButtonAnimales.Checked)
                {

                    iniciarJuego();
                }else if (ButtonFrutas.Checked)
                {
                    iniciarJuegoFrutas();
                }else if (ButtonNumeros.Checked)
                {
                    iniciarJuegoNumeros();
                }
            
            }
        }

        private void ButtonFacil_CheckedChanged(object sender, EventArgs e)
        {
            if (ButtonFacil.Checked)
            {
                lblRecord.Text = "15";
                Movimientos = 15;
                if (ButtonAnimales.Checked)
                {

                    iniciarJuego();
                }
                else if (ButtonFrutas.Checked)
                {
                    iniciarJuegoFrutas();
                }
                else if (ButtonNumeros.Checked)
                {
                    iniciarJuegoNumeros();
                }

            }
        }

        private void ButtonNumeros_CheckedChanged(object sender, EventArgs e)
        {
            iniciarJuegoNumeros();
        }

        private void ButtonAnimales_CheckedChanged(object sender, EventArgs e)
        {
            iniciarJuego();
        }

        private void ButtonFrutas_CheckedChanged(object sender, EventArgs e)
        {
            iniciarJuegoFrutas();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ButtonFrutas.Checked)
            {
                int TiempoVirarCarta = 1;
                if (TiempoVirarCarta == 1)
                {
                    CartaTemporal1.Image = Properties.Resources.XD2;
                    CartaTemporal2.Image = Properties.Resources.XD2;
                    CartasSeleccionadas.Clear();
                    TiempoVirarCarta = 0;
                    timer2.Stop();
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ButtonNumeros.Checked)
            {
                int TiempoVirarCarta = 1;
                if (TiempoVirarCarta == 1)
                {
                    CartaTemporal1.Image = Properties.Resources.XD3;
                    CartaTemporal2.Image = Properties.Resources.XD3;
                    CartasSeleccionadas.Clear();
                    TiempoVirarCarta = 0;
                    timer3.Stop();
                }
            }
        }
    }
}
