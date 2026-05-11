class Progam{
    public static void Main(){
        string entrada = "";
        
        while(entrada != "fim"){
            Categoria.Rodar();
            Media.Rodar();
            
            entrada = Console.ReadLine();
        }
    }
 }
