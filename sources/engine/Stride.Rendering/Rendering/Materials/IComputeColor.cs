// Copyright (c) Stride contributors (https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using Stride.Core.Annotations;
using Stride.Core.Mathematics;

namespace Stride.Rendering.Materials
{
    /// <summary>
    /// Base interface for vector/color based compute color nodes.
    /// </summary>
    [InlineProperty]
    public interface IComputeColor : IComputeNode<Vector4>
    {  
    }
}
