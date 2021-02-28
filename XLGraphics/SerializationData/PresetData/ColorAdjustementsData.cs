using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using XLGraphics.Presets;

namespace XLGraphics.SerializationData.PresetData
{
	public class ColorAdjustementsData
	{
		public bool active;
		public float postExposure;
		public float contrast;
		public SerializableColor colorFilter = Color.white;
		public float colorFilterIntensity;
		public float hueShift;
		public float saturation;

		public static ColorAdjustementsData FromPreset(Preset p) {
			return new ColorAdjustementsData() {
				active = p.colorAdjustments.active,
				postExposure = p.colorAdjustments.postExposure.value,
				contrast = p.colorAdjustments.contrast.value,
				colorFilter = p.colorAdjustmentsData.colorFilter,
				colorFilterIntensity = p.colorAdjustmentsData.colorFilterIntensity,
				hueShift = p.colorAdjustments.hueShift.value,
				saturation = p.colorAdjustments.saturation.value
			};
		}

		public void OverrideValues(Preset p) {
			p.colorAdjustments.active = active;
			p.colorAdjustments.postExposure.value = postExposure;
			p.colorAdjustments.contrast.value = contrast;
			p.colorAdjustments.colorFilter.value = GetFinalColor();
			p.colorAdjustments.hueShift.value = hueShift;
			p.colorAdjustments.saturation.value = saturation;
		}

		public Color GetFinalColor(){
			var intensityMul = (float)Math.Pow(2, colorFilterIntensity);
			return colorFilter.Color * intensityMul;
		}
	}
}
