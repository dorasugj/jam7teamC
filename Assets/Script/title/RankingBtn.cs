using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class RankingBtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnButtonClk()
    {
        Debug.Log("load scene");
        SceneManager.LoadScene("Ranking");
    }
}
