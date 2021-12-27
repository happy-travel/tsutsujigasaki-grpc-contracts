using System.Collections.Generic;
using System.Runtime.Serialization;
using HappyTravel.Money.Enums;

namespace Tsutsujigasaki.GrpcContracts.Models;


[DataContract]
public class MultipleValuesConversionRequest
{
    [DataMember(Order = 1)]
    public Currencies SourceCurrency { get; set; }
    
    [DataMember(Order = 2)]
    public Currencies TargetCurrency { get; set; }

    [DataMember(Order = 3)] 
    public List<decimal> Values { get; set; } = new();
}