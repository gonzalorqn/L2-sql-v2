﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        public int id;
        public string nombre;
        public string apellido;
        public int edad;

        public Persona(int id,string nombre,string apellido, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public override string ToString()
        {
            return "ID: " + this.id + " - Nombre: " + this.nombre + " - Apellido: " + this.apellido + " - Edad: " + this.edad;
        }
    }
}
