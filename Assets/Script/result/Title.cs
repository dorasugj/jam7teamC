using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

     public void OnTitleButtonClicked()
    {
        SceneManager.LoadScene("Title");
    }
}
