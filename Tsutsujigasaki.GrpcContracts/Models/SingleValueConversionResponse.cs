using System.Runtime.Serialization;
using HappyTravel.Money.Models;

namespace Tsutsujigasaki.GrpcContracts.Models;

[DataContract]
public class SingleValueConversionResponse
{
    [DataMember(Order = 1)]
    public MoneyAmount Result { get; set; }
}