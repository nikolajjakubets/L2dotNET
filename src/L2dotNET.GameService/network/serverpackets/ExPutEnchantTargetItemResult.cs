﻿using L2dotNET.Network;

namespace L2dotNET.GameService.Network.Serverpackets
{
    class ExPutEnchantTargetItemResult : GameserverPacket
    {
        private readonly int _result;

        public ExPutEnchantTargetItemResult(int result = 0)
        {
            _result = result;
        }

        public override void Write()
        {
            WriteByte(0xfe);
            WriteShort(0x81);
            WriteInt(_result);
        }
    }
}