

// Generated on 04/17/2013 22:29:54
using System;
using System.Collections.Generic;
using System.Linq;
using BiM.Protocol.Types;
using BiM.Core.IO;
using BiM.Core.Network;

namespace BiM.Protocol.Messages
{
    public class GuildFightPlayersHelpersJoinMessage : NetworkMessage
    {
        public const uint Id = 5720;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public double fightId;
        public Types.CharacterMinimalPlusLookInformations playerInfo;
        
        public GuildFightPlayersHelpersJoinMessage()
        {
        }
        
        public GuildFightPlayersHelpersJoinMessage(double fightId, Types.CharacterMinimalPlusLookInformations playerInfo)
        {
            this.fightId = fightId;
            this.playerInfo = playerInfo;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteDouble(fightId);
            playerInfo.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            fightId = reader.ReadDouble();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            playerInfo = new Types.CharacterMinimalPlusLookInformations();
            playerInfo.Deserialize(reader);
        }
        
    }
    
}