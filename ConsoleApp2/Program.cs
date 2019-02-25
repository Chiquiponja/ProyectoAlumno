using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Program
    {
        static void Main(string[] args)
        {
            int contador1 = 0;
            int contador2 = 0;
            int contador3 = 0;
            int contador4 = 0;
            int contador5 = 0;
            int contador6 = 0;
            int contador7 = 0;
            int contador8 = 0;
            int contador9 = 0;
            int contador10 = 0;

            Console.WriteLine("Calficaciones de los Alumnos");

            List<Alumno> parts = new List<Alumno>();

            parts.Add(new Alumno() { Nombre = "Ana ", Nota = 7 });
            parts.Add(new Alumno() { Nombre = "Analia", Nota = 8 });
            parts.Add(new Alumno() { Nombre = "Eva", Nota = 2 });
            parts.Add(new Alumno() { Nombre = "Lourdes", Nota = 10 });
            parts.Add(new Alumno() { Nombre = "Carolina", Nota = 9 });
            parts.Add(new Alumno() { Nombre = "Samantha", Nota = 9 });
            parts.Add(new Alumno() { Nombre = "Juliana", Nota = 6 });
            parts.Add(new Alumno() { Nombre = "Cristina", Nota = 7 });
            parts.Add(new Alumno() { Nombre = "Priscila", Nota = 10 });
            parts.Add(new Alumno() { Nombre = "Julieta", Nota = 2 });
            parts.Add(new Alumno() { Nombre = "Soledad", Nota = 4 });
            parts.Add(new Alumno() { Nombre = "Aixa", Nota = 8 });
            parts.Add(new Alumno() { Nombre = "Fany", Nota = 1 });
            parts.Add(new Alumno() { Nombre = "Fatima", Nota = 3 });
            parts.Add(new Alumno() { Nombre = "Susan", Nota = 7 });
            parts.Add(new Alumno() { Nombre = "Yamila", Nota = 9 });
            parts.Add(new Alumno() { Nombre = "Gabriela", Nota = 6 });
            parts.Add(new Alumno() { Nombre = "Solange", Nota = 7 });
            parts.Add(new Alumno() { Nombre = "Britani" , Nota = 10 });
            parts.Add(new Alumno() { Nombre = "Luz", Nota = 4 });
            parts.Add(new Alumno() { Nombre = "Elisa", Nota = 10 });
            parts.Add(new Alumno() { Nombre = "Luciana", Nota = 2 });
            parts.Add(new Alumno() { Nombre = "Patricia", Nota = 7 });
            parts.Add(new Alumno() { Nombre = "Sofia", Nota = 8 });
            parts.Add(new Alumno() { Nombre = "Melina", Nota = 3 });

            parts = parts.OrderBy(x => x.Nombre).ToList();

            foreach (var Part in parts)
            {
                Console.WriteLine("Alumno : " + Part.Nombre + " Nota: " + Part.Nota);
            }
           

            Console.WriteLine("******************");
            Console.WriteLine("*Aprobados       *");
            Console.WriteLine("******************");
            foreach (var Part in parts)
            {
                if (Part.Nota >= 6)
                {
                    Console.WriteLine(Part.Nombre + " Nota: " + Part.Nota);
                    
                }

            }

            Console.WriteLine();
            Console.WriteLine("******************");
            Console.WriteLine("*Desaprobados    *");
            Console.WriteLine("******************");
            foreach (var Part in parts)
            {
                if (Part.Nota < 6)
                {
                    Console.WriteLine( Part.Nombre + " Nota: " + Part.Nota);

                }
            }
            Console.WriteLine("---------------------------------------");


            foreach (var Part in parts)
            {
                switch (Part.Nota)
                {
                    case 1:
                        contador1 = contador1 + 1;
                        break;
                    case 2:
                        contador2 = contador2 + 1;
                        break;
                    case 3:
                        contador3 = contador3 + 1;
                        break;
                    case 4:
                        contador4 = contador4 + 1;
                        break;
                    case 5:
                        contador5 = contador5 + 1;
                        break;
                    case 6:
                        contador6 = contador6 + 1;
                        break;
                    case 7:
                        contador7 = contador7 + 1;
                        break;
                    case 8:
                        contador8 = contador8 + 1;
                        break;
                    case 9:
                        contador9 = contador9 + 1;
                        break;
                    case 10:
                        contador10 = contador10 + 1;
                        break;

                    default:
                        break;

                }
            }


            Console.WriteLine("Alumnos con Nota 1: " + contador1);
            Console.WriteLine("Alumnos con Nota 2: " + contador2);
            Console.WriteLine("Alumnos con Nota 3: " + contador3);
            Console.WriteLine("Alumnos con Nota 4: " + contador4);
            Console.WriteLine("Alumnos con Nota 5: " + contador5);
            Console.WriteLine("Alumnos con Nota 6: " + contador6);
            Console.WriteLine("Alumnos con Nota 7: " + contador7);
            Console.WriteLine("Alumnos con Nota 8: " + contador8);
            Console.WriteLine("Alumnos con Nota 9: " + contador9);
            Console.WriteLine("Alumnos con Nota 10: " + contador10);


            Console.ReadKey();

        }
    }


}
