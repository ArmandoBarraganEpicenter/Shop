﻿using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace Shop.Data.Entities
{
    public class State
    {
        public int Id { get; set; }
        [Display(Name = "Departamento/Estado")]
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} carácteres.")]
        public string Name { get; set; }

        public Country Country { get; set; }
        public ICollection<City> Cities { get; set; }
        
         [Display(Name = "Ciudades")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
