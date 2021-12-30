using System.Collections.Generic;
using System.Runtime.Serialization;
using HappyTravel.Money.Models;

namespace Tsutsujigasaki.GrpcContracts.Models;

[DataContract]
public class MultipleValuesConversionResponse
{
    [DataMember(Order = 1)]
    public Dictionary<MoneyAmount, MoneyAmount> Result { get; set; } = new();
}