﻿using System.Collections.Generic;

namespace FlyweightGame.UI
{
    using System;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;

    public sealed class AssetLoader
    {
        private static readonly AssetLoader instance = new AssetLoader();

        private readonly Dictionary<AssetType, ImageSource> assests;

        private AssetLoader()
        {
            this.assests = new Dictionary<AssetType, ImageSource>();
        }

        public static AssetLoader Instance
        {
            get
            {
                return instance;
            }
        }

        public Image GetImage(AssetType type)
        {
            if (!this.assests.ContainsKey(type))
            {
                this.assests[type] = this.LoadImage(type);
            }
            return new Image()
            {
                Source = this.assests[type]
            };
        }

        private ImageSource LoadImage(AssetType type)
        {
            string path = string.Empty;

            switch (type)
            {
                case AssetType.Reaper:
                    path = AssetPaths.ReaperImage;
                    break;
                default: 
                    throw new ArgumentException("Unsupported asset type.");
            }

            var src = new Uri(path, UriKind.Relative);

            return BitmapFrame.Create(src);
        }
    }
}
