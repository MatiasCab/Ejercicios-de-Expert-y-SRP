using System;
using System.Collections;
using System.Collections.Generic;

namespace SRP
{
    public class LibroAnterior
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        /*
            Este codigo no cumple con el principio de SRP
            Ya que una clase posee muchas responsabilidades, y si se quisieran agregar
            mas carcateristicas al codigo, como por ejemplo, saber si fue prestado y 
            si se encuentra en la biblioteca, o saber los formatos disponibles, o la cantidad de 
            copias disponibles, etc, se tendria que cambiar la unica clase existiente, por lo que 
            dicha labor seria mas complicada y el codigo mas vulnerable a errores.
        */

        public LibroAnterior(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }

    public class LibroId 
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }

        public LibroId(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }
    }

        public class Biblioteca
        {
        public string SectorBiblioteca { get ; set; }

        public string EstanteBiblioteca { get ; set; }

        public Dictionary<LibroId,List<string>> AlmacenLibros{get; set;}
        
        public Biblioteca()
        {
            this.AlmacenLibros= new Dictionary<LibroId,List<string>>();
        }

        public void AlmacenarLibro(LibroId libro, string sector, string estante)
        {
            List<string> Identificadores= new List<string>();
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
            Identificadores.Add(this.SectorBiblioteca);
            Identificadores.Add(this.EstanteBiblioteca);
            AlmacenLibros.Add(libro,Identificadores);
        }
        }

    
}
