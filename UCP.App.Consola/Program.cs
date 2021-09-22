using System;
using UCP.App.Dominio;
using UCP.App.Persistencia;
using System.Collections.Generic;
using System.Linq;

namespace UCP.App.Consola
{
    class Program
    {
        private static IRepositorioProfesor _repoProfesor = new RepositorioProfesor(new Persistencia.AppContext());
        private static IRepositorioEstudiante _repoEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World entityFramework!");
            //AddProfesor();
            //BuscarProfesor(1);
            //EliminarProfesor(3);
            //ActualizarProfesor();
            //AddEstudiante();
            ActualizarEstudiante();
        }
        //AddProfesor
        private static void AddProfesor()
        {
            var profesor = new Profesor
            {
                nombre = "Angelica",
                apellidos = "Muñoz Sanchez",
                identificacion = "123465",
                telefono = "3106753666",
                correo = "angelica.munoz21@gmail.com",
                vehiculo_1 = null,
                vehiculo_2 = null,
                facultad ="Ingeniería",
                departamento = "Ciencias Computacionales",
                cubiculo ="Dos" 
            };

            Console.WriteLine(profesor.id+"\n" + profesor.nombre+"\n Cubiculo= "+profesor.cubiculo);
            Profesor profesor_retornado = _repoProfesor.AddProfesor(profesor);
            if (profesor_retornado!=null)
            Console.WriteLine("Se realizo un nuevo registro en la base de datos:>>"+profesor_retornado.id);
        }
            
        //GetProfesor
        private static void BuscarProfesor(int idProfesor)
        {
            var profesor = _repoProfesor.GetProfesor(idProfesor);
            Console.WriteLine(profesor.nombre+" "+profesor.apellidos+"\n Facultad: "+profesor.facultad + " "+profesor.departamento);
        }

        //DeleteProfesor
        private static void EliminarProfesor(int idProfesor)
        {
            _repoProfesor.DeleteProfesor(idProfesor);
        }
       
        //UpdateProfesor
         private static void ActualizarProfesor()
        {
            var profesor = new Profesor 
            {
               id = 2,
               nombre = "Thomas",
               apellidos = "Ramirez",
               identificacion = "110",
               correo =  "Thomas@gmail.com",
               telefono ="3134567684",
               vehiculo_1 = null,
               vehiculo_2 = null,
               facultad ="Ingeniería",
               departamento = "Ciencias Computacionales",
               cubiculo ="Tres"
            };
            Profesor profesor_retornado =_repoProfesor.UpdateProfesor(profesor);                         
            if (profesor_retornado!=null)
                Console.WriteLine("Se registró un profesor en la base de datos");
        
        }

        //GetAllProfesor
          private static void BuscarProfesores()
        {
            IEnumerable<Profesor> profesores = _repoProfesor.GetAllProfesores();
            
            foreach (var profesor in profesores)
            {
                Console.WriteLine(profesor.nombre);
            }
            //Console.WriteLine(profesores.First().nombre);
        }

        //AddEstudiante
        private static void AddEstudiante()
        {
            var estudiante = new Estudiante
            {
                nombre = "Julian",
                apellidos = "Alvaran",
                identificacion = "111",
                telefono = "3104356809",
                correo = "julialva@gmail.com",
                vehiculo_1 = null,
                vehiculo_2 = null,
                programa = "Biologia y quimica" 
            };

            Console.WriteLine(estudiante.id+"\n" + estudiante.nombre+"\n programa= "+ estudiante.programa);
            Estudiante estudiante_retornado = _repoEstudiante.AddEstudiante(estudiante);
            if (estudiante_retornado!=null)
            Console.WriteLine("Se realizo un nuevo registro de estudiante en la base de datos:>>"+estudiante_retornado.id);
        }

         //DeleteEstudiante
        private static void EliminarEstudiante(int idEstudiante)
        {
            _repoEstudiante.DeleteEstudiante(idEstudiante);
        }
       
        //UpdateEstudiante
         private static void ActualizarEstudiante()
        {
            var estudiante = new Estudiante 
            {
               id = 7,
               nombre = "Juan Carlos",
               apellidos = "Londoño",
               identificacion = "111",
               correo =  "Juank@gmail.com",
               telefono ="3214567342",
               vehiculo_1 = null,
               vehiculo_2 = null,
               programa = "Ingeniero Sistemas"
            };
            
            Estudiante estudiante_retornado =_repoEstudiante.UpdateEstudiante(estudiante);                         
            if (estudiante_retornado!=null)
                Console.WriteLine("Se adiciono un nuevo estudiante la base de datos");
        
        }

        //GetAllEstudiante
          private static void BuscarEstudiantes()
        {
            IEnumerable<Estudiante> Estudiantes = _repoEstudiante.GetAllEstudiante();
            
            foreach (var estudiante in Estudiantes)
            {
                Console.WriteLine(estudiante.nombre);
            }

        }      
    }
}
