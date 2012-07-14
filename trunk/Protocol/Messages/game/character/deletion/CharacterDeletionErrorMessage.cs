// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'CharacterDeletionErrorMessage.xml' the '27/06/2012 15:54:58'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class CharacterDeletionErrorMessage : NetworkMessage
	{
		public const uint Id = 166;
		public override uint MessageId
		{
			get
			{
				return 166;
			}
		}
		
		public sbyte reason;
		
		public CharacterDeletionErrorMessage()
		{
		}
		
		public CharacterDeletionErrorMessage(sbyte reason)
		{
			this.reason = reason;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(reason);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			reason = reader.ReadSByte();
			if ( reason < 0 )
			{
				throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
			}
		}
	}
}