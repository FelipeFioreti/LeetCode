/*
 Exercício: Implemente a função MySqrt que recebe um inteiro x e retorna a 
 raiz quadrada arredondada para baixo de x. 

 Restrições:

 0 <= x <= 231 - 1
    
 Exemplo:

 Entrada: 4
 Saída: 2
 Pois 2 * 2 = 4

 Entrada: 8
 Saída: 2
    
 Pois 3 * 3 = 9, resultando em um valor maior que 8.
 Portando a resposta é 2 pois é o valor inteiro anterior a 3. 

*/

int MySqrt(int x)
{

    if (x < 2)
    {
        return x;
    }

    long value = 0;
    int result = 0;

    for (int i = 0; i < x; i++)
    {
        value = i;
        value = value * value;

        if (value > x)
        {
            result = i - 1;
            break;
        }
    }

    return result;
}

Console.WriteLine(MySqrt(2147483647));
