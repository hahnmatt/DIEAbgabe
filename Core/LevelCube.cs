using System;
using System.Diagnostics;
using Fusee.Math.Core;

namespace Fusee.Tutorial.Core
{
    public class LevelCube
    {
        public String name;
        public float3 albedo;
        public float3 pos;
        public float3 rot;
        public float3 pivot;
        public int state;

        public LevelCube(float3 _pos, int _state) 
        {
            Random rnd = new Random();

           
            pos = _pos;
            rot = float3.Zero;
            pivot = float3.Zero;
            state = _state;
            name = "Test";
            albedo = new float3(0.25f*state, 0.25f*state, 0.25f*state);
            Debug.WriteLine(state.ToString());
        }

        public float3 GetPos()
        {
            return this.pos;
        }
    }


}