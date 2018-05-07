using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class City
    {
        [Key]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        [Display(Name = "Cidade")]
        public string Name { get; set; }

        [Required(ErrorMessage ="O campo")]

        [Display(Name = "Departamento")]
        [Range(1, double.MaxValue, ErrorMessage = "Selecione um Departamento")]
        public int DepartmentsId { get; set; }

        public virtual Departments Department { get; set; }
    }
}