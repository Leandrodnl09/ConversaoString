string texto = "Hello, world!";

char[] caracteres = texto.ToCharArray();
int comprimento = caracteres.Length;

for (int i = 0; i < comprimento / 2; i++)
{
    char temp = caracteres[i];
    caracteres[i] = caracteres[comprimento - i - 1];
    caracteres[comprimento - i - 1] = temp;
}

string textoInvertido = new string(caracteres);
Console.WriteLine(textoInvertido);