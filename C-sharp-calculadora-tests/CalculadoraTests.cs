using C_sharp_calculadora;

namespace C_sharp_calculadora_tests
{
    public class CalculadoraTests
    {
        public Calculadora _calculadora { get; set; }

        public CalculadoraTests()
        {
            this._calculadora = new Calculadora();
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(-10, 2, -8)]
        [InlineData(-4, 20, 16)]
        public void Somar_RetornarCorretamente(float var01, float var02, float result)
        {
            float response = _calculadora.Somar(var01, var02);
            Assert.Equal(result, response);
        }

        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(-10, 2, -12)]
        [InlineData(-4, -20, 16)]
        [InlineData(7, 10, -3)]
        public void Subtrair_RetornarCorretamente(float var01, float var02, float result)
        {
            float response = _calculadora.Subtrair(var01, var02);
            Assert.Equal(result, response);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(-10, 2, -5)]
        [InlineData(-40, 20, -2)]
        public void Dividir_RetornarCorretamente(float var01, float var02, float result)
        {
            float response = _calculadora.Dividir(var01, var02);
            Assert.Equal(result, response);
        }

        [Fact]
        public void Dividir_EnviaUmErro_AoDividirPorZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(999, 0));
        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(-10, 2, -20)]
        [InlineData(-40, 20, -800)]
        public void Multiplicar_RetornarCorretamente(float var01, float var02, float result)
        {
            float response = _calculadora.Multiplicar(var01, var02);
            Assert.Equal(result, response);
        }

        [Fact]
        public void Verifica_HistoricoTemValoresCorretos()
        {
            List<float> expected = new List<float> { 3, -1, 1, 2 };

            Calculadora novaCalculadora = new Calculadora();

            novaCalculadora.Somar(1, 2);
            novaCalculadora.Subtrair(1, 2);
            novaCalculadora.Dividir(2, 2);
            novaCalculadora.Multiplicar(1, 2);

            Assert.Equal(expected, novaCalculadora.Historico);
        }
    }
}
