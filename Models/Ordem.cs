using System;
using System.Collections.Generic;
using System.Text;

namespace InvestApi.Models;

public class Ordem
{
    public int Id {get; set;}
    public DateTime DataOrdem {get; set;}
    public string tickler {get; set;}
    public int quantidade {get; set;}
    public double valor {get; set;}
}