namespace Version
{
    using System;

    public class AttributeVersion : Attribute
    {
        public string Version { get; set; }
        public Type Component { get; set; }
        public string Name { get; set; }
        public AttributeVersion(Type component, string name, string version)
        {
            this.Component = component;
            this.Name = name;
            this.Version = version;
        }

        public enum Type
        {
            Class,
            Struct,
            Iterface,
            Enum,
            Method
        }
    }
}
