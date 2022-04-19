/*
    Realizar un programa para manejar una lista de personas, debera permitir
    agregar personas, eliminar personas, ver la cantidad de las personas en la lista
    y ver la información de todas las personas. (Utilice Herencia).
    
    Notas: 
    La clase Persona debe de contar con los siguientes atríbutos:
    -identificacion (generado automaticamente)
    -nombre
    -apellido
    -edad
    
    Pueden existir dos tipos de personas:
    Empleado: debera tener el atríbuto empresa.
    Estudiante: debera tener el atríbuto carrera.   
*/

using EjercicioRepaso;

int opc = 5;
List<Persona> personas = new List<Persona>();

do
{
    menu();
    Console.Write("Digite su opcion: ");
    opc = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");

    switch (opc)
    {
        case 1:
            int aux = 0;
            Console.Write("1.Estudiante - 2.Empleado: ");
            aux = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite el nombre de la persona: ");
            string nombreP = Convert.ToString(Console.ReadLine());
            Console.Write("Digite el apellido de la persona: ");
            string apellidoP = Convert.ToString(Console.ReadLine());
            Console.Write("Digite la edad de la persona: ");
            int edadP = Convert.ToInt32(Console.ReadLine());
            
            if (aux == 1)
            {
                Console.Write("Digite la carrera del estudiante: ");
                string carreraP = Convert.ToString(Console.ReadLine());

                Estudiante Eaux = new Estudiante(nombreP, apellidoP, edadP, carreraP);
                personas.Add(Eaux);
            }
            else
            {
                Console.Write("Digite la empresa donde trabaja el empleado: ");
                string empresaP = Convert.ToString(Console.ReadLine());

                Empleado Emaux = new Empleado(nombreP, apellidoP, edadP, empresaP);
                personas.Add(Emaux);
            }
            
            Console.WriteLine("Persona agregada con éxito!");
            break;
        case 2:
            if (personas.Count > 0)
            {
                Persona pAux = null;
                
                Console.Write("Dui de la persona a eliminar: ");
                int duiAux = Convert.ToInt32(Console.ReadLine());

                foreach (Persona p in personas)
                {
                    if (p.Identificacion == duiAux)
                        pAux = p;
                }

                if (pAux != null)
                {
                    personas.Remove(pAux);
                    Console.WriteLine("Persona eliminada con éxito!");
                }
                else
                {
                    Console.WriteLine("No se encontro la persona en la lista");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacía.");
            }
            break;
        case 3:
            Console.WriteLine($"Personas en la lista: {personas.Count}");
            break;
        case 4:
            if (personas.Count > 0)
            {
                foreach (Persona persona in personas)
                {
                    Console.WriteLine(persona.ToString());
                    Console.WriteLine(" ");
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacía.");
            }
            break;
        case 5:
            Console.WriteLine("Saliendo...");
            break;
        default:
            Console.WriteLine("Opción invalida.");
            break;
    }
    
    Console.WriteLine(" ");
} while (opc != 5);

void menu()
{
    Console.WriteLine("Bienvenid@ al sistema. \n" +
                      "1.Agregar persona. \n" +
                      "2.Eliminar persona. \n" +
                      "3.Cantidad de personas. \n" +
                      "4.Ver personas en la lista. \n" +
                      "5.Salir.");
}