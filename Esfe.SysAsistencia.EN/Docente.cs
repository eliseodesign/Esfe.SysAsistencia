﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.SysAsistencia.EN
{
    /// <summary>
    /// Clase que representa a un Docente.
    /// </summary>
    public class Docente
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Cel { get; set; }
        public string Dui { get; set; }
        public byte[] Huella { get; set; }
        public byte IdCarrera { get; set; }


    }

}
