// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLTopPeerCategoryChannels : TLTopPeerCategoryBase 
	{
		public TLTopPeerCategoryChannels() { }
		public TLTopPeerCategoryChannels(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.TopPeerCategoryChannels; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x161D9628);
		}
	}
}