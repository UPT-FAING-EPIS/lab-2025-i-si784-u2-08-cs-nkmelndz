using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Calculator.Domain.Tests.Steps
{
    /// <summary>
    /// Define los pasos de prueba para la funcionalidad de la calculadora usando SpecFlow.
    /// </summary>
    [Binding]
    public sealed class CalculatorTests
    {
        private readonly ScenarioContext _scenarioContext;

        /// <summary>
        /// Instancia de la calculadora usada en las pruebas.
        /// </summary>
        public Calculator Calculadora { get; set; }

        /// <summary>
        /// Primer operando.
        /// </summary>
        private int _operador01 { get; set; }

        /// <summary>
        /// Segundo operando.
        /// </summary>
        private int _operador02 { get; set; }

        /// <summary>
        /// Resultado de la operación.
        /// </summary>
        private int _resultado { get; set; }

        /// <summary>
        /// Constructor que recibe el contexto del escenario.
        /// </summary>
        /// <param name="scenarioContext">Contexto del escenario actual.</param>
        public CalculatorTests(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            Calculadora = new Calculator();
        }

        /// <summary>
        /// Define el primer número ingresado por el usuario.
        /// </summary>
        /// <param name="operando01">Primer número.</param>
        [Given("El numero (.*)")]
        public void DadoElNumero(int operando01)
        {
            _operador01 = operando01;
        }

        /// <summary>
        /// Define el segundo número ingresado por el usuario.
        /// </summary>
        /// <param name="operando02">Segundo número.</param>
        [Given("el numero (.*)")]
        public void yElNumero(int operando02)
        {
            _operador02 = operando02;
        }

        /// <summary>
        /// Realiza la operación de suma con los operandos definidos.
        /// </summary>
        [When("sumo")]
        public void CuandoSumo()
        {
            _resultado = Calculadora.Add(_operador01, _operador02);
        }

        /// <summary>
        /// Realiza la operación de resta con los operandos definidos.
        /// </summary>
        [When("resto")]
        public void CuandoResto()
        {
            _resultado = Calculadora.Subtract(_operador01, _operador02);
        }

        /// <summary>
        /// Realiza la operación de multiplicación con los operandos definidos.
        /// </summary>
        [When("multiplico")]
        public void CuandoMultiplico()
        {
            _resultado = Calculadora.Multiply(_operador01, _operador02);
        }

        /// <summary>
        /// Realiza la operación de división con los operandos definidos.
        /// </summary>
        [When("divido")]
        public void CuandoDivido()
        {
            _resultado = Calculadora.Divide(_operador01, _operador02);
        }

        /// <summary>
        /// Verifica que el resultado de la operación sea el esperado.
        /// </summary>
        /// <param name="resultado">Resultado esperado.</param>
        [Then("el resultado es (.*)")]
        public void EntoncesElResultadoDeberiaSer(int resultado)
        {
            Assert.AreEqual(resultado, _resultado);
        }
    }
}
