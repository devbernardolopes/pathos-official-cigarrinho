using Inv;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pathos
{
    public static class KindEditorExtensions
    {
        static readonly ConditionalWeakTable<KindEditor, KindEditorProperties> Data = new ConditionalWeakTable<KindEditor, KindEditorProperties>();

        public static bool GetExtradimensional(this KindEditor obj)
        {
            return Data.GetOrCreateValue(obj).Extradimensional;
        }

        public static void SetExtradimensional(this KindEditor obj, bool extradimensional)
        {
            Data.GetOrCreateValue(obj).Extradimensional = extradimensional;

            //return kindData;
        }

        class KindEditorProperties
        {
            public bool Extradimensional
            {
                get;
                //{
                //}
                set;
                //{
                //}
            }
        }
    }
}
