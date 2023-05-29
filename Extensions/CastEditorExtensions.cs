using Inv;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pathos
{
    public static class CastEditorExtensions
    {
        static readonly ConditionalWeakTable<CastEditor, CastEditorMethods> Data = new ConditionalWeakTable<CastEditor, CastEditorMethods>();

        public static bool GetExtradimensional(this Kind obj)
        {
            return Data.GetOrCreateValue(obj).Extradimensional;
        }

        public static void SetExtradimensional(this Kind obj, bool extradimensional)
        {
            Data.GetOrCreateValue(obj).Extradimensional = extradimensional;

            //return kindData;
        }

        class CastEditorMethods
        {
            public CastEditor FilterReplicated()
            {
                Cast record = base.Record;
                if (record.AssetFilter == null)
                {
                    AssetFilter assetFilter2 = (record.AssetFilter = new AssetFilter());
                }

                return this;
            }

        }
    }
}
