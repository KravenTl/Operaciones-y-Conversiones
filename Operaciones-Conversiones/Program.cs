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
Console.WriteLine("El numero convertido a float es: " + fit);*/

/*De caracter a entero
char c = 'K';
int ic = Convert.ToInt32(c);
Console.WriteLine("El caracter convertido a numero entero es: " +ic);*/

/*De entero a caracter*/
int en = 75;
char car= Convert.ToChar(en);
Console.WriteLine("El caracter convertido a numero entero es: "+car);

