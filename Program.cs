// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string opcoes;
int quantasTrasn;
List<decimal> extratoBanc = new List<decimal>();

do{
  Console.WriteLine("**** Bem vindo BANCO DO ALUNO! ****");
  Console.WriteLine("Digite uma opcão abaixo para continuar:");
  Console.WriteLine("1 - Adicionar Transação");
  Console.WriteLine("2 - Consultar Extrato");
  Console.WriteLine("3 - Sair");
opcoes = Console.ReadLine(); 

    if (opcoes == "1"){                                     
                Console.WriteLine("Quantas transações você deseja fazer?");
            quantasTrasn = int.Parse(Console.ReadLine());
                for(int i = 0; i<quantasTrasn; i++){
            Console.WriteLine("Digite sua " + (i+1)  + " Transação: ");
             extratoBanc.Add(decimal.Parse(Console.ReadLine()));
             Console.WriteLine("Transação Efetuada com Sucesso!");
            }
            }                
    else if (opcoes == "2"){
        Console.WriteLine("CONSULTA EXTRATO");
        Console.WriteLine("Os VALORES ENVIADOS foram:");
            foreach(decimal Transação in extratoBanc){
            Console.WriteLine(Transação);
            };
            decimal saldoTotal = extratoBanc.Sum();
            Console.WriteLine("SALDO TOTAL: R$ " + saldoTotal);
            Console.WriteLine("Pressione ENTER para voltar ao MENU: ");
            Console.ReadLine();
}         
}while (!(opcoes == "3"));
