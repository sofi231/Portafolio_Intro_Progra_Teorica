using System;

class Cafetera
{
    
    public string Inventario {get; private set;}
    public int Capacidad {get; private set;}
    public int Disponibles {get; private set;}
    public int Servidas {get; private set;}
    
    public Cafetera (string inventario, int capacidad){
        
    Capacidad = capacidad;
    Inventario = inventario;
    Disponibles = 0;
    Servidas = 0;
        
    }
    
    public void hacerCafe(){
        Disponibles = Capacidad;
        Servidas = 0;
    }
    
    public bool tazasServidas(int tazas){
        
        if (tazas <= Disponibles){
            Disponibles -= tazas;
            Servidas += tazas;
            return true;
        }
        else {
            return false;
        }
        
    }
    
    public double obtenerPorcentaje(){
         
        return (double) Disponibles / Capacidad * 100;
    }
    
    public void mostrarEstado(){
        Console.WriteLine("Código de inventario: "+Inventario);
        Console.WriteLine("Capacidad en cantidad de tazas: "+Capacidad);
        Console.WriteLine("Porcentaje de disponibilidad: "+ obtenerPorcentaje());
        Console.WriteLine("Tazas servidas: "+Servidas);
    }
    
    
    
    static void Main() {
        
        Cafetera miCafetera = new Cafetera("200", 10);
        
        miCafetera.hacerCafe();
        miCafetera.tazasServidas(4);
        miCafetera.mostrarEstado();
        
        Console.ReadKey();
    }
}