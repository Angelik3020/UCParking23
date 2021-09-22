using System;

namespace UCP.App.Dominio
{
    public class Vehiculo
    {
        public int id{get;set;}
        public string modelo{get;set;}
        public string marca{get;set;}
        public TipoVehiculo tipovehiculo {get;set;}
        public string placa {get;set;}

    }
}