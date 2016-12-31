// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLPageBlockPullquote : TLPageBlockBase, ITLMediaCaption 
	{
		public TLRichTextBase Text { get; set; }
		public TLRichTextBase Caption { get; set; }

		public TLPageBlockPullquote() { }
		public TLPageBlockPullquote(TLBinaryReader from, bool cache = false)
		{
			Read(from, cache);
		}

		public override TLType TypeId { get { return TLType.PageBlockPullquote; } }

		public override void Read(TLBinaryReader from, bool cache = false)
		{
			Text = TLFactory.Read<TLRichTextBase>(from, cache);
			Caption = TLFactory.Read<TLRichTextBase>(from, cache);
			if (cache) ReadFromCache(from);
		}

		public override void Write(TLBinaryWriter to, bool cache = false)
		{
			to.Write(0x4F4456D3);
			to.WriteObject(Text, cache);
			to.WriteObject(Caption, cache);
			if (cache) WriteToCache(to);
		}
	}
}