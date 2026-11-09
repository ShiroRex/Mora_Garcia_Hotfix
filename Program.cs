using System;

Personaje miPersonaje = new Personaje
{
    Nombre = "Rey_Caribeño",
    Vida = 100,
    Ataque = 45,
    Defensa = 20,
    Nivel = 1
};

Console.WriteLine("=== DATOS ===");
Console.WriteLine($"Nombre:  {miPersonaje.Nombre}");
Console.WriteLine($"Vida:    {miPersonaje.Vida}");
Console.WriteLine($"Ataque:  {miPersonaje.Ataque}");
Console.WriteLine($"Defensa: {miPersonaje.Defensa}");
Console.WriteLine($"Nivel:   {miPersonaje.Nivel}");