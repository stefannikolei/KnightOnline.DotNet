// See https://aka.ms/new-console-template for more information

using System.Net;
using KnightOnline.DotNet.Common;
using KnightOnline.DotNet.LoginServer;

Console.WriteLine("Hello, World!");

var server = new KnightOnlineServer<LoginSession>(IPAddress.Loopback, 15100);

server.Start();

Console.ReadKey();

Console.WriteLine("Closing LoginServer");
