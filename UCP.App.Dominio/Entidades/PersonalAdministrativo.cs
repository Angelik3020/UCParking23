using System;

namespace UCP.App.Dominio
{
    public class PersonalAdministrativo : Persona
    {
        public int id{get;set;}
        
        public string oficina{get;set;}

        public string dependencia{get;set;}
    }
}