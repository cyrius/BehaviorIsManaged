// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage.xml' the '27/06/2012 15:55:11'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage : NetworkMessage
	{
		public const uint Id = 6021;
		public override uint MessageId
		{
			get
			{
				return 6021;
			}
		}
		
		public bool allow;
		
		public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage()
		{
		}
		
		public ExchangeMultiCraftSetCrafterCanUseHisRessourcesMessage(bool allow)
		{
			this.allow = allow;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(allow);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			allow = reader.ReadBoolean();
		}
	}
}