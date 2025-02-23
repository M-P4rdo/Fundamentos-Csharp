class Program
{
    //---------- Funciónes ----------
    //(Simples):
    static void saludar()
    {
        Console.WriteLine("¡Hola, bienvenido!"); 
    }

    //(Con Parámetros):
    static void saludar(string nombre)
    {
        Console.WriteLine($"¡Hola, {nombre}!");
    }

    //(Con Retorno):
    static int suma(int a, int b)
    {
        return a + b;
    }

    //(Valores Predeterminados):
    static void presentar(string nombre = "Desconocido")
    {
        Console.WriteLine($"Hola, soy {nombre}.");
    }

    //(Con Params):
    static int sumar_todo(params int[] numeros)
    {
        return numeros.Sum();
    }

    //(Con Ref (Parámetros por Referencia)):
    static void duplicar(ref int numero)
    {
        numero *= 2;
    }

    //(Con Out (Parámetros de Solo Salida)):
    static void obtener(out int numero1, out int numero2)
    {
        numero1 = 10;
        numero2 = 20;
    }

    //(Anidados):
    static void exterior()
    {
        void interior()
        {
            Console.WriteLine("Soy la función interior");
        }
        interior();
    }

    //(Retorna Múltiples Valores):
    static (int, int) calcular(int a, int b)
    {
        int suma = a + b;
        int resta = a - b;
        return (suma, resta);
    }

    //(Devuelve Otras Funciones):
    static Func<int, int, int> operacion(string tipo)
    {
        if (tipo == "suma")
        {
            return (a, b) => a + b;
        }
        else if (tipo == "multiplicacion")
        {
            return (a, b) => a * b;
        }
        return null;
    }

    //(Generadoras - Usando IEnumerable<int>):
    static IEnumerable<int> contador()
    {
        for (int i = 0; i < 3; i++)
        {
            yield return i;
        }
    }

    //(Delegados):
    delegate int Operacion(int a, int b);
    static int ejecutar(int a, int b, Operacion op) => op(a, b); //Como Parametro

    static void Main(string[] args)
    {
        //---------- Llamar las Funciónes ----------
        saludar(); //Simples
        saludar("Carlos"); //Parametro
        Console.WriteLine(suma(5, 3)); //Retorno
        presentar(); //Valor Predeterminado
        presentar("Ana"); //Valor Predeterminado
        Console.WriteLine(sumar_todo(1, 2, 3, 4, 5)); //Params
        int n1 = 5;
        duplicar(ref n1); //Ref
        int n2 = 10, n3 = 12;
        obtener(out n2, out n3); //Out
        exterior(); //Anidado
        var (suma_1, resta_1) = calcular(5, 3); //Devuelve Multiples Valores
        Console.WriteLine(Convert.ToString(suma_1, resta_1));
        var sumar = operacion("suma"); //Devuelve Otra Funcion 
        if (sumar != null)
            Console.WriteLine(sumar(5, 3));
        foreach (var num in contador()) //Generadoras
        {
            Console.WriteLine(num);
        }
        Console.WriteLine(ejecutar(10, 5, (x, y) => x - y)); //Delegado como Parametro
        Func<int, int, int> sm = (x, y) => x + y; //Delegado Como Func
        Console.WriteLine(sm(3, 4)); //Delegado con Func
        Action<string> mensaje = msg => Console.WriteLine(msg); //Delegado Como Action
        mensaje("Hola!"); //Delegado con Action
        Operacion op = suma; //Delegado
        Console.WriteLine(op(3, 4));

        //(Lambda):
        Func<int, int> doble = x => x * 2;

        List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
        List<int> numerosMas10 = numeros.Select(x => x + 10).ToList(); //(Lambda con Select)

        List<int> numeros2 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> numerosPares = numeros2.Where(x => x % 2 == 0).ToList(); //(Lambda con Where)

        Console.WriteLine(string.Join(", ", numerosMas10)); //Lambda con Select
        Console.WriteLine(string.Join(", ", numerosPares)); //Lambda con Where
    }
    
}