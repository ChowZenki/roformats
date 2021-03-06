﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ROFormats
{
    public class Palette
    {
        public struct Color
        {
            public byte R, G, B, A;

            public Color(byte r, byte g, byte b, byte a)
            {
                R = r;
                G = g;
                B = b;
                A = a;
            }
        }

        private Color[] m_colors;
        public Color[] Colors
        {
            get { return m_colors; }
            set { m_colors = value; }
        }

        public Palette()
        {
            m_colors = new Color[256];
        }

        public void Read(System.IO.BinaryReader br)
        {
            for (int i = 0; i < 256; i++)
            {
                byte r = br.ReadByte();
                byte g = br.ReadByte();
                byte b = br.ReadByte();

                br.ReadByte();

                m_colors[i] = new Color(r, g, b, 0);
            }
        }
    }
}
