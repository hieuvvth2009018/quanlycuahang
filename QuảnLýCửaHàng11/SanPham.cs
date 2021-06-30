namespace QuảnLýCửaHàng11
{
    public class SanPham
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return$"Id: {Id}, Name: {Name}, price: {Price}";
        }
    }
}