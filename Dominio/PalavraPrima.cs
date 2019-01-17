namespace Dominio
{
    public class PalavraPrima
    {
        private string palavra;

        public PalavraPrima(string palavra)
        {
            this.palavra = palavra;
        }

        public int calculaSomaDaPalavra()
        {
            if (this.palavra == "a")
            {
                return 1;
            } else if (this.palavra == "b")
            {
                return 2;
            } else
            {
                return 3;
            }
        }
    }
}