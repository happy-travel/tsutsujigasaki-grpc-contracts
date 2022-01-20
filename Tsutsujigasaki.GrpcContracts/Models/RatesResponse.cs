using System.Runtime.Serialization;
using HappyTravel.GrpcResultContract;

namespace Tsutsujigasaki.GrpcContracts.Models;

[DataContract]
public class RatesResponse
{
    [DataMember(Order = 1)]
    public GrpcResult<decimal, string> Rate { get; set; }
}