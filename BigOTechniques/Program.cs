//ejemplo de suma de 3 elementos de un array que sumen 1
//reduciendo la complejidad de O(n^2) a O(n*(n-1)/2) en el peor de los casos
static IEnumerable<(int, int, int)> FindSetsThatSumTo1()
{
    int[] arreglo = { -1, -4, -2, -3, 1, -1, -1, 4, 3, 2, 0, 1, 1, 3, 2, -2 };

    Array.Sort(arreglo);

    var resultados = new HashSet<(int, int, int)>();
    for (int i = 0; i < arreglo.Length - 2; i++)
    {
        int left = i + 1;
        int right = arreglo.Length - 1;
        while (left < right)
        {
            int suma = arreglo[i] + arreglo[left] + arreglo[right];
            if (suma == 1)
            {
                resultados.Add((arreglo[i], arreglo[left], arreglo[right]));
                left++;
                right--;
            }
            else if (suma < 1)
            {
                left++;
            }
            else
            {
                right--;
            }
            if (right - left < 2) break;
        }
    }


    //print results //not part of the algorithm 
    foreach (var resultado in resultados)
    {
        Console.WriteLine($"({resultado.Item1}, {resultado.Item2}, {resultado.Item3})");
    }
    return resultados;
}


//ejemplo de Búsqueda de un Elemento en una Matriz
//reduciendo la complejidad de O(nm) a O(1)
static void FindElementInMatrix()
{
    //Ejemplo de Búsqueda de un Elemento en una Matriz
    int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
    int elementoBuscado = 5;
    bool encontrado = false;

    //primer solución no optimizada
    //Este bucle tiene una complejidad de O(nm)* siendo n el número de filas y m el número de columnas. Una matriz de 10x10 tendría una complejidad de 100 iteraciones.
    //for (int i = 0; i < matriz.GetLength(0); i++)
    //{
    //    for (int j = 0; j < matriz.GetLength(1); j++)
    //    {
    //        if (matriz[i, j] == elementoBuscado)
    //        {
    //            encontrado = true;
    //            break;
    //        }
    //    }
    //    if (encontrado)
    //    {
    //        Console.WriteLine(encontrado.ToString());
    //        break;
    //    }
    //}


    ////segunda solución optimizada
    //// La complejidad de este algoritmo es O(n log n) para la ordenación y O(log n) para la búsqueda binaria.
    //// Ordenar la matriz
    //int[] matrizOrdenada = new int[matriz.Length];
    //int index = 0;
    //for (int i = 0; i < matriz.GetLength(0); i++)
    //{
    //    for (int j = 0; j < matriz.GetLength(1); j++)
    //    {
    //        matrizOrdenada[index] = matriz[i, j];
    //        index++;
    //    }
    //}
    //Array.Sort(matrizOrdenada);

    //// Búsqueda binaria
    //int izquierda = 0;
    //int derecha = matrizOrdenada.Length - 1;
    //while (izquierda <= derecha)
    //{
    //    int medio = (izquierda + derecha) / 2;
    //    if (matrizOrdenada[medio] == elementoBuscado)
    //    {
    //        encontrado = true;
    //        Console.WriteLine(encontrado.ToString());
    //        break;
    //    }
    //    else if (matrizOrdenada[medio] < elementoBuscado)
    //    {
    //        izquierda = medio + 1;
    //    }
    //    else
    //    {
    //        derecha = medio - 1;
    //    }
    //}



    ////tercera solución optimizada
    //// La complejidad de este algoritmo es O(1) 
    var diccionario = matriz.Cast<int>().ToDictionary(x => x);
    encontrado = diccionario.ContainsKey(elementoBuscado);
    Console.WriteLine(encontrado.ToString());
}


//Ejemplo de Cálculo de la Media de un Arreglo
//reduciendo la complejidad de O(n) a O(1)
static void CalculateAverage()
{
    int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int suma = 0;
    double media;

    //no optimizada
    //for (int i = 0; i < arreglo.Length; i++)
    //{
    //    suma += arreglo[i];
    //}
    //media = (double)suma / arreglo.Length;


    media = arreglo.Average();
    Console.WriteLine(media.ToString());
}


//Ejemplo de Cálculo de Suma de Elementos
//reduciendo la complejidad de O(n) a O(1)
static void CalculateSum() 
{
    int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int suma = 0;

    //for (int i = 0; i < arreglo.Length; i++)
    //{
    //    suma += arreglo[i];
    //}

    suma = arreglo.Sum();
    Console.WriteLine(suma.ToString());
}


