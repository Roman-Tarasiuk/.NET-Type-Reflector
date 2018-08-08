using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;

namespace NetTypeReflector
{
    internal class ViewHelper
    {
        private class HelperTypeInfo
        {
            public MethodBase MethodBase { get; set; }
            public Int32 Position { get; set; }
            public Int32 Length { get; set; }
        }

        private List<HelperTypeInfo> m_Info = new List<HelperTypeInfo>();

        public void Add(MethodBase mi, Int32 position, Int32 length)
        {
            m_Info.Add(new HelperTypeInfo(){
                MethodBase = mi,
                Position = position,
                Length = length
            });
        }

        public void Clear()
        {
            m_Info.Clear();
        }

        public MethodBase Get(RichTextBox box, Int32 position)
        {
            if (position < 0 || position > box.Text.Length)
            {
                throw new ArgumentException();
            }

            if (m_Info.Count == 0 || position < m_Info[0].Position)
            {
                return null;
            }

            for (var i = 0; i < m_Info.Count; i++)
            {
                if (position >= m_Info[i].Position && position < (m_Info[i].Position + m_Info[i].Length))
                {
                    return m_Info[i].MethodBase;
                }
            }

            return null;
        }
    }
}
