using System.Collections.Generic;
using UCP.App.Dominio;

namespace UCP.App.Persistencia
{
    public interface IRepositorioEstudiante
    {
        //CRUD
        //GetAllEstudiante
        IEnumerable<Estudiante> GetAllEstudiante();
        //AddEstudiante
        Estudiante AddEstudiante(Estudiante estudiante);
        //UptadateEstudiante
        Estudiante UpdateEstudiante(Estudiante estudiante);
        //DeleteEstudiante
        void DeleteEstudiante(int idEstudiante);
        //GetEstudiante
        Estudiante GetEstudiante(int idEstudiante);
    }
}