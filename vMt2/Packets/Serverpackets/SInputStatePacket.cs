﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using vMt2.Enums;

namespace vMt2.Packets
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [GamePacketAttribute(ServerPacketHeader.HEADER_GC_INPUT_STATE)]
    class SInputStatePacket : ServerPacket
    {
        public byte State;
       

        public override void Received(VirtualClient virtualClient)
        {
        }

    }
}