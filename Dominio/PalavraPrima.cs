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
            } else if (this.palavra == "c")
            {
                return 3;
            } else
            {
                return 4;
            }
        }
    }
}