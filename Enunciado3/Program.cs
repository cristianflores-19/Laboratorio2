string nombre = "Cristian", contraseña = "Flores";
string n1, n2;
Console.WriteLine("ingrese su nombre");
n1 = Console.ReadLine();
Console.WriteLine("ingrese su contraseña");
n2 = Console.ReadLine();

if (n1 == nombre && n2 == contraseña)
{
    Console.WriteLine("Acceso concedido");
}
else if (n1 == nombre && n2 != contraseña)
{
    Console.WriteLine("Contraseña incorrecta");
}
else
{
    Console.WriteLine("Usuario no registrado");
}
