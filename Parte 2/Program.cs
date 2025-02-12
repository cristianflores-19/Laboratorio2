int num1, num2, suma, resta, div, mult;
Console.WriteLine("digite el primer numero");
num1 = int.Parse(Console.ReadLine());
Console.WriteLine("digite el segundo numero");
num2 = int.Parse(Console.ReadLine());

suma = num1 + num2;
resta = num1 - num2;
div = num1 / num2;
mult = num1 * num2;

Console.WriteLine("la suma es: " + suma);
Console.WriteLine("la resta es: " + resta);
Console.WriteLine("la division es: " + div);
Console.WriteLine("la multiplicacion es: " + mult);

//Decimales

decimal num1d, num2d, sumad, restad, divd, multd;
Console.WriteLine("digite el primero numero");
num1d= decimal.Parse(Console.ReadLine());
Console.WriteLine("digite el segundo numero");
num2d = decimal.Parse(Console.ReadLine());

sumad = num1d + num2d;
restad = num1d - num2d;
divd = num1d / num2d;
multd = num1d * num2d;
Console.WriteLine("el resultado de la suma con decimales es: " + sumad);
Console.WriteLine("el resultado de la resta en decimales es: " + restad);
Console.WriteLine("el resultado de la division en decimales es: " + divd);
Console.WriteLine("el resultado de la multiplicacion en decimales es: " + multd);

//Float

float num1f, num2f, sumaf, restaf, divf, multf;
Console.WriteLine("digite el primer numero");
num1f = float.Parse(Console.ReadLine());
Console.WriteLine("digite el segundo numero");
num2f = float.Parse(Console.ReadLine());

sumaf = num1f + num2f;
restaf = num1f - num2f;
divf = num1f / num2f;
multf = num1f * num2f;

Console.WriteLine("el resultado de la suma en float es: " + sumaf);
Console.WriteLine("el resultado de la resta en float es: " + restaf);
Console.WriteLine("el resultado de la division en float es: " + divf);
Console.WriteLine("el resultado de la multiplicacion en float es: " + multf);

//int16

Int16 num1i16, num2i16, sumai16, restai16, divi16, multi16;
Console.WriteLine("digite el primer numero");
num1i16 = Int16.Parse(Console.ReadLine());
Console.WriteLine("digite el segundo numero");
num2i16 = Int16.Parse(Console.ReadLine());

sumai16 = (Int16)(num1i16 + num2i16);
restai16 = (Int16)(num1i16 - num2i16);
divi16 = (Int16)(num1i16 / num2i16);
multi16 = (Int16)(num1i16 * num2i16);
Console.WriteLine("el resultado de la suma en int16 es: " + sumai16);
Console.WriteLine("el resultado de la resta en int16 es: " + restai16);
Console.WriteLine("el resultado de la division en int16 es: " + divi16);
Console.WriteLine("el resultado de la multiplicacion en int16 es: " + multi16);

//byte

byte num1b, num2b, sumab, restab, divb, multb;
Console.WriteLine("digite el primer numero");
num1b = byte.Parse(Console.ReadLine());
Console.WriteLine("digite el segundo numero");
num2b = byte.Parse(Console.ReadLine());

sumab = (byte)(num1b + num2b);
restab = (byte)(num1b - num2b);
divb = (byte)(num1b / num2b);
multb = (byte)(num1b * num2b);
Console.WriteLine("el resultado de la suma en byte es: " + sumab);
Console.WriteLine("el resultado de la resta en byte es: " + restab);
Console.WriteLine("el resultado de la division en byte es: " + divb);
Console.WriteLine("el resultado de la multiplicacion en byte es: " + multb);

