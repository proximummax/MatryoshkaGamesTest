using UnityEngine;
using UnityEngine.UI;

using CookingPrototype.Controllers;

using TMPro;

namespace CookingPrototype.UI {
	public sealed class StartWindow : MonoBehaviour {

		public TMP_Text GoalText = null;
		public Button StartButton = null;

		bool _isInit = false;

		void Init() {
			var gc = GameplayController.Instance;

			StartButton.onClick.AddListener(gc.StartGame);
		}

		public void Show() {
			if ( !_isInit ) {
				Init();
			}

			var gc = GameplayController.Instance;
			GoalText.text = gc.OrdersTarget.ToString();

			gameObject.SetActive(true);

			gc.PauseGame(true);
		}

		public void Hide() {
			gameObject.SetActive(false);
		}
	}
}