using System.Collections.Generic;
using System.Runtime.Serialization;
using HappyTravel.GrpcResultContract;
using HappyTravel.Money.Enums;

namespace Tsutsujigasaki.GrpcContracts.Models;

[DataContract]
public class MultipleRatesResponse
{
    [DataMember(Order = 1)]
    public GrpcResult<Dictionary<Currencies, decimal>, string> Rates { get; set; }
}