﻿namespace OmniXaml.Typing
{
    using System.Collections.Generic;

    public static class CoreTypes
    {
        private static readonly XamlDirective ItemsField = new XamlDirective("_Items", XamlType.Builder.CreateForBuiltInType(typeof(List<object>)));
        private static readonly XamlDirective ClassField = new XamlDirective("Class");
        private static readonly XamlDirective MarkupExtensionArgumentsField = new XamlDirective("_MarkupExtensionArguments");

        public static XamlDirective Items => ItemsField;
        public static XamlDirective Class => ClassField;
        public static XamlType String => XamlType.Builder.CreateForBuiltInType(typeof(string));
        public static object MarkupExtensionArguments => MarkupExtensionArgumentsField;
    }
}