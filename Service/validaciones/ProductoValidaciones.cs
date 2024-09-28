using ModelORM;
using Service.Constantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;


namespace Service.validaciones
{
    public class ProductoValidaciones
    {

        public ProductoValidaciones() { }

        public void validate(producto prod)
        {
            if (prod == null)
            {
                throw new Exception("El producto que intenta agregar esta vacio. Complete los datos");
            }

        }


        private void validarPrecio(Decimal precio)
        {
            if (precio <= 0)
            {
                throw new Exception("El precio del producto contiene un valor no valido. Verificar que no este vacio o con valor zero o negativo");
            }
        }

        private void validarStock(int stock)
        {
            if (stock < 0)
            {
                throw new Exception("El stock del producto no puede ser negativo. Verificar");
            }
        }

        private void validateSku(string sku)
        {
            if (string.IsNullOrEmpty(sku) || sku.Length < 6 || Regex.IsMatch(sku, RegexConstants.CARACTERES_NO_ALFANUMERICOS)) {
                throw new Exception("El sku no es valido, el mismo no puede ser vacio | contener menos de 6 caracteres | contener caracteres no alfanumericos");
            }
        }

        private void validateCodigoBarra(string codigoBarra)
        {
            if (string.IsNullOrEmpty(codigoBarra) || codigoBarra.Length < 10 || Regex.IsMatch(codigoBarra, RegexConstants.CARACTERES_NO_NUMERICOS))
            {
                throw new Exception("El codigo de barras no es valido, el mismo no puede ser vacio | contener menos de 10 caracteres | contener caracteres no numericos");
            }
        }

        private void validateDescripcion(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion))
            {
                throw new Exception("La descripcion del producto no puede estar vacia");
            }
        }
    }
}
