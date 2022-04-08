using System;
using Factory_Method_Pattern.ConcreteCreator;
using Factory_Method_Pattern.Creator;
using Factory_Method_Pattern.Product;

class program{

    static void Main(string[] args){

        CartaoFactory cartaoFactory = null;

        Console.WriteLine("Digite o tipo de Cartao que gostaria de obter: ");
        string console = Console.ReadLine();

        switch(console.ToLower())
        {
            case "black":
            cartaoFactory = new BlackFactory(50000,0);
            break;

            case "titanium":
            cartaoFactory = new TitaniumFactory(1000000,500);
            break;

            case "platinum":
            cartaoFactory = new PlatinumFactory(5000000,1000);
            break;
            
            default:
            break;
        }

        CartaoCredito cartaoCredito = cartaoFactory.BuscarCartaoCredito();
        Console.WriteLine("\nOs detalhes do seu cartão estão abaixo: \n");
        Console.WriteLine("Tipo do Cartão: {0}\nlimite de Crédito: {1}\nCobrança anual: {2}",
        cartaoCredito.TipoCartao, cartaoCredito.LimiteCredito, cartaoCredito.CobrancaAnual);
        Console.ReadKey();


        
    }
}