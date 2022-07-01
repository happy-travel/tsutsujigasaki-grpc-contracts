using System.Collections.Generic;
using System.Runtime.Serialization;
using HappyTravel.Money.Enums;

namespace Tsutsujigasaki.GrpcContracts.Models;

[DataContract]
public class MultipleRatesRequest
{
    [DataMember(Order = 1)]
    public Currencies SourceCurrency { get; set; }

    [DataMember(Order = 2)]
    public List<Currencies> TargetCurrencies { get; set; } = new();
}