﻿namespace EventStore.Rags
{
    public struct OptionSource 
    {
        public string Source;
        public string Name;
        public string Value;
        public OptionSource(string source, string name, string value)
        {
            this.Source = source;
            this.Name = name;
            this.Value = value;
        }
    }
}