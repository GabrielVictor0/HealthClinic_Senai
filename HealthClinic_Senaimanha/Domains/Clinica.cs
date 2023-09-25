using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_Senaimanha.Domains
{
    [Table(nameof(Clinica))]
    [Index(nameof(CNPJ), IsUnique = true)]
    [Index(nameof(RazaoSocial), IsUnique = true)]
    public class Clinica
    {

        [Key]
        public Guid IdClinica { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="Endereço é obrigatório!")]
        public string? Endereco { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage ="Nome fantasia  é obrigatório")]
        public string? NomeFantasia { get; set; }

        [Column(TypeName ="CHAR(14)")]
        [Required(ErrorMessage ="CNPJ obrigatorio")]
        public string? CNPJ { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage ="Horario de abertura obrigatorio")]
        public DateTime HorarioAbertura { get; set; }

        [Column(TypeName ="DATE")]
        [Required(ErrorMessage ="Horario de fechamento obrigatorio")]
        public DateTime HorarioFechamento { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Razao Social obrigatorio")]
        public string? RazaoSocial { get; set; }

        [Column(TypeName ="VARCHAR(100)")]
        [Required(ErrorMessage ="Telefone obrigatorio")]
        public string? Telefone { get; set; }

    }
}
