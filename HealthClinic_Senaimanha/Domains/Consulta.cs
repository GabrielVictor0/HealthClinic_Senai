using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthClinic_Senaimanha.Domains
{
    [Table(nameof(Consulta))]
    public class Consulta
    {
        [Key]
        public Guid IdConsulta { get; set; } = Guid.NewGuid();

        [Column(TypeName = "SMALLDATETIME")]
        [Required(ErrorMessage = "Informe a data da consulta")]
        public DateTime DataConsulta { get; set; }

        [NotMapped]
        [Column(TypeName ="SMALLDATETIME")]
        [Required(ErrorMessage ="Informe o horario da consulta")]
        public DateTime HorarioConsulta { get; set; }

        [Required(ErrorMessage ="Informe o médico da consulta")]
        public Guid IdMedico {  get; set; }

        [ForeignKey(nameof(IdMedico))]
        public Medico? Medico { get; set; }

        [Required(ErrorMessage ="Informe o paciente da consulta")]
        public Guid IdPaciente { get; set; }

        [ForeignKey(nameof(IdPaciente))]
        public Paciente? Paciente { get; set; }
    }
}
