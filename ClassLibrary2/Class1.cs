using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        private int a;
        public int c;
        protected int d;
        public int VariablePrueba
        {
            set;
            get;
        }
        public void SetValorA(int valor)
        {
            a = valor;
        }
        public void Mimetodo()
        {
            a = 7; // Podemos acceder a las variables privadas desde la misma clase.
        }
    }
    public class Class2:Class1
    {
        private int b;
        public void MiMetodo2()
        {
            b = 4;
            //a = 7; // No podemos acceder a la variable private desde fuera de la clase, aunque sea heredada.
            c = 9;
            d = 5;
            SetValorA(100); // Podemos acceder a las variables privadas con setters y getters.
        }

    }
    public class Class3
    {
        private int a = 0;
        public virtual void OtroMetodo()
        {
            a = 3; // Si accedemos a este metodo desde la clase 4, el codigo pasa por aqui.
        }
    }

    public class Class4 :Class3, ISumador
    {
        private int b;
        public override void OtroMetodo()
        {
            b = 4;
        }
        
       public void metodo()
        {

        }
        public void metodo(int a, String b)
        {

        }
        public void metodo(String a, int b)
        {

        }

        // Polimorfismo significa que podemos tener varios metodos con el mismo nombre siempre que no coincidan 
        // el numero, tipos y orden de sus argumentos.


        public int Sumar(int a, int b)
        {
            return a + b;
        }

        
               
    }
    public interface ISumador
    {
        int Sumar(int a, int b);
    }
}
