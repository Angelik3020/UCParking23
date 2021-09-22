using UCP.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace UCP.App.Persistencia

{
    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        private readonly AppContext _appContext;

        public RepositorioEstudiante (AppContext appContext)
        {
            _appContext = appContext;
        }

        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            //return profesorAdicionado;
            return estudianteAdicionado.Entity;
        }

        Estudiante IRepositorioEstudiante.UpdateEstudiante (Estudiante estudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == estudiante.id);
            if (estudianteEncontrado != null)
            {
                estudianteEncontrado.nombre = estudiante.nombre;
                estudianteEncontrado.apellidos = estudiante.apellidos;
                estudianteEncontrado.identificacion = estudiante.identificacion;
                estudianteEncontrado.telefono = estudiante.telefono;
                estudianteEncontrado.correo =estudiante.correo;
                estudianteEncontrado.vehiculo_1 = estudiante.vehiculo_1;
                estudianteEncontrado.vehiculo_2 = estudiante.vehiculo_2;
                estudianteEncontrado.programa = estudiante.programa;

                _appContext.SaveChanges();
            }
            return estudianteEncontrado;
        }

        void IRepositorioEstudiante.DeleteEstudiante (int idEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
            if (estudianteEncontrado == null)
                return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }

        Estudiante IRepositorioEstudiante.GetEstudiante(int idEstudiante)
        {
            var estudianteEncontrado= _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
            return estudianteEncontrado;
        }

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiante()
        {
            return _appContext.Estudiantes;
        }
    }
}