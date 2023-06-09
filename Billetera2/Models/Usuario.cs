﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Billetera2.Models
{
    public class Usuario
    {
        
        [Key]
        public Guid Id { get; set; }

        [MinLength(4, ErrorMessage = "El usuario debe tener 4 caracteres como minimo")]
        [MaxLength(180, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string Nombre { get; set; }
        [MinLength(4, ErrorMessage = "La contraseña debe tener 4 caracteres como minimo")]
        [MaxLength(8, ErrorMessage = "El maximo permitido para el {0} es {1}")]
        public string Contrasenia { get; set; }


        public IEnumerable<Movimiento> Movimientos { get; set; }




    }
}
