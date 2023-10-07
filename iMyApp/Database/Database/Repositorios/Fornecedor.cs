namespace Database.Repositorios
{
    internal class Fornecedor
    {
        public int Id { get; internal set; }
        public string Nome { get; internal set; }
        public string Telefone { get; internal set; }
        public string Uf { get; internal set; }
        public string Cidade { get; internal set; }
    }
}