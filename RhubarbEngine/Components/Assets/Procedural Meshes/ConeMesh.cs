﻿using g3;
using RhubarbEngine.World;
using RhubarbEngine.World.Asset;
using RhubarbEngine.World.ECS;

namespace RhubarbEngine.Components.Assets.Procedural_Meshes
{

    [Category(new string[] { "Assets/Procedural Meshes" })]
    public class ConeMesh : ProceduralMesh
    {
        private readonly ConeGenerator _generator = new ConeGenerator();

        public Sync<float> BaseRadius;
        public Sync<float> Height;
        public Sync<float> StartAngleDeg;
        public Sync<float> EndAngleDeg;
        public Sync<int> Slices;
        
        public Sync<bool> NoSharedVertices;

        public override void buildSyncObjs(bool newRefIds)
        {
            BaseRadius = new Sync<float>(this, newRefIds);
            BaseRadius.value = 1f;
            Height = new Sync<float>(this, newRefIds);
            Height.value = 1f;
            StartAngleDeg = new Sync<float>(this, newRefIds);
            StartAngleDeg.value = 0.0f;
            EndAngleDeg = new Sync<float>(this, newRefIds);
            EndAngleDeg.value = 360f;
            Slices = new Sync<int>(this, newRefIds);
            Slices.value = 16;

            NoSharedVertices = new Sync<bool>(this, newRefIds);
        }
        public override void onChanged()
        {
            updateMesh();
        }

        private void updateMesh()
        {
            _generator.BaseRadius = BaseRadius.value;
            _generator.Height = Height.value;
            _generator.StartAngleDeg = StartAngleDeg.value;
            _generator.EndAngleDeg = EndAngleDeg.value;
            _generator.Slices = Slices.value;
            _generator.NoSharedVertices = NoSharedVertices.value;
            MeshGenerator newmesh = _generator.Generate();
            RMesh kite = new RMesh(newmesh.MakeDMesh());
            kite.createMeshesBuffers(world.worldManager.engine.renderManager.gd);
            load(kite, true);
        }
        public override void onLoaded()
        {
            updateMesh();
        }
        public ConeMesh(IWorldObject _parent, bool newRefIds = true) : base( _parent, newRefIds)
        {

        }
        public ConeMesh()
        {
        }
    }
}
