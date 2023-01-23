﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string cedula, nombre, correo, password;
        private int id, edad;
        private bool admin;
        private dynamic? imagen;

        public Persona()
        {
            this.admin = false;
            this.imagen = null;
            this.id = -1;
            this.edad = 0;
            this.cedula = "";
            this.nombre = "";
            this.correo = "";
            this.password = "";
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }
        public int Edad { get => edad; set => edad = value; }
        public bool Admin { get => admin; set => admin = value; }
        public dynamic Imagen { get => imagen!; set => imagen = value; }

        
    }
}
