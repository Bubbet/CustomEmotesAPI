﻿using R2API.Networking;
using System;
using System.Collections.Generic;
using System.Text;


public static class Register
{
    public static void Init()
    {
        NetworkingAPI.RegisterMessageType<SyncAnimationToServer>();
        NetworkingAPI.RegisterMessageType<SyncAnimationToClients>();
    }
}
