int edad;

Console.WriteLine("ingrese su edad");
edad = int.Parse(Console.ReadLine());

if (edad < 12)
{
    Console.WriteLine("su edad es de un niño");
}
else if (edad >= 12 && edad < 17)
{
    Console.WriteLine("su edad es de un adolescente");
}
else if (edad >=18 && edad < 59)
{
    Console.WriteLine("su edad es de un adulto");
}
else
{
    Console.WriteLine("su edad es de un adulto mayor");
}
