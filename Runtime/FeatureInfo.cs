using System;
using System.Globalization;
using System.Linq;

namespace TechTalk.SpecFlow
{
    public class FeatureInfo
    {
        public string[] Tags { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public CultureInfo Language { get; private set; }

        public FeatureInfo(CultureInfo language, string title, string description, params string[] tags)
        {
            Language = language;
            Title = title;
            Description = description;
            Tags = tags;
        }
    }
}