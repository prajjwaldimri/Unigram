﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Api.TL;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Unigram.Selectors
{
    public class StickerSetTemplateSelector : DataTemplateSelector
    {
        public DataTemplate RecentsTemplate { get; set; }
        public DataTemplate ItemTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is TLMessagesStickerSet stickerSet)
            {
                return stickerSet.Set.ShortName.Equals("tg/recentlyUsed") ? RecentsTemplate : ItemTemplate;
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
