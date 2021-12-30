using System.Runtime.Serialization;

namespace Tsutsujigasaki.GrpcContracts.Models;

[DataContract]
public class RatesResponse
{
    [DataMember(Order = 1)]
    public decimal Rate { get; set; }
}