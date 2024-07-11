//Nombre: Mateo Montoya Ospina
//Clan: Berners Lee
//Fecha: 11/julio/2024

using System.ComponentModel.Design;
using System.Timers;

string separador = 
@"                                                   
+++++++++++++++++++++++++++++++++++++++++++++++++++++
                                                     ";

//1 actividad

Console.WriteLine("Actividad 1");

List<int> numeros = new List<int>() {1,2,3,4,5,6,7,8,9,10};

//Filtrar y mostrar solo los números pares de la lista numeros.

var numerosPares = numeros.Where(numero=> numero%2 ==0);

Console.WriteLine("1: ");
foreach (var item in numerosPares)
{
    Console.WriteLine(item);
}

//Usando LINQ, calcular la suma de todos los números impares en la lista numeros.
var sumaNumerosImpares = numeros.Where(numero=> numero%2 != 0).Sum();

Console.WriteLine(separador);
Console.WriteLine("2: ");
Console.WriteLine(sumaNumerosImpares);

//Ordenar de manera descendente los números mayores que 5 en la lista numeros.

var numerosOrdenados = numeros.Where(numero=>numero>5).OrderDescending();

Console.WriteLine(separador);
Console.WriteLine("3: ");
foreach (var item in numerosOrdenados)
{
    Console.WriteLine(item);
}

//Contar cuántos números son menores o iguales a 3 en la lista numeros.

var cuentaNumerica = numeros.Where(numero=> numero<= 3).Count();

Console.WriteLine(separador);
Console.WriteLine("4: ");
Console.WriteLine(cuentaNumerica);

//Seleccionar cada número en la lista numeros y multiplicarlo por 2.

var numerosMultiplicados = numeros.Select(numero=>numero*2);

Console.WriteLine(separador);
Console.WriteLine("5: ");
foreach (var item in numerosMultiplicados)
{
    Console.WriteLine(item);
}

//2 actividad

Console.WriteLine(separador);
Console.WriteLine("Actividad 2");

List<string> nombres = new List<string> {"alice", "bob", "charlie","david", "eve"};

//Ordenar los palabra en la lista names alfabéticamente.

var nombresOrganizados = nombres.Order().ToList();

Console.WriteLine(separador);
Console.WriteLine("1: ");
foreach (var item in nombresOrganizados)
{
    Console.WriteLine(item);
}

//Seleccionar los palabra en la lista names que empiezan con la letra 'A'.

var nombresConA = nombres.Where(nombre=>nombre[0]=='a').ToList();

Console.WriteLine(separador);
Console.WriteLine("2: ");
foreach (var item in nombresConA)
{
    Console.WriteLine(item);
}

//Contar cuántos palabra en la lista names tienen más de 5 caracteres.

var cantidadNombresMasDe5Caracteres = nombres.Where(palabra=>palabra.Length>5).Count();

Console.WriteLine(separador);
Console.WriteLine("3: ");
Console.WriteLine(cantidadNombresMasDe5Caracteres);

//Concatenar todos los palabra de la lista names en una sola cadena separada por espacios.
var nombresUnidos = string.Join(" ",nombres);

Console.WriteLine(separador);
Console.WriteLine("4: ");
Console.WriteLine(nombresUnidos);

//Encontrar y mostrar el nombre más largo en la lista names.

var nombreMasLargo = nombres.OrderBy(palabra=>palabra.Length).LastOrDefault();


Console.WriteLine(separador);
Console.WriteLine("5: ");
Console.WriteLine(nombreMasLargo);

//Actividad 3
Console.WriteLine(separador);
Console.WriteLine("Actividad 3");

List<string> palabras = new List<string> () {
    "apple","banana", "cherry","date","elderberry"
};
//Verificar si todas las palabras en la lista palabras tienen más de 3 caracteres.

var masDe3Caracteres = palabras.All(palabra=>palabra.Length>3);

Console.WriteLine(separador);
Console.WriteLine("1: ");
Console.WriteLine(masDe3Caracteres);

//Encontrar y mostrar la primera palabra en la lista palabras que empieza con la letra 'b'.

var primeraPalabraConB =  palabras.Where(palabra=>palabra[0]=='b').Take(1).ToList();

