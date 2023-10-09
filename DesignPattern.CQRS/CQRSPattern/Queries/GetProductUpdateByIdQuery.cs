namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIdQuery
    {
        public GetProductUpdateByIdQuery(int id)
        {
            Id =id;
        }

        public int Id { get; set; }
    }
}
