//---------- Visualizar informacion ----------
//(Mostrar Texto):
Console.WriteLine("Hola Mundo");
//(Obtener Datos):
Console.Write("Ingresa un texto: ");
string db = Console.ReadLine();

//---------- Asignacion de variables ----------
//(Basicos):
int v1 = 8;
int v2 = 6;
int v3 = 4;
int suma, resta, divi, multi, sobrante;
//(Posterior)
string nombre; int edad;
nombre = "Juan"; edad = 25;
//(Multiple):
int a = 1, b = 2, c = 3;
//(Mismo Valor):
int x, y, z;
x = y = z = 5;

//---------- Tipos de datos ----------
char t1 = 'a';
string t2 = "Texto"; //Cadena de Texto
byte t3 = 255; //Entero (0 ~ 255)
sbyte t4 = -100; //Entero (-128 ~ 127)
short t5 = -32300; //Entero (-32,768 ~ 32,767)
ushort t6 = 30780;//Entero (0 ~ 65,535)
int t7 = 2; //Entero (-2,147,483,648 ~ 2,147,483,647)
uint t8 = 100; //Entero (0 ~ 4,294,967,295)
long t9 = 1007005010L; //Entero (-9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807)
ulong t10 = 854690; //Entero (0 ~ 18,446,744,073,709,551,615)
float t11 = 10 / 4; //Flotante
double t12 = 2.71828; //Decimal (limite de 15 cifras)
decimal t13 = 99.99m; //Decimal (limite de 30 cifras)
bool t14 = true; //Booleano 
string? t15 = null; //Vacio
List<string> t16 = new List<string> { "Ana", "Luis", "Pedro" }; //Lista
int[] t17 = { 1, 2, 3, 4, 5 }; //Array
Dictionary<string, int> t18 = new Dictionary<string, int> { { "Juan", 30 }, { "Ana", 25 } }; //Diccionario


//---------- Concatenacion ----------
//(Numeros):
Console.WriteLine(t1 + " " + t2 + " {0} {1} {2} {3}", t3, t4, t5, t6);
Console.WriteLine($"Los Numeros son {v1}, {v2}, {v3}");
Console.WriteLine("Los Numeros son {0}, {1}, {2}", v1, v2, v3);
//(Texto):
Console.WriteLine(t1 + " de prueba");

//---------- Opreadores ---------- 
x = 5; y = 3;
//(Aritmeticos):
suma = v1 + v2;
resta = v2 - v3;
multi = v1 * v2;
divi = v3 / v1; //Devuelve Enteros
double divi2 = v3 / t3; //Devuelve Decimal
sobrante = v2 % v3; //Muestra el residuo de la division
                    //(Comparacion):
bool igualdad = (x == y);
bool diferente = (x != y);
bool mayor_que = (x > y);
bool menor_que = (x < y);
bool mayor_o_igual = (x >= y);
bool menor_o_igual = (x <= y);
//(Logicos):
bool Y = (x > 2) && (y < 5);
bool O = (x > 10) || (y < 5);
bool No = !(x > 2);
//(Asignacion):
x += 2; //Suma y asigna
x -= 2; //Resta y asigna	
x *= 2; //Multiplica y asigna
x /= 2; //Divide y asigna		
x %= 2; //Módulo y asigna	
        //(Incremento y Decremento):
y++;
y--;
++y;
--y;

//Conversion de datos
int d1 = Convert.ToInt32("2");
short d2 = Convert.ToInt16(32000);
long d3 = Convert.ToInt64("999999");
byte d4 = Convert.ToByte("2");
float d5 = Convert.ToSingle("2");
double d6 = Convert.ToDouble(false);
decimal d7 = Convert.ToDecimal(100);
string d8 = Convert.ToString(12345);
bool d9 = Convert.ToBoolean(1);
Console.WriteLine($"{d1}\n{d2}\n{d3}\n{d4}\n{d5}\n{d6}\n{d7}\n{d8}\n{d9}");
