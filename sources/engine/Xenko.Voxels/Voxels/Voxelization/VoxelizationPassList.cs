﻿using System;
using System.Collections.Generic;
using System.Text;
using Xenko.Core.Mathematics;

namespace Xenko.Rendering.Voxels
{
    public class VoxelizationPassList
    {
        public List<VoxelizationPass> passes = new List<VoxelizationPass>();
        public IVoxelizationMethod defaultVoxelizationMethod;
        public void AddDirect(IVoxelStorer storer, IVoxelizationMethod method, RenderView view, VoxelAttribute attr, VoxelizationStage stage, bool output, bool shadows)
        {
            bool toAdd = true;
            foreach (VoxelizationPass pass in passes)
            {
                if (pass.storer.Equals(storer) && pass.method.Equals(method) && pass.view.ViewProjection == view.ViewProjection)
                {
                    pass.Add(attr, stage, output, shadows);
                    toAdd = false;
                    break;
                }
            }
            if (toAdd)
            {
                VoxelizationPass pass = new VoxelizationPass
                {
                    storer = storer,
                    method = method,
                    view = view
                };
                pass.Add(attr, stage, output, shadows);
                passes.Add(pass);
            }
        }
        public void Clear()
        {
            passes.Clear();
            defaultVoxelizationMethod = null;
        }
    }
}
