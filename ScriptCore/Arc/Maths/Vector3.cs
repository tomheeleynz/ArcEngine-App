using System;

namespace Arc 
{
    public class Vector3
    {
        private float m_fx;
        private float m_fy;
        private float m_fz;

        public float x
        {
            get {return m_fx;}
            set {m_fx = value;}
        }
        
        public float y
        {
            get {return m_fy;}
            set {m_fy = value;}
        }
        public float z
        {
            get {return m_fz;}
            set {m_fz = value;}
        }

        public Vector3(float _x = 0.0f, float _y = 0.0f, float _z = 0.0f)
        {
            m_fx = _x;
            m_fy = _y;
            m_fz = _z;
        }
    }
}