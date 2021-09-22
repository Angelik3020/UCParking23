using System;

namespace UCP.App.Dominio
{
    public class Transaccion
    {
        public int id{get;set;}
        public DateTime fechaIngreso{get;set;}
        public DateTime fechaSalida{get;set;}
        public float valorHora{get;set;}
        public Vehiculo vehiculo{get;set;}
    }
}