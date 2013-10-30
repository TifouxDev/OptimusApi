


















// Generated on 10/27/2013 07:41:32
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightResumeWithSlavesMessage : GameFightResumeMessage
{

public const uint Id = 6215;
public override uint MessageId
{
    get { return Id; }
}

public Types.GameFightResumeSlaveInfo[] slavesInfo;
        

public GameFightResumeWithSlavesMessage()
{
}

public GameFightResumeWithSlavesMessage(Types.FightDispellableEffectExtendedInformations[] effects, Types.GameActionMark[] marks, short gameTurn, Types.GameFightSpellCooldown[] spellCooldowns, sbyte summonCount, sbyte bombCount, Types.GameFightResumeSlaveInfo[] slavesInfo)
         : base(effects, marks, gameTurn, spellCooldowns, summonCount, bombCount)
        {
            this.slavesInfo = slavesInfo;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)slavesInfo.Length);
            foreach (var entry in slavesInfo)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            slavesInfo = new Types.GameFightResumeSlaveInfo[limit];
            for (int i = 0; i < limit; i++)
            {
                 slavesInfo[i] = new Types.GameFightResumeSlaveInfo();
                 slavesInfo[i].Deserialize(reader);
            }
            

}


}


}