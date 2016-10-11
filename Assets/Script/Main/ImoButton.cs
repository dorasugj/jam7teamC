using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ImoButton : MonoBehaviour {

    public Timer timer;

    public Button yakuButton;
    public Button yameruButton;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnYakuButton() {
        yakuButton.interactable = false;
        yameruButton.interactable = true;

        //timer.timerInitialize();
        timer.isInit = true;
    }

    public void OnYameruButton() {
        yameruButton.interactable = false;
        timer.isInit = false;

        PlayerPrefs.SetFloat("MissionTime", timer.missionTime);

        //// 有効小数桁数が小数第 1 位になるように切り捨てる
        var elapsedTime = (float)timer.ToRoundDown(timer.timer, 1);
        Debug.Log("経過した小数第1位の時間 Timer " + elapsedTime);

        var diff = Mathf.Abs(timer.missionTime - elapsedTime);
        Debug.Log(diff);
        var p = Mathf.FloorToInt(diff * 100);
        var result = (int)(100 - p);

        if(result < 0) result = 0;

        Debug.Log("Result " + result);
        PlayerPrefs.SetInt("result", result);

        SaveData.Data.SetPlayerScore(timer.missionTime, diff, result);

        SceneManager.LoadScene("Result");
    }

}
