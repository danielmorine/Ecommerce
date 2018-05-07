using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Departments
    {
        [Key]
        [Display(Name = "Departamento")]
        public int DepartmentsId { get; set; }

        [Required(ErrorMessage = "O Campo Departamento é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo Nome recebe  no máximo 50 caracteres")]
        [Index("Departament_Name_Index", IsUnique = true),]
        public string Name { get; set; }

        public virtual ICollection<City>  Cities {get; set;}
    }
}