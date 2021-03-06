﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POGOProtos.Networking.Requests;
using POGOProtos.Networking.Requests.Messages;
using Google.Protobuf;

namespace MandraSoft.PokemonGo.Api.ClientExtensions
{
    static public class Status
    {
        static public Request GetPlayerRequest(this PokemonGoClient client)
        {
            return new Request() { RequestType = RequestType.GetPlayer };
        }
        static public Request GetHatchedEggRequest(this PokemonGoClient client)
        {            
            return new Request() { RequestType = RequestType.GetHatchedEggs };
        }
        static public Request GetCheckAwardedBadgeRequest(this PokemonGoClient client)
        {
            return new Request() { RequestType = RequestType.CheckAwardedBadges };
        }
        static public Request GetDownloadSettingsRequest(this PokemonGoClient client)
        {
            var msg = new DownloadSettingsMessage()
            {
                Hash = "4a2e9bc330dae60e7b74fc85b98868ab4700802e"
            };
            return new Request() { RequestType = RequestType.DownloadSettings, RequestMessage = msg.ToByteString() };
        }
    }
}
