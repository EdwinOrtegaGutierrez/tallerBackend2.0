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
        [HttpPost]
        [Route("resta")]
        public dynamic Resta([FromBody] CalculadoraModel calculadora){
            // dynamic me permite devolver cualquier valor
            try{
                var resultado = new {
                    estatus = true,
                    valor = calculadora.Num1 - calculadora.Num2
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
        // Multiplicacion
        [HttpPost]
        [Route("multiplicacion")]
        public dynamic Multiplicacion([FromBody] CalculadoraModel calculadora){
            // dynamic me permite devolver cualquier valor
            try{
                var resultado = new {
                    estatus = true,
                    valor = calculadora.Num1 * calculadora.Num2
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
        // Division (trabajar con condicionales)

        [HttpPost]
        [Route("division")]
        public dynamic Division([FromBody] CalculadoraModel calculadora){
            // dynamic me permite devolver cualquier valor
            try{
                var resultado = new {
                    estatus = true,
                    valor = calculadora.Num2 == 0 ? 0 : calculadora.Num1 / calculadora.Num2
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
    }
}