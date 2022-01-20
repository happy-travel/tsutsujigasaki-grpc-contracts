using System.Runtime.Serialization;
using HappyTravel.GrpcResultContract;
using HappyTravel.Money.Models;

namespace Tsutsujigasaki.GrpcContracts.Models;

[DataContract]
public class SingleValueConversionResponse
{
    [DataMember(Order = 1)]
    public GrpcResult<MoneyAmount, string> Result { get; set; }
}