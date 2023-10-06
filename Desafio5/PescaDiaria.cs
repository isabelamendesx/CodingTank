namespace Aula2;

using System;
using System.Collections.Generic;

public class PescaDiaria
{
    private double kilosPescados;
    private double excessoDiario;

    public PescaDiaria(double kilosPescados)
    {
        this.kilosPescados = kilosPescados;
        this.excessoDiario = VerificaExcesso();
    }

    public double KilosPescados
    {
        get => kilosPescados;
        set => kilosPescados = value;
    }

    public double ExcessoDiario
    {
        get => excessoDiario;
    }
    

    private double VerificaExcesso()
    {
        if (kilosPescados > 50.00)
        {
            return (kilosPescados - 50.00) * 4.00;
        }
        else
        {
            return 0.00;
        }
    }

    public override string ToString()
    {
        return $"- Quilos Pescados: {kilosPescados}\n- Multa por excesso: {excessoDiario:F2}\n";
    } 
    
    
    
}