using system; 
{
    public class Program
    {
        public static void Main()
        {
            var n = 5;
            String [] Array_letras = new String[n];

            Array_letras [0] = "P";
            Array_letras [1] = "A";
            Array_letras [2] = "U";
            Array_letras [3] = "L";
            Array_letras [4] = "A";
    
            for ( var i = 0; i <Array_letras.Length; i++) 
            {
            var letra = Array_letras[i];
            Console.WriteLine("La letra en la posición " + i + " es " + letra);
            }
    //FASE 2
            List<string> Lista_letras = new List<string>();
            for (int i = 0; i < Array_letras.Length; i++)
                {
                    Lista_letras.Add(Array_letras[i]);
                }
            
            
            for ( var i = 0; i < Lista_letras.Count; i++) 
            {
            string letra = Lista_letras[i];
                switch(letra){

            case "A":
            Console.WriteLine("VOCAL");
            break;
            case "E":
            Console.WriteLine("VOCAL");
            break;
            case "I":
            Console.WriteLine("VOCAL");
            break;
            case "O":
            Console.WriteLine("VOCAL");
            break;
            case "U":
            Console.WriteLine("VOCAL");
            break;
            default:
            Console.WriteLine("CONSONANTE");
            break;
            }
            }
            
    //FASE 3
            var diccionario = new Dictionary <string, int> ();
            diccionario.Add("P", 1);
            diccionario.Add("A", 2);
            diccionario.Add("U", 1);
            diccionario.Add("L", 1);
            
    //FASE 4
    var Lista_letras_apellido = new List <string>();
    
    Lista_letras_apellido.Add("Z");
    Lista_letras_apellido.Add("A");
    Lista_letras_apellido.Add("R");
    Lista_letras_apellido.Add("A");
    Lista_letras_apellido.Add("G");
    Lista_letras_apellido.Add("O");
    Lista_letras_apellido.Add("Z");
    Lista_letras_apellido.Add("A");

    List<string> Lista_letras_nomap = new List<string>();
    Lista_letras_nomap.AddRange(Lista_letras);
    Lista_letras_nomap.Add("");
    Lista_letras_nomap.AddRange(Lista_letras_apellido);
        
    for ( var j = 0; j < Lista_letras_nomap.Count; j++) 
    {
    string letra1 = Lista_letras_nomap[j];
    Console.WriteLine("La letra en la posición " + j + " es " + letra1);
    }
            
        }
    }
}