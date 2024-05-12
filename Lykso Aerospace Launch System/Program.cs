using Lykso_Aerospace_Launch_System;
using Lykso_Aerospace_Launch_System.Rockets;

WacCorporalBoosted rocket = new WacCorporalBoosted(new KrpcConnection());

rocket.PrelaunchUnit();
rocket.LaunchUnit();
rocket.AscentUnit();
rocket.OrbitalUnit();
