namespace OmniXaml.ObjectAssembler
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using Typing;

    public class CurrentLevelWrapper
    {
        private readonly Level level;
        private readonly ValuePipeline pipeline;

        public CurrentLevelWrapper(Level level, ValuePipeline pipeline)
        {
            this.level = level;
            this.pipeline = pipeline;
        }

        public string InstanceName
        {
            get
            {
                var runtimeNameMember = XamlType.RuntimeNamePropertyMember;
                return (string) runtimeNameMember?.GetValue(Instance);            
            }
            set
            {
                var runtimeNameMember = XamlType.RuntimeNamePropertyMember;
                runtimeNameMember?.SetValue(Instance, value, pipeline);
            }
        }

        public MemberBase Member
        {
            get { return level.Member; }
            set { level.Member = value; }
        }

        public bool IsGetObject
        {
            get { return level.IsGetObject; }
            set { level.IsGetObject = value; }
        }

        public ICollection Collection
        {
            get { return level.Collection; }
            set { level.Collection = value; }
        }

        public object Instance
        {
            get { return level.Instance; }
            set { level.Instance = value; }
        }

        public XamlType XamlType
        {
            get { return level.XamlType; }
            set { level.XamlType = value; }
        }

        public Collection<ConstructionArgument> CtorArguments
        {
            get { return level.CtorArguments; }
            set { level.CtorArguments = value; }
        }

        public bool HasInstance => Instance != null;
        public bool IsMarkupExtension => Instance is IMarkupExtension;

        public InstanceProperties InstanceProperties => level.InstanceProperties;
    }
}