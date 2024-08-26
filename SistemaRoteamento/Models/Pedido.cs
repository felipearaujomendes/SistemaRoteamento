namespace SistemaRoteamento.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }  // Ex: fritos, grelhados, saladas, bebidas, sobremesas
    }

}
