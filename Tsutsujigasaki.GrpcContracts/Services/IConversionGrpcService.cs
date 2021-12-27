using System.ServiceModel;
using System.Threading.Tasks;
using Tsutsujigasaki.GrpcContracts.Models;

namespace Tsutsujigasaki.GrpcContracts.Services;

[ServiceContract(Name = "Conversion")]
public interface IConversionGrpcService
{
    [OperationContract(Name = "Single")]
    Task<SingleValueConversionResponse> ConvertSingle(SingleValueConversionRequest request);
    
    [OperationContract(Name = "Multiple")]
    Task<MultipleValuesConversionResponse> ConvertMultiple(MultipleValuesConversionRequest request);
}