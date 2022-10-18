namespace tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public Tabuleiro Tab { get; set; }
        public int QtdeMovimentos { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            QtdeMovimentos = 0;
        }

        public void IncrementarQteMovimentos()
        {
            QtdeMovimentos++;
        }
    }
}
