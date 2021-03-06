﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Stride Shader Mixin Code Generator.
// To generate it yourself, please install Stride.VisualStudio.Package .vsix
// and re-save the associated .sdfx.
// </auto-generated>

using System;
using Stride.Core;
using Stride.Rendering;
using Stride.Graphics;
using Stride.Shaders;
using Stride.Core.Mathematics;
using Buffer = Stride.Graphics.Buffer;

namespace Stride.Rendering.SubsurfaceScattering
{
    internal static partial class ShaderMixins
    {
        internal partial class SubsurfaceScatteringBlurEffect  : IShaderMixinBuilder
        {
            public void Generate(ShaderMixinSource mixin, ShaderMixinContext context)
            {
                mixin.AddMacro("SSSS_FOLLOW_SURFACE", context.GetParam(SubsurfaceScatteringKeys.FollowSurface));
                context.Mixin(mixin, "SubsurfaceScatteringBlurShader", context.GetParam(SubsurfaceScatteringKeys.BlurHorizontally), context.GetParam(SubsurfaceScatteringKeys.KernelSizeJittering), context.GetParam(SubsurfaceScatteringKeys.OrthographicProjection), context.GetParam(SubsurfaceScatteringKeys.MaxMaterialCount), context.GetParam(SubsurfaceScatteringKeys.KernelLength), context.GetParam(SubsurfaceScatteringKeys.RenderMode));
            }

            [ModuleInitializer]
            internal static void __Initialize__()

            {
                ShaderMixinManager.Register("SubsurfaceScatteringBlurEffect", new SubsurfaceScatteringBlurEffect());
            }
        }
    }
}
