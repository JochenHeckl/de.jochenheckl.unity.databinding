﻿namespace JH.DataBinding.Editor
{
    internal enum ComponentPropertyBindingState
    {
        MissingDataSourceAssignment,
        SourceUnbound,
        TargetUnbound,
        Unassignable,
        Complete,
    }

    internal enum ContainerPropertyBindingState
    {
        SourceUnbound,
        TargetUnbound,
        ElementTemplateMissing,
        ElementTemplateIsNotAssignable,
        Complete,
    }

    internal enum VisualElementPropertyBindingState
    {
        RootVisualElementUnboud,
        SourceUnbound,
        TargetElementUnbound,
        TargetPropertyUnbound,
        Unassignable,
        Complete,
    }
}
