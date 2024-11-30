using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------------------------------//
        //-------------------------------Entrada de Sala y Garage-----------------------------------//
        //------------------------------------------------------------------------------------------//

        private void Abrir_Sala_1_Click(object sender, EventArgs e)
        {
            Entrada_Sala.Visible = false;
            Cerrar_Sala_1.Visible = true;
            Cerrar_Sala_2.Visible = true;
            Abrir_Sala_1.Visible = false;
            Abrir_Sala_2.Visible = false;
        }

        private void Abrir_Sala_2_Click(object sender, EventArgs e)
        {
            Entrada_Sala.Visible = false;
            Cerrar_Sala_1.Visible = true;
            Cerrar_Sala_2.Visible = true;
            Abrir_Sala_1.Visible = false;
            Abrir_Sala_2.Visible = false;
        }

        private void Cerrar_Sala_1_Click(object sender, EventArgs e)
        {
            Entrada_Sala.Visible = true;
            Cerrar_Sala_1.Visible = false;
            Cerrar_Sala_2.Visible = false;
            Abrir_Sala_1.Visible = true;
            Abrir_Sala_2.Visible = true;
        }

        private void Cerrar_Sala_2_Click(object sender, EventArgs e)
        {
            Entrada_Sala.Visible = true;
            Cerrar_Sala_1.Visible = false;
            Cerrar_Sala_2.Visible = false;
            Abrir_Sala_1.Visible = true;
            Abrir_Sala_2.Visible = true;
        }

        private void Abrir_Garage_1_Click(object sender, EventArgs e)
        {
            Entrada_Garage.Visible = false;
            Cerrar_Garage_1.Visible = true;
            Cerrar_Garage_2.Visible = true;
            Abrir_Garage_1.Visible = false;
            Abrir_Garage_2.Visible = false;
        }

        private void Abrir_Garage_2_Click(object sender, EventArgs e)
        {
            Entrada_Garage.Visible = false;
            Cerrar_Garage_1.Visible = true;
            Cerrar_Garage_2.Visible = true;
            Abrir_Garage_1.Visible = false;
            Abrir_Garage_2.Visible = false;
        }

        private void Cerrar_Garage_1_Click(object sender, EventArgs e)
        {
            Entrada_Garage.Visible = true;
            Cerrar_Garage_1.Visible = false;
            Cerrar_Garage_2.Visible = false;
            Abrir_Garage_1.Visible = true;
            Abrir_Garage_2.Visible = true;
        }

        private void Cerrar_Garage_2_Click(object sender, EventArgs e)
        {
            Entrada_Garage.Visible = true;
            Cerrar_Garage_1.Visible = false;
            Cerrar_Garage_2.Visible = false;
            Abrir_Garage_1.Visible = true;
            Abrir_Garage_2.Visible = true;
        }

        //------------------------------------------------------------------------------------------//
        //------------------------------------Puertas Abiertas--------------------------------------//
        //------------------------------------------------------------------------------------------//


        private void Garage_Abierto_Click(object sender, EventArgs e)
        {
            Garage_Abierta.Visible = false;
            Garage_Cerrada.Visible = true;
        }

        private void Cocina_Abierta_Click(object sender, EventArgs e)
        {
            Cocina_Abierta.Visible = false;
            Cocina_Cerrada.Visible = true;
        }

        private void Sala_Abierta_Click(object sender, EventArgs e)
        {
            Sala_Abierta.Visible = false;
            Sala_Cerrada.Visible = true;
        }

        private void Huespedes_Abierta_Click(object sender, EventArgs e)
        {
            Huespedes_Abierta.Visible = false;
            Huespedes_Cerrada.Visible = true;
        }

        private void Baño_Abierta_Click(object sender, EventArgs e)
        {
            Baño_Abierta.Visible = false;
            Baño_Cerrada.Visible = true;
        }

        private void Lavanderia_Abierta_Click(object sender, EventArgs e)
        {
            Lavanderia_Abierta.Visible = false;
            Lavanderia_Cerrada.Visible = true;
        }

        private void Cuarto_Abierta_Click(object sender, EventArgs e)
        {
            Cuarto_Abierta.Visible = false;
            Cuarto_Cerrada.Visible = true;
        }

        //------------------------------------------------------------------------------------------//
        //------------------------------------Puertas Cerradas--------------------------------------//
        //------------------------------------------------------------------------------------------//

        private void Garage_Cerrada_Click(object sender, EventArgs e)
        {
            Garage_Abierta.Visible = true;
            Garage_Cerrada.Visible = false;
        }

        private void Cocina_Cerrada_Click(object sender, EventArgs e)
        {
            Cocina_Abierta.Visible = true;
            Cocina_Cerrada.Visible = false;
        }

        private void Sala_Cerrada_Click(object sender, EventArgs e)
        {
            Sala_Abierta.Visible = true;
            Sala_Cerrada.Visible = false;
        }

        private void Huespedes_Cerrada_Click(object sender, EventArgs e)
        {
            Huespedes_Abierta.Visible = true;
            Huespedes_Cerrada.Visible = false;
        }

        private void Baño_Cerrada_Click(object sender, EventArgs e)
        {
            Baño_Abierta.Visible = true;
            Baño_Cerrada.Visible = false;
        }

        private void Lavanderia_Cerrada_Click(object sender, EventArgs e)
        {
            Lavanderia_Abierta.Visible = true;
            Lavanderia_Cerrada.Visible = false;
        }

        private void Cuarto_Cerrada_Click(object sender, EventArgs e)
        {
            Cuarto_Abierta.Visible = true;
            Cuarto_Cerrada.Visible = false;
        }

        //------------------------------------------------------------------------------------------//
        //-------------------------------------Luces Apagadas---------------------------------------//
        //------------------------------------------------------------------------------------------//

        private void Comedor_Apagada_Click(object sender, EventArgs e)
        {
            Comedor_Apagada.Visible = false;
            Comedor_Encendida.Visible = true;
        }

        private void Entretenimiento_Apagada_Click(object sender, EventArgs e)
        {
            Entretenimiento_Apagada.Visible = false;
            Entretenimiento_Encendida.Visible = true;
        }

        private void Baño_Apagada_Click(object sender, EventArgs e)
        {
            Baño_Apagada.Visible = false;
            Baño_Encendida.Visible = true;
        }

        private void Lavanderia_Apagada_Click(object sender, EventArgs e)
        {
            Lavanderia_Apagada.Visible = false;
            Lavanderia_Encendida.Visible = true;
        }

        private void Cuarto_Apagada_Click(object sender, EventArgs e)
        {
            Cuarto_Apagada.Visible = false;
            Cuarto_Encendida.Visible = true;
        }

        private void Huesped_Apagada_Click(object sender, EventArgs e)
        {
            Huesped_Apagada.Visible = false;
            Huesped_Encendida.Visible = true;
        }

        private void Cocina_Apagada_Click(object sender, EventArgs e)
        {
            Cocina_Apagada.Visible = false;
            Cocina_Encendida.Visible = true;
        }

        private void Garage_Apagada_Click(object sender, EventArgs e)
        {
            Garage_Apagada.Visible = false;
            Garage_Encendida.Visible = true;
        }

        //------------------------------------------------------------------------------------------//
        //------------------------------------Luces Encendidas--------------------------------------//
        //------------------------------------------------------------------------------------------//


        private void Comedor_Encendida_Click(object sender, EventArgs e)
        {
            Comedor_Apagada.Visible = true;
            Comedor_Encendida.Visible = false;
        }

        private void Entretenimiento_Encendida_Click(object sender, EventArgs e)
        {
            Entretenimiento_Apagada.Visible = true;
            Entretenimiento_Encendida.Visible = false;
        }

        private void Baño_Encendida_Click(object sender, EventArgs e)
        {
            Baño_Apagada.Visible = true;
            Baño_Encendida.Visible = false;
        }

        private void Lavanderia_Encendida_Click(object sender, EventArgs e)
        {
            Lavanderia_Apagada.Visible = true;
            Lavanderia_Encendida.Visible = false;
        }

        private void Cuarto_Encendida_Click(object sender, EventArgs e)
        {
            Cuarto_Apagada.Visible = true;
            Cuarto_Encendida.Visible = false;
        }

        private void Huesped_Encendida_Click(object sender, EventArgs e)
        {
            Huesped_Apagada.Visible = true;
            Huesped_Encendida.Visible = false;
        }

        private void Cocina_Encendida_Click(object sender, EventArgs e)
        {
            Cocina_Apagada.Visible = true;
            Cocina_Encendida.Visible = false;
        }

        private void Garage_Encendida_Click(object sender, EventArgs e)
        {
            Garage_Apagada.Visible = true;
            Garage_Encendida.Visible = false;
        }
    }
}
