﻿using L2dotNET.Network;

namespace L2dotNET.GameService.Network.Serverpackets
{
    class Revive : GameserverPacket
    {
        private readonly int _objId;

        public Revive(int objId)
        {
            _objId = objId;
        }

        public override void Write()
        {
            WriteByte(0x07);
            WriteInt(_objId);
        }
    }
}