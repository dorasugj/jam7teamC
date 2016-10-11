using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ReturnTitle : MonoBehaviour {

    [SerializeField]
    private Button button;

    private void Start() {
        button.onClick.AddListener(() => SceneManager.LoadScene("Title"));
    }
}
