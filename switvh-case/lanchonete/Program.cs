//  Coca-cola

//  Pepsi

//  Fanta

//  Monster



Console.WriteLine(@$"

                              
   Informe o refrigerante: 
                          
     Coca-cola            
      Pepsi                
      Fanta                
      Monster              
                           
                           

");

string refrigerante = Console.ReadLine()!.ToLower();

Console.WriteLine($"Gostaria de adicionar gelo?");
string gelo = Console.ReadLine()!.ToLower();


switch (refrigerante)
{
    case "coca-cola":

        break;

    case "pepsi":
        break;

    case "fanta":
        break;

    case "monster":
        break;

    default:
        Console.WriteLine($"Selecione uma das opções acima");


        break;
}
if (gelo == "sim")
{
    Console.WriteLine($"A " + refrigerante + " será com gelo");
}
else
{
    Console.WriteLine($"A bebida é sem gelo adicional");
}



















