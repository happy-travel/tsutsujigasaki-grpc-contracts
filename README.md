# tsutsujigasaki-grpc-contracts
 Tsutsujigasaki Grpc contracts

## How to use
### Add libraries
- protobuf-net.Grpc 
- Grpc.Net.Client
- Tsutsujigasaki.GrpcContracts

### Create channel
```c#
using var channel = GrpcChannel.ForAddress("https://localhost:5001");
```

### Create client for each service
#### Rates service
```c#
var client = channel.CreateGrpcService<IRatesGrpcService>();

var response = await client.GetRate(new RatesRequest
{
    SourceCurrency = Currencies.AED,
    TargetCurrency = Currencies.USD
});

Console.WriteLine(response.Rate);
```

#### Conversion service
```c#
var client = channel.CreateGrpcService<IConversionGrpcService>();

var response = await client.ConvertSingle(new SingleValueConversionRequest
{
    SourceCurrency = Currencies.USD,
    TargetCurrency = Currencies.AED,
    Value = 15
});

Console.WriteLine($"{response.Result.Amount}{response.Result.Currency}");
```