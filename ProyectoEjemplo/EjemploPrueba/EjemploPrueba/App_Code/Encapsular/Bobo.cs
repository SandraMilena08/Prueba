using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Bobo
/// </summary>
public class Bobo
{
    private string nombre;
    private int edad;
    private string apellido;
    private int numCelular;
    private string direccion;



    public string Nombre { get => nombre; set => nombre = value; }
    public int Edad { get => edad; set => edad = value; }
    public string Apellido { get => apellido; set => apellido = value; }
    public int NumCelular { get => numCelular; set => numCelular = value; }
    public string Direccion { get => direccion; set => direccion = value; }
}