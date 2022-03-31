namespace Aula12.Darwin
{

public class Cachorro : Mamifero
{
    public override void emitirsom()
    {
        Console.WriteLine("Au au");
    }
    public  void reagir(string frase)
    {
       if(frase == "Toma comida" || frase == "olá"){
           Console.WriteLine("Abanar e Latir");
       }else{
           Console.WriteLine("Rosnar");
       }
    }
    public void reagir(int hora, int min){
        if(hora < 12){
            Console.WriteLine("Abanar");
        }else if(hora >= 18){
            Console.WriteLine("Ignorar");
        }else{
            Console.WriteLine("Abanar e Latir");
        } 
        }
        public void reagir(bool dono)
        {
            if(dono == true){
                Console.WriteLine("Abanar");
            }else{
                Console.WriteLine("Rosnar");
            }
        }
        public void reagir(int idade, float peso)
        {
            if(idade < 5){
                if(peso < 10){
                    Console.WriteLine("Abanar");
                }else{
                    Console.WriteLine("Latir");
                }
            }
            if (peso < 10){
                Console.WriteLine("Abanar");
            }else{
                Console.WriteLine("Rosnar");
            }
            
                
            
        }
    }
}


 
