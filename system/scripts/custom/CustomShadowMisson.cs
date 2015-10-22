﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Aura.Channel.Scripting.Scripts;
using Aura.Channel.Network.Sending;

public class CustomShadowMission : GeneralScript
{
    public override void Load()
    {
        Random rnd = new Random();

        //Teleporter Statue in Dunbarton
        SpawnProp(43954, 1, 38409, 38409, MabiMath.ByteToRadian(127), PropWarp(418, 10624, 27379));
	}
}