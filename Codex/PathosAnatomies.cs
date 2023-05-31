using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.Support;

namespace Pathos
{
  public sealed class CodexAnatomies : CodexPage<ManifestAnatomies, AnatomyEditor, Anatomy>
  {
    private CodexAnatomies() { }
#if MASTER_CODEX
    internal CodexAnatomies(Codex Codex)
      : base(Codex.Manifest.Anatomies)
    {
      //var Properties = Codex.Properties;

      Anatomy AddAnatomy(string Name, string AbsenceText) //, Property BypassProperty = null)
      {
        return Register.Add(A =>
        {
          A.Name = Name;
          A.AbsenceText = AbsenceText;
          //A.BypassedByProperty = BypassProperty;
        });
      }

      head = AddAnatomy("head", "NO HEAD");
      mind = AddAnatomy("mind", "MINDLESS");
      eyes = AddAnatomy("eyes", "NO EYES"); //, Properties != null ? Properties.clairvoyance : null);
      ears = AddAnatomy("ears", "NO EARS");
      voice = AddAnatomy("voice", "VOICELESS");
      hands = AddAnatomy("hands", "NO HANDS"); // , Properties != null ? Properties.protoplasmatic_hands : null);
      limbs = AddAnatomy("limbs", "NO LIMBS");
      feet = AddAnatomy("feet", "NO FEET");
      blood = AddAnatomy("blood", "NO BLOOD");
      thermal = AddAnatomy("thermal", "NOT WARM");
      amorphous = AddAnatomy("amorphous", "NOT AMORPHOUS");
      mounted = AddAnatomy("mounted", "NOT MOUNTED");
      //inner_core = AddAnatomy("inner core", "NO INNER CORE");

      Register.mind = mind;
      Register.eyes = eyes;
      Register.ears = ears;
      Register.hands = hands;
      Register.limbs = limbs;
      Register.mounted = mounted;
    }
#endif

    public readonly Anatomy head;
    public readonly Anatomy mind;
    public readonly Anatomy eyes;
    public readonly Anatomy ears;
    public readonly Anatomy hands;
    public readonly Anatomy limbs;
    public readonly Anatomy feet;
    public readonly Anatomy thermal;
    public readonly Anatomy blood;
    public readonly Anatomy mounted;
    public readonly Anatomy amorphous;
    public readonly Anatomy voice;
    //public readonly Anatomy inner_core;
  }
}