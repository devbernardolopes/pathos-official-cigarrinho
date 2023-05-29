using Inv;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pathos
{
    public static class KindExtensions
    {
        static readonly ConditionalWeakTable<Kind, KindProperties> Data = new ConditionalWeakTable<Kind, KindProperties>();

        public static bool GetExtradimensional(this Kind obj)
        {
            return Data.GetOrCreateValue(obj).Extradimensional;
        }

        public static void SetExtradimensional(this Kind obj, bool extradimensional)
        {
            Data.GetOrCreateValue(obj).Extradimensional = extradimensional;

            //return kindData;
        }

        class KindProperties
        {
            public bool Extradimensional { get; internal set; }
        }
    }
}
