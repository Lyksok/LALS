using KRPC.Client.Services.KRPC;
using Lykso_Aerospace_Launch_System;
using Lykso_Aerospace_Launch_System.Prelaunch;
using Lykso_Aerospace_Launch_System.Rockets;

// KrpcConnection conn = new KrpcConnection();
//
// Rocket rocket = new WacCorporalBoosted(conn);
//
// conn.Dispose();

var cd = new Countdown(10);

cd.Start();