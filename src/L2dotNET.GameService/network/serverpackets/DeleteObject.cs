﻿using L2dotNET.Network;

namespace L2dotNET.GameService.Network.Serverpackets
{
    class DeleteObject : GameserverPacket
    {
        private readonly int _id;

        public DeleteObject(int id)
        {
            _id = id;
        }

        public override void Write()
        {
            WriteByte(0x12);
            WriteInt(_id);
            WriteInt(0);
        }
    }
}