namespace Factory_Method_Pattern.Product
{
    public abstract class CartaoCredito
    {
        public abstract string TipoCartao { get; set; }

        public abstract int LimiteCredito { get; set; }

        public abstract int CobrancaAnual { get; set; }

        
    }
}