class Categoria{
    public static void Rodar(){
        int idade;
    
        Console.WriteLine("Digite sua idade:");
        idade = int.Parse(Console.ReadLine());

        char categoria = Calcular(idade);
        Console.WriteLine($"Sua categoria é {categoria}");
    }

    public static char Calcular(int idade){
        if(idade >= 5 && idade <=7){
            return 'F';
        }
        else if(idade <= 10){
            return 'E';
        }
        else if(idade <= 13){
            return 'D';
        }
        else if(idade <= 15){
            return 'C';
        }
        else if(idade <= 17){
            return 'B';
        }
        else{
            return 'A';
        }
    }
}
