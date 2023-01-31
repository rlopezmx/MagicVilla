using MagucVilla_API.Modelos.Dto;

namespace MagucVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> VillaList = new List<VillaDto>
        {
            new VillaDto{Id =1, Nombre ="Vista a la Piscina",   Ocupantes=4, MetrosCuadrados=20},
            new VillaDto{Id =2, Nombre ="Vista a la Playa",     Ocupantes=3, MetrosCuadrados=15},
            new VillaDto{Id =3, Nombre ="Vista a la Calle",     Ocupantes=5, MetrosCuadrados=25},
            new VillaDto{Id =4, Nombre ="Vista al Jardìn",      Ocupantes=2, MetrosCuadrados=10}
         };
    }
}
