using System.ServiceModel;
using System.Threading.Tasks;
using Tsutsujigasaki.GrpcContracts.Models;

namespace Tsutsujigasaki.GrpcContracts.Services;

[ServiceContract(Name = "Rates")]
public interface IRatesGrpcService
{
    [OperationContract(Name = "GetRate")]
    Task<RatesResponse> GetRate(RatesRequest request);
}