//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Menajes_Maipu.Models.ModeloBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Carrito = new HashSet<Carrito>();
        }

        public int Id_producto { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        //[RemoteClientServer("IsProductNameAvailable", "Usuario", ErrorMessage = "Este nombre de producto ya fue registrado")]
        public string Nombre_producto { get; set; }

        public byte[] Imagen_producto { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        public string Descripcion_producto { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Ingrese solo n�meros")]
        public Nullable<int> Stock_producto { get; set; }

        [Required(ErrorMessage = "Campo Requerido")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Ingrese solo n�meros")]
        public Nullable<int> Precio_producto { get; set; }
        public int Id_subcategoria { get; set; }
        public string Nombre_imagen { get; set; }
        public Nullable<int> Tipo { get; set; }

        public virtual Subcategoria Subcategoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carrito> Carrito { get; set; }
    }
}
