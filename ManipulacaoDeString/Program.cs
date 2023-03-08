internal class Program
{
    private static void Main(string[] args)
    {
        string texto;

        Console.Write("Digite uma palavra: ");
        texto = Console.ReadLine();

        Console.WriteLine($"Essa palavra tem {texto.Length} caracteres!");

        Console.WriteLine($"Essa palavra tem {contaVogais(texto.ToLower())} vogais!");

        Console.WriteLine($"Essa palavra tem {contaConsoantes(texto.ToLower())} consoantes!");

        string espelhado = new(espelhaString(texto));
        Console.WriteLine($"Essa palavra ao contrário fica assim: {espelhado}");

        string alternado = new(maiusculaMinuscula(texto));
        Console.WriteLine($"Essa palavra alternada fica assim: {alternado}");

        int contaVogais(string texto)
        {
            int totalVogais = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == 'a' || texto[i] == 'e' || texto[i] == 'i' || texto[i] == 'o' || texto[i] == 'u')
                {
                    totalVogais++;
                }
            }

            return totalVogais;
        }

        int contaConsoantes(string texto)
        {
            int totalConsoantes = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] != 'a' && texto[i] != 'e' && texto[i] != 'i' && texto[i] != 'o' && texto[i] != 'u' && char.IsLetter(texto[i]))
                {
                    totalConsoantes++;
                }
            }

            return totalConsoantes;
        }

        char[] espelhaString(string texto)
        {
            char[] palavraEspelhada = new char[texto.Length];
            int j = texto.Length - 1;

            for (int i = 0; i < texto.Length; i++)
            {
                palavraEspelhada[i] = texto[j];
                j--;
            }

            return palavraEspelhada;
        }

        char[] maiusculaMinuscula(string texto)
        {
            char[] palavraAlternada = new char[texto.Length];
            char aux;

            for(int i = 0; i < texto.Length; i++)
            {
                if(i % 2 == 0)
                {
                    aux = texto[i];
                    palavraAlternada[i] = char.ToUpper(aux);
                }
                else
                {
                    aux = texto[i];
                    palavraAlternada[i] = char.ToLower(aux);
                }
            }

            return palavraAlternada;
        }
    }
}