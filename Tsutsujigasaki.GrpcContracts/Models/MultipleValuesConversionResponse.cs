using System.Collections.Generic;
using System.Runtime.Serialization;
using HappyTravel.GrpcResultContract;
using HappyTravel.Money.Models;

namespace Tsutsujigasaki.GrpcContracts.Models;

[DataContract]
public class MultipleValuesConversionResponse
{
    [DataMember(Order = 1)]
    public GrpcResult<Dictionary<MoneyAmount, MoneyAmount>, string> Result { get; set; }
}