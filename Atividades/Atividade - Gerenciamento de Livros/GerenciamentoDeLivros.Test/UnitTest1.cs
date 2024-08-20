using GerenciamentoDeLivros.Itens;

namespace GerenciamentoDeLivros.Test
{
    public class UnitTest1
    {
        [Fact]
        public void LivroFoiAdicionado()
        {
            // arrange
            var titulo = "Revolu��o dos bichos";
            var autor = "George Orwell";
            var genero = "N�o sei";

            // act
            var resultado = Gerenciamento.AdicionarLivros(titulo, autor, genero);

            // assert
            Assert.Equal(resultado, true);
        }
    }
}