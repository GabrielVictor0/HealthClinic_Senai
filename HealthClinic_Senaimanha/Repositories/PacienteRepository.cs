using HealthClinic_Senaimanha.Context;
using HealthClinic_Senaimanha.Domains;
using HealthClinic_Senaimanha.Interfaces;

namespace HealthClinic_Senaimanha.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly HealthClinicContext _healthClinicContext;

        public PacienteRepository()
        {
            _healthClinicContext = new HealthClinicContext();
        }

        public void Atualizar(Guid id, Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public Paciente BuscarPorId(Guid id)
        {
            return  _healthClinicContext.Paciente.FirstOrDefault(p => p.IdPaciente == id)!;
        }

        public void Cadastrar(Paciente paciente)
        {
            _healthClinicContext.Paciente.Add(paciente);
        }

        public List<Paciente> ListarTodos()
        {
            return _healthClinicContext.Paciente.ToList();
        }
    }
}
