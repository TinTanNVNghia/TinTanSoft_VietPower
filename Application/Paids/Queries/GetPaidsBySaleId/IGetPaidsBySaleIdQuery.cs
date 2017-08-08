using System.Collections.Generic;

namespace Application.Paids.Queries.GetPaidsBySaleId
{
    public interface IGetPaidsBySaleIdQuery
    {
        List<GetPaidsBySaleIdModel> Execute(int saleId);
    }
}