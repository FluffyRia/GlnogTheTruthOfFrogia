using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace UI.MainMenu {
    public class ButtonController : MonoBehaviour {
        [field:SerializeField] public SceneAsset SceneToLoad {  get; private set; }


        public void LoadScene() {
            SceneManager.LoadScene(SceneToLoad.name);
        }

    }
}