//Ejemplo de Búsqueda de Elementos Duplicados
//reduciendo la complejidad de O(n^2) a O(n)
static void FindDuplicates()
{
    int[] arreglo = { 1, 2, 3, 2, 4, 5, 6, 2, 7, 8, 9 };
    List<int> duplicados = new List<int>();

    // no optimizada
    //for (int i = 0; i < arreglo.Length; i++)
    //{
    //    for (int j = i + 1; j < arreglo.Length; j++)
    //    {
    //        if (arreglo[i] == arreglo[j] && !duplicados.Contains(arreglo[i]))
    //        {
    //            duplicados.Add(arreglo[i]);
    //        }
    //    }


    HashSet<int> visto = new HashSet<int>();
    foreach (int elemento in arreglo)
    {
        if (!visto.Add(elemento))
        {
            duplicados.Add(elemento);
        }
    }

    //print results //not part of the algorithm
    foreach (var duplicado in duplicados)
    {
        Console.WriteLine(duplicado);
    }
}


//Ejemplo de Búsqueda de un Elemento en un Arreglo
//reduciendo la complejidad de O(n) a O(log n)
static void BinarySearch() 
{
    int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int elementoBuscado = 5;
    bool encontrado = false;

    //no optimizada
    //for (int i = 0; i < arreglo.Length; i++)
    //{
    //    if (arreglo[i] == elementoBuscado)
    //    {
    //        encontrado = true;
    //        break;
    //    }
    //}

    int izquierda = 0;
    int derecha = arreglo.Length - 1;

    while (izquierda <= derecha)
    {
        int medio = (izquierda + derecha) / 2;
        if (arreglo[medio] == elementoBuscado)
        {
            encontrado = true;
            Console.WriteLine("Elemento encontrado");
            break;
        }
        else if (arreglo[medio] < elementoBuscado)
        {
            izquierda = medio + 1;
        }
        else
        {
            derecha = medio - 1;
        }
    }
}


//Ejemplo de Búsqueda de un Elemento en un Arreglo con Dictionary
//reduciendo la complejidad de O(n) a O(1)
static void FindElementWithDictionary()
{
    List<int> lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    int elemento = 5;

    // Complejidad de O(n)
    // foreach (var item in lista)
    // {
    //     if (item == elemento)
    //     {
    //         Console.WriteLine("Elemento encontrado");
    //         return;
    //     }
    // }

    // Complejidad de O(1)
    var diccionario = lista.ToDictionary(x => x);
    if (diccionario.ContainsKey(elemento))
    {
        Console.WriteLine("Elemento encontrado");
    }
}


//Ejemplo de Búsqueda del Elemento más repetido en un Arreglo 
//reduciendo la complejidad de O(n^2) a O(2n). In Big O notation, constants are ignored, so O(2n) simplifies to O(n).
static int FindMostRepeatedNumber()
{
    int[] arreglo = { 1, 2, 3, 2, 4, 5, 6, 2, 7, 8, 9, 2, 2, 3, 6, 6, 6, 5, 4, 3, 3, 8, 3, 5 };
    var frequencyDict = new Dictionary<int, int>();

    foreach (var num in arreglo)
    {
        if (frequencyDict.ContainsKey(num))
        {
            frequencyDict[num]++;
        }
        else
        {
            frequencyDict[num] = 1;
        }
    }

    int mostRepeatedNumber = arreglo[0];
    int maxFrequency = 0;

    foreach (var kvp in frequencyDict)
    {
        if (kvp.Value > maxFrequency || (kvp.Value == maxFrequency && kvp.Key < mostRepeatedNumber))
        {
            mostRepeatedNumber = kvp.Key;
            maxFrequency = kvp.Value;
        }
    }

    //you can replace the second loop to iterate less times with linq.
    //This approach mantains the O(n) time complexity, but actually iterates less times.
    //return frequencyDict
    //.OrderByDescending(kvp => kvp.Value)
    //.ThenBy(kvp => kvp.Key)
    //.First()
    //.Key;

    //or

    //return frequencyDict
    //.Where(kvp => kvp.Value == frequencyDict.Values.Max())
    //.OrderBy(kvp => kvp.Key)
    //.First()
    //.Key;

    Console.WriteLine(mostRepeatedNumber);
    return mostRepeatedNumber;
}


//Ejemplo de encontrar colisiones en coordenadas
//reduciendo la complejidad de O(n^2) a O(n).
static void FindCollisionsInCoordinates()
{
    var posiciones = new (int, int)[] { (1, 2), (2, 3), (1, 2), (3, 4), (2, 3), (2, 4), (2, 2), (2, 3) };

    var colisiones = new HashSet<(int, int)>();
    var posicionesUnicas = new HashSet<(int, int)>();

    foreach (var posicion in posiciones)
    {
        if (!posicionesUnicas.Add(posicion))
        {
            colisiones.Add(posicion);
        }
    }

    //print results //not part of the algorithm
    foreach (var colision in colisiones)
    {
        Console.WriteLine($"({colision.Item1}, {colision.Item2})");
    }   
}
