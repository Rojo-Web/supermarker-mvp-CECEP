﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.Models
{
    internal class CategoriasModel
    {
        //Validadores
        [DisplayName("Categoria Id")]
        public int Id { get; set; }

        [DisplayName("Categoria Name")]
        //Validadores
        [Required(ErrorMessage = "Categoria name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Categoria name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Descripcion")]
        [Required(ErrorMessage = "Categoria descripcion is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Categoria descripcion must be between 3 and 200 characters")]
        public string Descripcion { get; set; }

    }
}
