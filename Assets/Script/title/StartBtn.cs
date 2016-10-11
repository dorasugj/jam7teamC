using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour {
    public InputField inpname;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void OnButtonClk()
    {
        Debug.Log("load scene");
        
        string name = inpname.text;
        if (name.Length == 0)
        {
            name = "Guest";
        }
        SaveData.Data.CreateNewPlayer(name);
        SceneManager.LoadScene("Main");
    }
}
