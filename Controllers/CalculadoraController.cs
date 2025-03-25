using Microsoft.AspNetCore.Mvc;
using tallerBackend2_0.Models;

namespace tallerBackend2_0.Controllers{
    [Route("api/[controller]")]
    public class CalculadoraController : ControllerBase {
        
        [HttpPost]
        [Route("suma")]
        public dynamic Suma([FromBody] CalculadoraModel calculadora){
            // dynamic me permite devolver cualquier valor
            try{
                var resultado = new {
                    estatus = true,
                    valor = calculadora.Num1 + calculadora.Num2
                };

                return resultado;
            }
            catch (Exception ex)
            {
                var resultado = new {
                    estatus = false,
                    valor = $"Error: {ex.Message}"
                };

                return resultado;
            }
        }

        // Resta
        // Multiplicacion
        // Division (trabajar con condicionales)
    }
}