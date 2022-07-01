using System.ServiceModel;
using System.Threading.Tasks;
using HappyTravel.Money.Enums;
using Tsutsujigasaki.GrpcContracts.Models;

namespace Tsutsujigasaki.GrpcContracts.Services;

[ServiceContract(Name = "Rates")]
public interface IRatesGrpcService
{
    [OperationContract(Name = "GetRate")]
    Task<RatesResponse> GetRate(RatesRequest request);

    [OperationContract(Name = "GetRates")]
    Task<MultipleRatesResponse> GetRates(MultipleRatesRequest request);
}