using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    class Vehiculo
    {
        String matrícula;
        public String Matrícula
        {
            get { return matrícula; }
            set { matrícula = value; }
        }

        String marca;
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        String modelo;
        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        // Agregar un vehículo al sistema.
        // Inhabilitar / Habilitar un vehículo (si un vehículo necesita mantenimiento, no puede ser utilizado para las clases de manejo).   
        //Dar de baja un vehículo (porque se vendió).
        //Cargar los vehículos a partir de un archivo de texto definido por ustedes.
        //Listado de los vehículos.
    }
}
