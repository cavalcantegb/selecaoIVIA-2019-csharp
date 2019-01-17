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
            return ParseLetraParaNumero(this.palavra);
        }

        private int ParseLetraParaNumero(string letra)
        {
            switch (letra)
            {
                case "a":
                    return 1;
                case "b":
                    return 2;
                case "c":
                    return 3;
                case "d":
                    return 4;
                case "e":
                    return 5;
                case "f":
                    return 6;
                case "g":
                    return 7;
                case "h":
                    return 8;
                case "i":
                    return 9;
                case "j":
                    return 10;
                case "k":
                    return 11;
                case "l":
                    return 12;
                case "m":
                    return 13;
                case "n":
                    return 14;
                case "o":
                    return 15;
                case "p":
                    return 16;
                case "q":
                    return 17;
                case "r":
                    return 18;
                case "s":
                    return 19;
                case "t":
                    return 20;
                case "u":
                    return 21;
                case "v":
                    return 22;
                case "x":
                    return 23;
                case "w":
                    return 24;
                case "y":
                    return 25;
                case "z":
                    return 26;
                case "A":
                    return 27;
                default:
                    return 0;
            }
        }

    }

}