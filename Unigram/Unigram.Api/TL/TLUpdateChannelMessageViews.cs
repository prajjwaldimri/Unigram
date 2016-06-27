// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLUpdateChannelMessageViews : TLUpdateBase 
	{
		public Int32 Views { get; set; }

		public TLUpdateChannelMessageViews() { }
		public TLUpdateChannelMessageViews(TLBinaryReader from, TLType type = TLType.UpdateChannelMessageViews)
		{
			Read(from, type);
		}

		public override TLType TypeId { get { return TLType.UpdateChannelMessageViews; } }

		public override void Read(TLBinaryReader from, TLType type = TLType.UpdateChannelMessageViews)
		{
			ChannelId = from.ReadInt32();
			Id = from.ReadInt32();
			Views = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x98A12B4B);
			to.Write(ChannelId);
			to.Write(Id);
			to.Write(Views);
		}
	}
}