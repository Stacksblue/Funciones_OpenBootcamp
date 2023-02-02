

//int resultado = CalcularCuadrado(2);
//Console.WriteLine(resultado);

///*Main*/
//CalcularAprobado(1);
//CalcularAprobado(5);
//CalcularAprobado(9);


////Scope, contexto
//int i = 0;
//Console.WriteLine("i desde Main : " + i);
//int a = EntendiendoScope(3, i);

//funciones anónimas: (input-parameters) => expression 
int[] numbers = {2,3,4,5};
var squaredNumbers = numbers.Select(x => x * x);
Console.WriteLine(string.Join(" ", squaredNumbers));


/*End Main*/

/*Definiciones de las funciones*/
int EntendiendoScope(int n, int a)
{
    //Console.WriteLine(n * n);
    //int i = 1;
    a = a + 1;
    Console.WriteLine("i desde función: " + a);
    return a;
    //codigo
}

void CalcularAprobado(int a)
{
    if (a < 5)
    {
        Console.WriteLine("Has suspedido :c");
    }
    else if (a == 5)
    {
        Console.WriteLine("Has pasado raspado");
    }
}

//Funciones anónimas
