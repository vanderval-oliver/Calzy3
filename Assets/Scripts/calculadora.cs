using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class calculadora : MonoBehaviour {

    public Text resultado;
    public Text lblTempo;
    public Text operacion;
    private string textoimprimir;
    string valor1;
    string valor2;
    string operacionActual;
    double rta;

    public void BorrarC()
    {

        resultado.text = "";
        lblTempo.text = "";
        operacion.text = "";
    }

    public void sumas()
    {
        if(resultado.text != "")
        {
            operacion.text = "+";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
        
    }
    public void resta()
    {
        if (resultado.text != "")
        {
            operacion.text = "-";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
    }
    public void multiplicacion()
    {
        if (resultado.text != "")
        {
            operacion.text = "*";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
    }
    public void division()
    {
        if (resultado.text != "")
        {
            operacion.text = "/";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
    }
    public void potenciaX()
    {
        if (resultado.text != "")
        {
            operacion.text = "pox";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
    }
    public void potencia2()
    {
        if (resultado.text != "")
        {
            operacion.text = "po2";
            lblTempo.text = resultado.text;
            resultado.text = resultado.text + "^2";
        }

    }
    public void bin()
    {
        if (resultado.text != "")
        {
            operacion.text = "bin";
            lblTempo.text = resultado.text;
            resultado.text = "A Bin(" + resultado.text + ")";
        }

    }
    public void dec()
    {
        if (resultado.text != "")
        {
            bool esBinario = true;
            int digito;
            int aux = int.Parse(resultado.text);

            while (aux != 0)
            {
                digito = aux % 10;
                if (digito != 0 && digito != 1)
                {
                    esBinario = false;
                }
                aux = aux / 10;
            }
            if (esBinario)
            {
                operacion.text = "dec";
                lblTempo.text = resultado.text;
                resultado.text = "A Dec(" + resultado.text + ")";
            }
            else
            {
                resultado.text = "El numero no es binario";
            }

        }

    }
    public void raiz()
    {
        if (resultado.text != "")
        {
            operacion.text = "raiz";
            lblTempo.text = resultado.text;
            resultado.text = "√" + resultado.text;
        }

    }
    public void sen()
    {
        if (resultado.text != "")
        {
            operacion.text = "sen";
            lblTempo.text = resultado.text;
            resultado.text = "sen(" + resultado.text + ")";
        }
    }
    public void cos()
    {
        if (resultado.text != "")
        {
            operacion.text = "cos";
            lblTempo.text = resultado.text;
            resultado.text = "cos(" + resultado.text + ")";
        }
    }
    public void tan()
    {
        if (resultado.text != "")
        {
            operacion.text = "tan";
            lblTempo.text = resultado.text;
            resultado.text = "tan(" + resultado.text + ")";
        }
    }
    public void log()
    {
        if (resultado.text != "")
        {
            operacion.text = "log";
            lblTempo.text = resultado.text;
            resultado.text = "log(" + resultado.text + ")";
        }
    }
    public void mod()
    {
        if (resultado.text != "")
        {
            operacion.text = "mod";
            lblTempo.text = resultado.text;
            textoimprimir = "";
            resultado.text = textoimprimir;
        }
    }

    public void igual()
    {
        if (resultado.text != "")
        {
            valor2 = resultado.text;
            valor1 = lblTempo.text;
            operacionActual = operacion.text;
            resultado.text = operaciones(valor1, valor2, operacionActual);
            
        }
    }

    public string operaciones(string n1, string n2, string opeMath)
    {
        string respuesta = "";
        switch (opeMath)
        {
            case "+":
                respuesta = (double.Parse(n1) + double.Parse(n2)).ToString();
                break;
            case "-":
                respuesta = (double.Parse(n1) - double.Parse(n2)).ToString();
                break;
            case "*":
                respuesta = (double.Parse(n1) * double.Parse(n2)).ToString();
                break;
            case "/":
                if (!n2.Equals("0"))
                {
                    respuesta = (double.Parse(n1) / double.Parse(n2)).ToString();
                } else
                {
                    respuesta = "La divicion por 0 no es posible";
                }
                
                break;
            case "raiz":
                respuesta = (System.Math.Sqrt(double.Parse(n1))).ToString();
                break;
            case "po2":
                respuesta = (System.Math.Pow(double.Parse(n1), 2)).ToString();
                break;
            case "pox":
                respuesta = (System.Math.Pow(double.Parse(n1), double.Parse(n2))).ToString();
                break;
            case "mod":
                respuesta = (double.Parse(n1) % double.Parse(n2)).ToString();
                break;
            case "bin":
                int numeroDecimal = int.Parse(n1);
                int exp, digito;
                double binario;
                exp = 0;
                binario = 0;
                while (numeroDecimal != 0)
                {
                    digito = numeroDecimal % 2;
                    binario = binario + digito * System.Math.Pow(10, exp);
                    exp++;
                    numeroDecimal = numeroDecimal / 2;
                }

                respuesta = binario.ToString();
                break;
            case "dec":
                int dec=0;
                int exponente = 0;
                int numero = int.Parse(n1);
                while (numero != 0)
                    {
                        digito = numero % 10;
                        dec = dec + digito * (int)System.Math.Pow(2, exponente);
                        exponente++;
                        numero = numero / 10;
                    }
                respuesta = dec.ToString();
                break;
            case "sen":
                respuesta = (System.Math.Sin(double.Parse(n1))).ToString();
                break;
            case "cos":
                respuesta = (System.Math.Cos(double.Parse(n1))).ToString();
                break;
            case "tan":
                respuesta = (System.Math.Tan(double.Parse(n1))).ToString();
                break;
            case "log":
                respuesta = (System.Math.Log10(double.Parse(n1))).ToString();
                break;

        }
        return respuesta;
    }
}
