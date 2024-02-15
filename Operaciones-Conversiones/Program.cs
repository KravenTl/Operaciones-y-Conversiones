/*De entero a decimal
Console.WriteLine("Ingrese un numero Entero:");
int n1 = Convert.ToInt32(Console.ReadLine());
decimal r1 = Convert.ToDecimal(n1);
Console.WriteLine("Ingrese un numero decimal:");
decimal n2= Convert.ToDecimal(Console.ReadLine());
decimal r2 = n2+r1;
Console.WriteLine("El numero convertido a entero ingresado anterior es: "+r1);
Console.WriteLine("Y ya sumandole un decimal para corroborar " + r2);

/*De decimal a float
decimal d1 = 3.9999999m;
float f1 = (float)d1;
Console.WriteLine("El numero convertido a float es: "+f1);

/*De float a entero
float ft = 3.99f;
int fit= Convert.ToInt32(ft);
Console.WriteLine("El numero convertido a entero es: " + fit);*/

/*De caracter a entero
char c = 'K';
int ic = Convert.ToInt32(c);
Console.WriteLine("El caracter convertido a numero entero es: " +ic);*/

/*De entero a caracter
int en = 75;
char car= Convert.ToChar(en);
Console.WriteLine("El caracter convertido a numero entero es: "+car);*/

/*Suma
int s = 1, s2 = 2;
int resum = s + s2;
Console.WriteLine("La suma de los numeros es: "+resum );

/*Resta de decimales
decimal r1 = 5.6m, r2 = 5.1m;
decimal rr= r1- r2;
Console.WriteLine("EL resultado de la resta es: "+rr);

/*Multiplicacion de floats
float f1 = 1.1f, f2 = 1.1f;
float rm = f1 * f2;
Console.WriteLine("El resultado de la multiplicacion es: " + rm);

/*Division de numeros enteros/*
using System.Timers;

int di = 5, di2 = 2;
int rd = di / di2;
Console.WriteLine("El resultado de la division es: "+rd);

/*El modulo de dos numeros enteros

int md = 13, md2 = 2;
int rd = 13 % md2;
Console.WriteLine("El residuo de la division es: "+rd);

/*Programa que imprime una cadena en mayusculas
string cad = "hola";
string rcad = cad.ToUpper();
Console.WriteLine("La cadena convertida a mayuscuales es: " + rcad);

/*Programa que imprime una cadena en minusculas

string cd = "HOLA";
string rcd= cd.ToLower(); 
Console.WriteLine("La cadena convertida a minusculas: "+rcd);

/*Programa que imprime la cadena de texto al reves

string al = "Hola";
string rl ="";
for(int i= al.Length-1; i>=0; i--)
{
    rl += al [i];
    
}
Console.WriteLine("La cadena de texto al reves es: "+rl);

/*Buscando una palabra en la cadena de texto

Console.WriteLine("Ingrese unas palabras: ");
string bs= Console.ReadLine();
Console.WriteLine("Ingrese la palabra a buscar:");
string pbs = Console.ReadLine();
int posicion = bs.IndexOf(pbs);
if (posicion >= 0)
{
    Console.WriteLine("La palabra '" + pbs + "' se encuentra en la posición " + posicion + " del texto.");
}
else
{
    Console.WriteLine("La palabra '" + pbs + "' no se encuentra en el texto.");
}
*/

/* Programa que cuenta el numero de bocales

Console.Write("Ingrese una palabra: ");
string cue=Console.ReadLine().ToLower();
int conta = 0;
for (int i=0; i<cue.Length; i++)
{
    if (cue[i] == 'a' || cue[i] == 'e' || cue[i] == 'i' || cue[i] == 'o' || cue[i] == 'u')
    {
        conta++;
    }

}
    Console.WriteLine("La palabra '" + cue + "' tiene " + conta + " vocales.");*/

/*El area de un triangulo 

Console.WriteLine("Ingrese la base de el triangulo: ");
decimal basm =Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triangulo: ");
Decimal altm =Convert.ToDecimal(Console.ReadLine());
decimal area = basm * altm / 2;
Console.WriteLine("El area del triangulo es: " + area);

/*Volumen de una esfera
Decimal pi= 3.1416m;
Console.WriteLine("Ingrese el radio de la esfera: ");
decimal ra =Convert.ToDecimal(Console.ReadLine());
decimal vol=4/3*pi*(ra*ra*ra);
Console.WriteLine("El volumen de la esfera es: "+vol);

/*Distancia entre dos puntos
Console.WriteLine("Ingrese las coordenadas del primer punto, primero para x luego para y : ");
double p1x=Convert.ToDouble(Console.ReadLine());
double p1y= Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Ingrese las coordenadas del segundo punto, primero para x luego para y : ");
double p2x = Convert.ToDouble(Console.ReadLine());
double p2y = Convert.ToDouble(Console.ReadLine());
double dista = Math.Sqrt(Math.Pow(p1x - p2x, 2) + Math.Pow (p1y-p2y,2));
Console.WriteLine("La distancia que hay entre los puntos es: "+dista);

/*Calcular grados Fahrenheit a partir de grados Celsius

Console.WriteLine("Ingrese la temperatura en grados Celsius: ");
double cels= Convert.ToDouble(Console.ReadLine());
double fah = (9.0 / 5.0) * cels + 32; 
Console.WriteLine("La temperatura en grados Fahrenheit es: " + fah);

/*Calcular la temperatura en grados Celsius a partir de grados Faherenheit*/

Console.WriteLine("Ingrese la temperatura en grados Fahrenheit: ");
double fa = Convert.ToDouble(Console.ReadLine());
double celi =  (fa - 32)/1.8;
Console.WriteLine("La temperatura en grados Celsius es: commit and push      " + celi);

