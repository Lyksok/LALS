using System.Net;
using KRPC.Client;

namespace Lykso_Aerospace_Launch_System;

public class KrpcConnection : Connection
{
    private static string _connName = "Lykso Aerospace Launch System";
    public KrpcConnection() : base(_connName,IPAddress.Parse("127.0.0.1"))
    {
        Console.WriteLine("New KRPC connection : " + _connName);
    }
}