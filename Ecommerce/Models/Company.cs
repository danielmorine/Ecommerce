using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Company
    {
        [Key]
        [Display(Name = "Companhia")]
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "O campo Nome é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Campo Nome recebe no máximo 50 caracteres")]
        [Display(Name = "Nome")]
        [Index("Department_Name_Index", IsUnique = true)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo telefone é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Campo telefone recebe no máximo 50 caracteres")]
        [Display(Name = "Telefone")]
        //[Index("Department_Name_Index", IsUnique = true)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "O campo endereço é Obrigatório")]
        [MaxLength(50, ErrorMessage = "O Campo endereço recebe no máximo 50 caracteres")]
        [Display(Name = "Endereço")]
        public string Andress { get; set; }

        [Display(Name = "Imagem")]
        [DataType(DataType.ImageUrl)]
        public string Logo { get; set; }

        [NotMapped]
        public HttpPostedFileBase LogoFile { get; set; }


        [Required(ErrorMessage = "O campo Cidade é Obrigatório")]
        [Display(Name = "Cidade")]
        public int CityId { get; set; }

        [Required(ErrorMessage = "O campo Departamento é Obrigatório")]
        [Display(Name = "Departamento")]
        public int DepartmentsId { get; set; }

        public virtual Departments Departments { get; set; }
        public virtual City Cities { get; set; }
    }
}