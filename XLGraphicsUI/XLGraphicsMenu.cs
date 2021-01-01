using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace XLGraphicsUI
{
	public class XLGraphicsMenu : UIsingleton<XLGraphicsMenu>
	{
		//public GameObject tabPanel;
		public GameObject main;
		public GameObject basicContent;
		public GameObject presetsContent;
		public GameObject cameraContent;
		public GameObject presetList;
		public GameObject presetsListContent;
		public GameObject editPresetPanel;
		public GameObject confirmDeletePanel;
		public TMP_InputField renamePresetInputField;
		//public Button renamePresetButton;
		public Button savePresetButton;
		public Button newPresetButton;
		public Button confirmDeleteButton;
		public Button cancelDeleteButton;
		public EventSystem eventSystem;

		// overlay images
		public GameObject imgContainer;
		public GameObject imgNameListContent;
	}
}
