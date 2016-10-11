using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Rankings : MonoBehaviour {

public void OnRankingsButtonClicked()
    {
        SceneManager.LoadScene("Ranking");
    }
}
