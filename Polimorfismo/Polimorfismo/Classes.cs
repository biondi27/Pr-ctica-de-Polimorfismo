using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    public abstract class Vehiculo
    {
        public virtual string Arrancar()
        {
            return "Su vehículo está arrancando.";
        }
        public abstract string Apagar();
        public abstract string Acelerar();
        public abstract string Cruise();
        public abstract string Desacelerar();
        public abstract string Estacionar();
    }
    public class Ferrari : Vehiculo
    {
        public override string Arrancar()
        {
            return "El Ferrari está encendido.";
        }
        public override string Apagar()
        {
            return "El Ferrari está apagado.";
        }
        public override string Acelerar()
        {
            return "El Ferrari está acelerando.";
        }
        public override string Cruise()
        {
            return "El Ferrari está viajando a una velocidad constante.";
        }
        public override string Desacelerar()
        {
            return "El Ferrari está desacelerando.";
        }
        public override string Estacionar()
        {
            return "El Ferrari está estacionando.";
        }
    }
    public class Porsche : Vehiculo
    {
        public override string Arrancar()
        {
            return "Encendiendo el Porsche...";
        }
        public override string Apagar()
        {
            return "Ha terminado el viaje y se ha apagado el Porsche.";
        }
        public override string Acelerar()
        {
            return "Comenzando a manejar el Porsche y acelerando.";
        }
        public override string Cruise()
        {
            return "Manejando el Porsche a una velocidad rápida y veloz.";
        }
        public override string Desacelerar()
        {
            return "Desacelerando el Porsche y buscando parqueo.";
        }
        public override string Estacionar()
        {
            return "Estacionando el Porsche...";
        }
    }
}