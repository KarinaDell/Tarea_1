using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAjustarFecha_Click(object sender, EventArgs e)
        {
            int entrada = Convert.ToInt32(txtEntrada.Text);
            txtFechaSalida.Text = (entrada >> 8).ToString();
            dateTimePicker1.Value = new DateTime(fechaAno(entrada >> 17), fechaMes(entrada >> 13), fechaDia(entrada >> 8));
        }



        private void btnProcesar_Click(object sender, EventArgs e)
        {
            int entrada = Convert.ToInt32(txtEntrada.Text);
            bitSiete(entrada);
            bitSeis(entrada);
            llenado(entrada);
            direcciones(entrada);
            int fecha = entrada >> 8;
            fecha2(fecha);
        }

        public void bitSiete (int entrada)
        {
            if((entrada & 128) == 128)
                bit7.Image = Properties.Resources.On;
            else
                bit7.Image = Properties.Resources.Off;
        }

        public void bitSeis(int entrada)
        {
            if ((entrada & 64) == 64)
                bit6.Image = Properties.Resources.On;
            else
                bit6.Image = Properties.Resources.Off;
        }

        public void llenado(int entrada)
        {
            switch(entrada & 48)
            {
                case 0: bitLlenado.Image = Properties.Resources.Empty; break; 
                case 16: bitLlenado.Image = Properties.Resources.Medio; break; 
                case 32: bitLlenado.Image = Properties.Resources.Full; break; 
                case 48: bitLlenado.Image = Properties.Resources.Llenandose; break;
            }
        }

        public void direcciones(int entrada)
        {
            switch(entrada & 14)
            {
                case 0: bitBrujula.Image = Properties.Resources.Norte; break;
                case 2: bitBrujula.Image = Properties.Resources.Noreste; break;
                case 4: bitBrujula.Image = Properties.Resources.Este; break;
                case 6: bitBrujula.Image = Properties.Resources.Sureste; break;
                case 8: bitBrujula.Image = Properties.Resources.Sur; break;
                case 10: bitBrujula.Image = Properties.Resources.Suroeste; break;
                case 12: bitBrujula.Image = Properties.Resources.Oeste; break;
                case 14: bitBrujula.Image = Properties.Resources.Noroeste; break;
            }
        }
        
        public void fecha2(int fecha)
        {
            lblFechaSalida.Text = fechaDia(fecha).ToString() + "/" + fechaMes(fecha >> 5) + "/" + fechaAno(fecha >> 9);
        }

        public int fechaDia(int fecha)
        {
            if ((fecha & 31) != 0)
                return fecha & 31;
            else return 1;
        }

        public int fechaMes(int fecha)
        {
            if ((fecha & 15) <= 12 && (fecha & 15) > 0)
                return fecha & 15;
            else return 1;
        }

        public int fechaAno(int fecha)
        {
            if ((fecha & 127) != 0)
                return (fecha & 127) + 1900;
            else return 1900;
        }
    }
}
