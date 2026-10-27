using System;
using System.Collections.Generic;
using System.Text;

namespace VotES.Models
{
    public class EleccionesEN
    {
        public int IdEleccion { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento {  get; set; }
        public ushort IdMunicipio {  get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public enum Estado
        {
            Abiertas,
            Cerradas
        }
        public Estado EstadoDeEleccion{  get; set; }
    }
}
