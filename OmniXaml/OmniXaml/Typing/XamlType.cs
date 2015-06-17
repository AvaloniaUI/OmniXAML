namespace OmniXaml.Typing
{
    using System;
    using System.Collections;
    using System.Reflection;
    using Glass;

    public class XamlType
    {
        private readonly IXamlTypeRepository typeRepository;

        private XamlType(Type type, IXamlTypeRepository typeRepository)
        {
            Guard.ThrowIfNull(type, nameof(type));
            Guard.ThrowIfNull(typeRepository, nameof(typeRepository));

            this.typeRepository = typeRepository;
            UnderlyingType = type;
            Name = type.Name;
        }      

        private XamlType(string name)
        {
            Name = name;
            IsUnreachable = true;
        }

        public bool IsUnreachable { get; }

        public Type UnderlyingType { get; }

        public string Name { get; set; }

        public XamlType BaseType { get; set; }

        public bool IsCollection
        {
            get
            {
                var typeInfo = UnderlyingType.GetTypeInfo();
                var isCollection = typeof (ICollection).GetTypeInfo().IsAssignableFrom(typeInfo);
                var isEnumerable = typeof(IEnumerable).GetTypeInfo().IsAssignableFrom(typeInfo);

                return isCollection || isEnumerable;
            }
        }

        public bool IsContainer => IsCollection || IsDictionary;

        public bool IsDictionary
        {
            get
            {
                var typeInfo = UnderlyingType.GetTypeInfo();
                var isDictionary = typeof(IDictionary).GetTypeInfo().IsAssignableFrom(typeInfo);
                return isDictionary;
            }
        }

        protected bool Equals(XamlType other)
        {
            return UnderlyingType == other.UnderlyingType;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((XamlType)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((UnderlyingType?.GetHashCode() ?? 0) * 397);
            }
        }

        public XamlMember GetMember(string name)
        {
            return LookupMember(name);
        }

        protected virtual XamlMember LookupMember(string name)
        {
            if (IsUnreachable)
            {
                return XamlMember.Builder.CreateUnreachable(name, this);
            }

            return XamlMember.Builder.Create(name, this, typeRepository);
        }

        public XamlMember GetAttachableMember(string name)
        {
            return XamlMember.Builder.CreateAttached(name, this, typeRepository);
        }

        public override string ToString()
        {
            return "XamlType: " + Name;
        }

        public static class Builder
        {
            public static XamlType CreateUnreachable(XamlTypeName typeName)
            {
                Guard.ThrowIfNull(typeName, nameof(typeName));

                return new XamlType(typeName.Name);
            }

            public static XamlType Create(Type underlyingType, IXamlTypeRepository mother)
            {
                Guard.ThrowIfNull(underlyingType, nameof(mother));

                return new XamlType(underlyingType, mother);
            }

            public static XamlType CreateForBuiltInType(Type type)
            {
                Guard.ThrowIfNull(type, nameof(type));

                return new XamlType(type, new FrameworkBuiltInTypeRepository());
            }
        }

        public bool CanAssignTo(XamlType type)
        {
            var otherUnderlyingType = type.UnderlyingType.GetTypeInfo();
            return otherUnderlyingType.IsAssignableFrom(UnderlyingType.GetTypeInfo());
        } 
    }
}