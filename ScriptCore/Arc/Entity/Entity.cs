using System;
using System.Runtime.CompilerServices;

namespace Arc
{
    public class Entity
    {
        protected Vector3 translate;
        protected Vector3 scale;
        protected Vector3 rotation;
        protected float rotationAngle;

        public Entity()
        {
            // Init Transform Variabels
            translate = new Vector3();
            scale = new Vector3(0.5f, 0.5f, 0.0f);
            rotation = new Vector3(0.0f, 0.0f, 1.0f);
            rotationAngle = 0.0f;
        }

        public void SetTransform()
        {
            SetTransform_Native(5);
        }


        // Externs To Be Defined In Engine
        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        extern static void SetTransform_Native(int test);
    }
}



