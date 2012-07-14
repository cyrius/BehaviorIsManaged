// File generated by 'DofusProtocolBuilder.exe v1.0.0.0'
// From 'InteractiveUseRequestMessage.xml' the '27/06/2012 15:55:08'
using System;
using BiM.Core.IO;

namespace BiM.Protocol.Messages
{
	public class InteractiveUseRequestMessage : NetworkMessage
	{
		public const uint Id = 5001;
		public override uint MessageId
		{
			get
			{
				return 5001;
			}
		}
		
		public int elemId;
		public int skillInstanceUid;
		
		public InteractiveUseRequestMessage()
		{
		}
		
		public InteractiveUseRequestMessage(int elemId, int skillInstanceUid)
		{
			this.elemId = elemId;
			this.skillInstanceUid = skillInstanceUid;
		}
		
		public override void Serialize(IDataWriter writer)
		{
			writer.WriteInt(elemId);
			writer.WriteInt(skillInstanceUid);
		}
		
		public override void Deserialize(IDataReader reader)
		{
			elemId = reader.ReadInt();
			if ( elemId < 0 )
			{
				throw new Exception("Forbidden value on elemId = " + elemId + ", it doesn't respect the following condition : elemId < 0");
			}
			skillInstanceUid = reader.ReadInt();
			if ( skillInstanceUid < 0 )
			{
				throw new Exception("Forbidden value on skillInstanceUid = " + skillInstanceUid + ", it doesn't respect the following condition : skillInstanceUid < 0");
			}
		}
	}
}