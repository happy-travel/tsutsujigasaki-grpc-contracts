using System.Runtime.Serialization;
using HappyTravel.Money.Enums;

namespace Tsutsujigasaki.GrpcContracts.Models;

[DataContract]
public class RatesRequest
{
    [DataMember(Order = 1)]
    public Currencies SourceCurrency { get; set; }
    
    [DataMember(Order = 2)]
    public Currencies TargetCurrency { get; set; }
}