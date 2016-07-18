﻿using L2dotNET.Network;

namespace L2dotNET.GameService.Network.Serverpackets
{
    public class MagicSkillCanceld : GameserverPacket
    {
        private readonly int _id;

        public MagicSkillCanceld(int id)
        {
            _id = id;
        }

        public override void Write()
        {
            WriteByte(0x49);
            WriteInt(_id);
        }
    }
}