using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace explicasao_do_interface.Models
{
    public abstract class EntidadViva
    {
        /*dentro de esta clase generaremos atributos y metodos que seran genericos */

        /*
        Para ser  un poco mas especificos, algo abstracto no tienie una forma exacta asi que prometemos que nuestro clase le dara una forma por si misma.
        Si lo quieres ver con un ejemplo real, piensa en la arcilla y las vacijas de arcilla.
        
        La arcilla seria nuestra clase o elemento abstracto, el cual, prometemos que justo a nuestro molde le dara forma a una pieza de alfareria
        */

        //las clases abstractas permiten crear atributos
        public int PuntosDeVida{get;set;}//la vida de nuestro personaje
        public int Energia; //con esto nuestra personaje podra lanzar hechizos
        
        public string Nombre;// todos nuestros personajes deberian tener un nombre

        //Por regla de abstract, nosotros no podemos crear un objeto abstract, solo podemos heredarlo, asi que el constructor(si se llega a crear), suele usarse para  hacer Base()
        // creare uno (para usarlo en algun momento)
        public EntidadViva(string Nombre){}

        //Una fomra muy clasica de hacer un constructor

        public string getNombre(){
            return Nombre;
        }

    }
}