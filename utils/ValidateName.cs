using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DwVideo.utils
{
    internal class ValidateName
    {
        public static string LimpiarNombreArchivo(string texto)
        {
            // Obtenemos la lista de caracteres inválidos del sistema
            var caracteresInvalidos = Path.GetInvalidFileNameChars();

            // Filtramos el texto, removiendo los caracteres inválidos
            return new string(texto.Where(c => !caracteresInvalidos.Contains(c)).ToArray());
        }
    }
}
