using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {


    public static void LoadScene(string sceneName) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
}
