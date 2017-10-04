using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CmdObjectManager.Mem
{
    internal static class Manager
    {
        private enum ObjTypes : byte
        {
            OT_NONE = 0,
            OT_ITEM = 1,
            OT_CONTAINER = 2,
            OT_UNIT = 3,
            OT_PLAYER = 4,
            OT_GAMEOBJ = 5,
            OT_DYNOBJ = 6,
            OT_CORPSE = 7,
        }

        static uint objectManager = 0x00B41414;
        static uint firstObjPtr = 0xac;
        static uint nextObjPtr = 0x3c;
        static uint objType = 0x14;
        static uint descriptorOffset = 0x8;

        static internal void getObjects()
        {
            uint curObj = BmWrapper.mem.ReadUInt(BmWrapper.mem.ReadUInt(objectManager) + firstObjPtr);
            uint nextObj = curObj;

            while (curObj != 0 && (curObj & 1) == 0)
            {
                uint curObjType = BmWrapper.mem.ReadByte(curObj + objType);
                Console.WriteLine("Found a object of type " + Enum.GetName(typeof(ObjTypes), curObjType) + " at 0x" + curObj.ToString("X8"));
                switch (curObjType)
                {
                    case (byte)ObjTypes.OT_CONTAINER:
                        // Do something
                        break;

                    case (byte)ObjTypes.OT_PLAYER:
                        // Do something
                        break;

                    case (byte)ObjTypes.OT_UNIT:
                        // Do something
                        break;

                    case (byte)ObjTypes.OT_GAMEOBJ:
                        // Do something
                        break;

                    case (byte)ObjTypes.OT_CORPSE:
                        // Do something
                        break;
                }

                nextObj = BmWrapper.mem.ReadUInt(curObj + nextObjPtr);
                if (nextObj == curObj)
                {
                    break;
                }
                else
                {
                    curObj = nextObj;
                }
            }
        }
    }
}
