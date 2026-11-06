using VotËs.Dtos.Elecciones;
using VotES.Models;

namespace VotËs.Mappers
{
    public static class EleccionesMappers
    {
        public static EleccionesDTO ToEleccionesDTO(this EleccionesEN elecciones)
        {
            return new EleccionesDTO
            {
                Id = elecciones.IdEleccion,
                Tipo=elecciones.TipoEleccion.Nombre,
                Nombre=elecciones.Nombre
            };
            
        }
    }
}
