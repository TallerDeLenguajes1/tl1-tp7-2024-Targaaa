
namespace EspacioCalculadora;

public class Calculadora{
    private double dato;
    public double Resultado{
        get => dato;
        }
    public void sumar(double termino){
        dato+=termino;
    }
    public void restar(double termino){
        dato-=termino;
    }
    public void multiplicar(double termino){
        dato*=termino; 
    }
    public void dividir(double termino){
        dato/=termino;
    }
}
   