using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour {

    public void OnRetrybuttonClicked()
    {
        SaveData.Data.CreateNewPlayer(SaveData.Data.Current.Name);
        SceneManager.LoadScene("Main");
    }
}
