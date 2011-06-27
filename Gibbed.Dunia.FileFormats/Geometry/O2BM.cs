﻿/* Copyright (c) 2011 Rick (rick 'at' gibbed 'dot' us)
 * 
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 * 
 * 1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would
 *    be appreciated but is not required.
 * 
 * 2. Altered source versions must be plainly marked as such, and must not
 *    be misrepresented as being the original software.
 * 
 * 3. This notice may not be removed or altered from any source
 *    distribution.
 */

using System;
using System.Collections.Generic;
using System.IO;
using Gibbed.Helpers;

namespace Gibbed.Dunia.FileFormats.Geometry
{
    public class O2BM : IBlock
    {
        public BlockType Type
        {
            get { return BlockType.O2BM; }
        }

        public List<UnknownData0> Items = new List<UnknownData0>();

        public void Deserialize(IBlock parent, Stream input)
        {
            var count = input.ReadValueU32();

            this.Items.Clear();
            for (uint i = 0; i < count; i++)
            {
                var item = new UnknownData0();
                item.Unknown00 = input.ReadValueF32();
                item.Unknown04 = input.ReadValueF32();
                item.Unknown08 = input.ReadValueF32();
                item.Unknown0C = input.ReadValueF32();
                item.Unknown10 = input.ReadValueF32();
                item.Unknown14 = input.ReadValueF32();
                item.Unknown18 = input.ReadValueF32();
                item.Unknown1C = input.ReadValueF32();
                item.Unknown20 = input.ReadValueF32();
                item.Unknown24 = input.ReadValueF32();
                item.Unknown28 = input.ReadValueF32();
                item.Unknown2C = input.ReadValueF32();
                item.Unknown30 = input.ReadValueF32();
                item.Unknown34 = input.ReadValueF32();
                item.Unknown38 = input.ReadValueF32();
                item.Unknown3C = input.ReadValueF32();
                this.Items.Add(item);
            }
        }

        public void Serialize(IBlock parent, Stream output)
        {
            throw new NotImplementedException();
        }

        public class UnknownData0
        {
            public float Unknown00;
            public float Unknown04;
            public float Unknown08;
            public float Unknown0C;
            public float Unknown10;
            public float Unknown14;
            public float Unknown18;
            public float Unknown1C;
            public float Unknown20;
            public float Unknown24;
            public float Unknown28;
            public float Unknown2C;
            public float Unknown30;
            public float Unknown34;
            public float Unknown38;
            public float Unknown3C;
        }

        public IBlock CreateBlock(BlockType type)
        {
            return null;
        }

        public void AddChild(IBlock child)
        {
            throw new NotSupportedException();
        }

        public IEnumerable<IBlock> GetChildren()
        {
            throw new NotSupportedException();
        }
    }
}
