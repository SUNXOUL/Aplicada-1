using System;

class Calculadora
{
    public  double A;
    public  double B;
    public  double Resultado;


    public  Calculadora()
    {
        this.A = 0;
        this.B = 0;
        this.Resultado = 0;
    }

    public void sumar()
    {
        this.Resultado=(this.A+this.B);
    }
    public  void restar()
    {
        this.Resultado=(this.A-this.B);
    }
    public void multiplicar()
    {
        this.Resultado=(this.A*this.B);
    }
    public void Dividir()
    {
        this.Resultado=(this.A/this.B);
    }

}
