// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLSendMessageUploadAudioAction : TLSendMessageActionBase 
	{

		public TLSendMessageUploadAudioAction() { }
		public TLSendMessageUploadAudioAction(TLBinaryReader from, TLType type = TLType.SendMessageUploadAudioAction)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.SendMessageUploadAudioAction; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.SendMessageUploadAudioAction)
		{
			Progress = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0xF351D7AB);
			to.Write(Progress);
		}
	}
}