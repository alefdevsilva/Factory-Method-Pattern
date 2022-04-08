using Factory_Method_Pattern.ConcreteProduct;
using Factory_Method_Pattern.Creator;
using Factory_Method_Pattern.Product;

namespace Factory_Method_Pattern.ConcreteCreator
{
    public class PlatinumFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;

        public PlatinumFactory(int limiteCredito, int cobrancaAnual)
        {
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }
        public override CartaoCredito BuscarCartaoCredito()
        {
            return new CartaoPlatinum(_limiteCredito, _cobrancaAnual);
        }
    }
}