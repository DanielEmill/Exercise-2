perimetro();
convertGrados();
convertUS();

/*1. Hacer un programa que calcule el
perímetro de cualquier polígono regular*/
void perimetro(){
    System.Console.WriteLine("Ingrese el valor del lado:");
    int lado = (int)Convert.ToInt64(Console.ReadLine());
    System.Console.WriteLine("El perimetro es: " + (lado * 5));
}
/*3 Hacer un programa que transforme de
grados a radianes.*/
void convertGrados(){
    System.Console.WriteLine("Ingrese el valor en grados: ");
    double grados = Convert.ToDouble(Console.ReadLine());
    double radian = grados * Math.PI / 180;
    System.Console.WriteLine($"El valor en radianes es: {radian}");
}
/*Hacer un programa que transforme entre
dólares y euros y que también pida el tipo
de cambio del día*/
void convertUS(){
    System.Console.WriteLine("Ingrese el valor en dolar: ");
    double euro = 0.92;
    double USD = Convert.ToDouble(Console.ReadLine());
    double EU = USD * euro;
    System.Console.WriteLine($"El valor de {USD}USD en euro es: {EU}EURO. El valor del euro esta valorado en: {euro}");
}