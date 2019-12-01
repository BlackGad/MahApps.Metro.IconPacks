﻿namespace MahApps.Metro.IconPacks.Converter
{
    public class PackIconWeatherIconsKindToImageConverter : PackIconKindToImageConverterBase
    {
        /// <inheritdoc />
        protected override string GetPathData(object iconKind)
        {
            string data = null;
            if (iconKind is PackIconWeatherIconsKind weatherIconsKind)
            {
                PackIconWeatherIconsDataFactory.DataIndex.Value?.TryGetValue(weatherIconsKind, out data);
            }
            return data;
        }
    }
}