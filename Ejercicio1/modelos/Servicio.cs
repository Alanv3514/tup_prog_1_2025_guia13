using System;

public class Servicio
{
    private int[] expedientes;
    private int[] DNIs;
    private double[] montos;
    private int contador;

    public Servicio()
    {
        expedientes = new int[100];
        DNIs = new int[100];
        montos = new double[100];
        contador = 0;
    }

    public void RegistrarExpediente(int expediente, int dni, double monto)
    {
        if (contador < 100)
        {
            expedientes[contador] = expediente;
            DNIs[contador] = dni;
            montos[contador] = monto;
            contador++;
        }
    }

    public void VerExpediente(int idx, out int nro, out double monto)
    {
        if (idx >= 0 && idx < contador)
        {
            nro = expedientes[idx];
            monto = montos[idx];
        }
        else
        {
            nro = -1;
            monto = 0;
        }
    }

    public void OrdenarExpedientes()// usamos selection sort
    {
        for (int i = 0; i < contador - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < contador; j++)
            {
                if (expedientes[j] < expedientes[minIndex])
                {
                    minIndex = j;
                }
            }
            // Intercambiar el expediente en minIndex con el expediente en i
            int tempExpediente = expedientes[minIndex];
            expedientes[minIndex] = expedientes[i];
            expedientes[i] = tempExpediente;

            // Intercambiar el DNI y el monto correspondiente
            int tempDNI = DNIs[minIndex];
            DNIs[minIndex] = DNIs[i];
            DNIs[i] = tempDNI;

            double tempMonto = montos[minIndex];
            montos[minIndex] = montos[i];
            montos[i] = tempMonto;
        }
    }


    public double CalcularMontoPromedio()
    {
        double suma = 0;
        double res = 0;
        for (int i = 0; i < contador; i++)
        {
            suma += montos[i];
        }

        if (contador > 0)
        {
            res= suma / contador;
        }
        else
        {
            res= 0;
        }
        return res;
    }

    public int[] MayoresAlPromedio(out int cantidad)
    {
        double promedio = CalcularMontoPromedio();
        int[] mayores = new int[contador];
        int count = 0;

        for (int i = 0; i < contador; i++)
        {
            if (montos[i] > promedio)
            {
                mayores[count] = expedientes[i];
                count++;
            }
        }
        cantidad = count;
        int[] resultado = new int[count];
        for (int i = 0; i < count; i++)
        {
            resultado[i] = mayores[i];
        }

        return resultado;
    }


    public int VerContador()
    {
        return contador;
    }

    public int[] VerExpedientesPorDNI(int dni, out int cantidad)
    {
        int[] resultados = new int[contador];
        int count = 0;

        for (int i = 0; i < contador; i++)
        {
            if (DNIs[i] == dni)
            {
                resultados[count] = expedientes[i];
                count++;
            }
        }

        cantidad = count;

        int[] resultadoFinal = new int[count];
        for (int i = 0; i < count; i++)
        {
            resultadoFinal[i] = resultados[i];
        }

        return resultadoFinal;
    }


    public int VerExpedientePorNumero(int numero)
    {
        for (int i = 0; i < contador; i++)
        {
            if (expedientes[i] == numero)
            {
                return i;
            }
        }
        return -1;
    }
}
