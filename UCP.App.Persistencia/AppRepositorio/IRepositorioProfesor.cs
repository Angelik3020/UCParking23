using System.Collections.Generic;
using UCP.App.Dominio;

namespace UCP.App.Persistencia
{
    public interface IRepositorioProfesor
    {
        //CRUD
        //GetAllProfesores
        IEnumerable<Profesor> GetAllProfesores();
        //AddProfesor
        Profesor AddProfesor(Profesor profesor);
        //UptadateProfesor
        Profesor UpdateProfesor(Profesor profesor);
        //DeleteProfesor
        void DeleteProfesor(int idProfesor);
        //GetProfesor
        Profesor GetProfesor(int idProfesor);
    }
}