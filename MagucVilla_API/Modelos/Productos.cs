namespace MagucVilla_API.Modelos
{
    public class Productos
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string Detalle { get; set; }
        public int Id_Marca { get; set; }
        public int Id_Familia { get; set; }
        public int Id_Linea { get; set; }
        public int Id_UMCompra { get; set; }
        public int Id_UMVenta { get; set; }
        public decimal Conversion { get; set; }
        

    }
}
