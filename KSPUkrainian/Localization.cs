using KSP.Localization;
using System.Linq;
using TMPro;
using UnityEngine;

namespace KSPUkr
{
    [KSPAddon(KSPAddon.Startup.Instantly, false)]
    public class Localization : MonoBehaviour
    {
        public void Awake()
        {
            if (Application.isPlaying)
            {
                FontLoader fontLoader = FindObjectOfType<FontLoader>();
                TMP_FontAsset fontAsset = fontLoader.LoadedFonts.FirstOrDefault(asset => asset.name.Equals("play"));
                fontLoader.AddMenuSubFont("uk", false, new[] { fontAsset });
                fontLoader.SwitchFontLanguage("uk");

                Localizer.SwitchToLanguage("uk");

            }
        }
    }
}
