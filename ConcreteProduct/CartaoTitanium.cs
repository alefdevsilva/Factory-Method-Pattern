using Factory_Method_Pattern.Product;

namespace Factory_Method_Pattern.ConcreteProduct
{
    public class CartaoTitanium : CartaoCredito
    {
                 private readonly string _tipoCartao;
        private int _limiteCredito;

        private int _cobrancaAnual;

            public CartaoTitanium(int limiteCredito, int cobrancaAnual)
            {
                    this._tipoCartao = "CartaoTitanium";
                    this._limiteCredito = limiteCredito;
                    this._cobrancaAnual = cobrancaAnual;
                    
            }

        public override string TipoCartao {
            get{ return _tipoCartao;}
        }
        public override int LimiteCredito {
            get{return _limiteCredito;}
            set{_limiteCredito = value;}
        }
        public override int CobrancaAnual {
            get{ return _cobrancaAnual;}
            set{_cobrancaAnual = value;}
        }
    }
}