Console.WriteLine(separador);
Console.WriteLine("2: ");
Console.WriteLine(primeraPalabraConB[0]);

//Contar cuántas palabras en la lista palabras contienen la letra 'e'.

var cuentaPalabrasConE = palabras.Where(palabra=>palabra.Contains("e")).Count();

Console.WriteLine(separador);
Console.WriteLine("3: ");
Console.WriteLine(cuentaPalabrasConE);

//Seleccionar todas las palabras en la lista palabras y convertirlas a mayúsculas.

var palabrasAMayusculas = palabras.Select(palabra=>palabra.ToUpper());

Console.WriteLine(separador);
Console.WriteLine("4: ");
foreach (var item in palabrasAMayusculas)
{
    Console.WriteLine(item);
}

//Verificar si alguna palabra en la lista palabras termina con la letra 'y'.

var verificacionTerminaConY = palabras.Any(palabra=>palabra.EndsWith('y'));

Console.WriteLine(separador);
Console.WriteLine("5: ");
Console.WriteLine(verificacionTerminaConY);

//Actividad 4
Console.WriteLine(separador);
Console.WriteLine("Actividad 4");

List<int> data = new List<int> {2,5,1,6,3,8,4,7,9};
List<int> moreData = new List<int> {10,12,15,11,14,13};

//Combinar y ordenar las listas data y moreData de forma ascendente.
var combinedData = data.Concat(moreData).Order();

Console.WriteLine(separador);
Console.WriteLine("1: ");
foreach (var item in combinedData)
{
    Console.WriteLine(item);
}
//Calcular la suma de todos los números pares en la lista data.

var sumaNumerosParesData = data.Where(numero=>numero%2==0).Sum();

Console.WriteLine(separador);
Console.WriteLine("2: ");
Console.WriteLine(sumaNumerosParesData);


//Encontrar el número más grande en la lista data.

var numeroMasGrande = data.Max();


Console.WriteLine(separador);
Console.WriteLine("3: ");
Console.WriteLine(numeroMasGrande);

//Unir las listas data y moreData, eliminando los elementos duplicados.

var listaUnidaNoDuplicada = data.Concat(moreData).Distinct();

Console.WriteLine(separador);
Console.WriteLine("3: ");
foreach (var item in listaUnidaNoDuplicada)
{
    Console.WriteLine(item);
}

//Calcular el promedio de la lista moreData y seleccionar los números en data que son mayores que ese promedio.

double promedioMoreData  = moreData.Average();
var numerosMayoresQuePromedio = data.Where(numero=>Convert.ToDouble(numero)>promedioMoreData).ToList();


Console.WriteLine(separador);
Console.WriteLine("4: ");
foreach (var item in numerosMayoresQuePromedio)
{
    Console.WriteLine(item);
}

//Contar cuántos números en la lista moreData son números primos(te recomiendo crear una función independiente que valide si el número es primo o no lo es, luego esa funciona pasala al método LINQ adecuado).

var listaUnida = data.Concat(moreData).Distinct().ToList();
//usando una funcion

Console.WriteLine("usando funciones");

void PuedeSerPrimo(int a)
{
    if (a<=1)
    {
        Console.WriteLine($"El numero {a} no es primo");
    }
    else 
    {
        bool bandera = false;
        for (int i = 2; i <a ; i++)
        {
            if(a%i == 0)
            {
                bandera = false;
                break;
            }
            else
            {
                bandera = true;
            }
        }
        if (bandera == true || a==2)
        {Console.WriteLine($"El numero {a} es primo");
            
        }
        else
        {
            Console.WriteLine($"El numero {a} no es primo");
        }
    }
}

foreach (var item in listaUnida)
{
    PuedeSerPrimo(item);
}
Console.WriteLine(separador);
Console.WriteLine("Usando LINQ");

foreach (var item in listaUnida)
{
        if (item<=1)
    {
        Console.WriteLine($"El numero {item} no es primo");
    }
    else 
    {
        bool esPrimo = Enumerable.Range(2,item -2).All(i=>item%i !=0);
        if (esPrimo == true || item==2)
        {Console.WriteLine($"El numero {item} es primo");
            
        }
        else
        {
            Console.WriteLine($"El numero {item} no es primo");
        }
    }
}



