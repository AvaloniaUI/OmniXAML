﻿namespace OmniXaml
{
    using System;
    using ObjectAssembler;

    public interface IObjectAssembler
    {
        object Result { get; }
        EventHandler<XamlSetValueEventArgs> XamlSetValueHandler { get; set; }
        InstanceLifeCycleHandler InstanceLifeCycleHandler { get; set; }
        IRuntimeTypeSource TypeSource { get; }

        void Process(Instruction instruction);

        void OverrideInstance(object instance);      
    }
}