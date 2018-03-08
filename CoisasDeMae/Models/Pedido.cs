namespace CoisasDeMae.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Pedido
    {
        public int PedidoID { get; set; }
        public int ProdutoID { get; set; }
        public int UsuarioID { get; set; }
        public Grade? Grade { get; set; }
        public string Data { get; set; }
        public decimal ValorTotal { get; set; }

        public Produto Produto { get; set; }
        public Usuario Usuario { get; set; }
    }
}
