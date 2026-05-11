class Media{
    public static void Rodar(){
        int alunos;

        Console.WriteLine("Digite a quantidade de alunos:");
        alunos = int.Parse(Console.ReadLine());

        for (int i = 1; i <= alunos; i++)
        {
            Console.WriteLine("\nAluno " + i);

            Console.WriteLine("Digite a 1ª nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 2ª nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 3ª nota: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite A para média aritmética ou P para ponderada: ");
            char tipo = char.Parse(Console.ReadLine());

            double media = 0;

            Calcular(nota1, nota2, nota3, tipo, ref media);

            Console.WriteLine($"A média das notas desse aluno é: {media}" );

        }
    }

    static void Calcular(double nota1, double nota2, double nota3, char opcao, ref double media){
        if(opcao == 'A'){
            media = (nota1 + nota2 + nota3) / 3;
        }
        else if(opcao == 'P'){
            media = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 10;
        }
        else{
            Console.WriteLine("Opção inválida.");
        }
    }
}