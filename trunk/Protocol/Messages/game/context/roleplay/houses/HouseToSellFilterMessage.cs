// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'HouseToSellFilterMessage.xml' the '27/06/2012 15:55:03'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class HouseToSellFilterMessage : NetworkMessage
	{
		public const uint Id = 6137;
		public override uint MessageId
		{
			get
			{
				return 6137;
			}
		}
		
		public int areaId;
		public sbyte atLeastNbRoom;
		public sbyte atLeastNbChest;
		public sbyte skillRequested;
		public int maxPrice;
		
		public HouseToSellFilterMessage()
		{
		}
		
		public HouseToSellFilterMessage(int areaId, sbyte atLeastNbRoom, sbyte atLeastNbChest, sbyte skillRequested, int maxPrice)
		{
			this.areaId = areaId;
			this.atLeastNbRoom = atLeastNbRoom;
			this.atLeastNbChest = atLeastNbChest;
			this.skillRequested = skillRequested;
			this.maxPrice = maxPrice;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(areaId);
			writer.WriteSByte(atLeastNbRoom);
			writer.WriteSByte(atLeastNbChest);
			writer.WriteSByte(skillRequested);
			writer.WriteInt(maxPrice);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			areaId = reader.ReadInt();
			atLeastNbRoom = reader.ReadSByte();
			atLeastNbChest = reader.ReadSByte();
			skillRequested = reader.ReadSByte();
			maxPrice = reader.ReadInt();
			if ( maxPrice < 0 )
			{
				throw new Exception("Forbidden value on maxPrice = " + maxPrice + ", it doesn't respect the following condition : maxPrice < 0");
			}
		}
	}
}