using System.ComponentModel.DataAnnotations;

public class ProductoViewModel
{
    [Required(ErrorMessage = "El nombre del producto es requerido.")]
    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    [Required(ErrorMessage = "El precio del producto es requerido.")]
    [DataType(DataType.Currency)]
    public decimal Precio { get; set; }
}
