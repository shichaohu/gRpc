using Grpc.Net.Client;
using GrpcService;
using System;

namespace GrpcClient
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);
            var reply = await client.SayHelloAsync(
                new HelloRequest { Name = "gRPC Request" });
            Console.WriteLine("Greeter 服务返回数据: " + reply.Message);
            Console.ReadKey();
        }
    }
}
