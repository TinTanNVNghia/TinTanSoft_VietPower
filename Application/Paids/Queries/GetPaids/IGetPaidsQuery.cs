using System.Collections.Generic;

namespace Application.Paids.Queries.GetPaids
{
    public interface IGetPaidsQuery
    {
        List<GetPaidsModel> Execute(int companyId);
    }
}