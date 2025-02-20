//---------- Condicionales ---------- 
int a, b;
Console.Write("Primer Numero:  ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Segundo Numero:  ");
b = Convert.ToInt32(Console.ReadLine());

//(If - else if - else):
if (b > 0)
{
    Console.Write($"Su división es: {a / b}"); }
else if (b < 0)
{
    Console.WriteLine("No puedo dividir entre negativos");
}
else
{
    Console.WriteLine("No se puede dividir entre 0");
}

//(Multiples):
double hora = 14; string dia = "sábado";
if (hora >= 9 && hora <= 17)
{
    Console.WriteLine("Es horario laboral"); }

if (dia.ToLower() == "sábado" || dia.ToLower() == "domingo")
{
    Console.WriteLine("Es fin de semana"); }

//(Anidados):
int edad = 20; bool identificacion = true;
if (edad >= 18)
{
    if (identificacion)
    {
        Console.WriteLine("Puedes ingresar");
    }
    else
    {
        Console.WriteLine("Necesitas identificación"); } }
else
{
    Console.WriteLine("No puedes ingresar"); }

//(Operador Ternario):
int nivel = 1, puntos;
puntos = nivel == 1 ? 10 : 20; //If - Else
puntos = nivel == 1 ? 10 : (puntos = nivel == 2 ? 20 : 30); //If - Else If - Else

//(Switch):
switch (a)
{
    case 1:
        Console.WriteLine("El numero es 1");
        break;
    case 2:
        Console.WriteLine("El numero es 2");
        break;
    case 3:
        Console.WriteLine("El numero es 3");
        break;
    default:
        Console.WriteLine("El  numero es mayor de 3");
        break;
}

//---------- Bucle For ----------
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Iteración {i}"); //(0 ~4)
}

//---------- Bucle Foreach ----------
string[] frutas = { "Manzana", "Banana", "Cereza" };
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

//---------- Bucle While ----------
int contador = 0;
while (contador < 5)
{
    Console.WriteLine($"Contador: {contador}");
    contador++; //Incrementa el contador
}

//---------- Bucle Do While ----------
contador = 0;
do
{
    Console.WriteLine($"Contador: {contador}");
    contador++;
} while (contador < 5);

//---------- Control de Bucles ---------- 
//(Break):
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
    } //Sale del bucle cuando i es 5
    Console.WriteLine(i);
}

//(Continue):
contador = 0;
while (contador < 5)
{
    contador += 1;
    if (contador == 3)
    {
        continue; } //Salta la impresión de 3
    Console.WriteLine(contador); }
