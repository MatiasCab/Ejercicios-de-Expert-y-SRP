using System;
using System.Collections;
using System.Collections.Generic;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca BibliotecaUCU = new Biblioteca();
            LibroId libro1=new LibroId("Design Patterns","Erich Gamma & Others","001-034");
            LibroId libro2=new LibroId("Pro C#","Troelsen","001-035");
            BibliotecaUCU.AlmacenarLibro(libro1,"A","7");
            BibliotecaUCU.AlmacenarLibro(libro2,"B","3");
        }
    }
}
