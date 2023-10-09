namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
