using Microsoft.AspNetCore.Mvc;
using ClassLibrary1;  // Asegúrate de agregar la referencia a tu biblioteca de clases

namespace ApiwebCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatataController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Crea una instancia de tu clase
            Class1 class1 = new Class1();

            // Especifica la ruta del archivo
            string filePath = "C:\\Work\\ReposSergio\\Ejercicios\\TryCatch\\TryCatch\\TextFile1.txt";  // Reemplaza esto con la ruta real del archivo

            // Lee el contenido del archivo
            string content = class1.ReadFileContent(filePath);

            // Devuelve el contenido del archivo
            return Ok(content);
        }
    }
}
