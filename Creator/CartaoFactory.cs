using Factory_Method_Pattern.Product;

namespace Factory_Method_Pattern.Creator
{
    public abstract class CartaoFactory
    {
        public abstract CartaoCredito BuscarCartaoCredito();
    }
}