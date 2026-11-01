using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VotES.Models
{
    public class EleccionesEN
    {
        [Key]
        public int IdEleccion { get; set; }
        public int IdTipo { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento {  get; set; }
        public int IdMunicipio {  get; set; }
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
