using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public Text missionTimeText;
    public Image missionTimeTextImage;

    public float timer;
    public float missionTime;

    public float MIN_TIMER;
    public float MAX_TIMER;

    public bool isInit;

    private float missionTimeTmp;

    public float fadeTime;
    public float fadeMaxTime;

    public GameObject effect;

    // Use this for initialization
    void Start () {

        missionTime = Random.Range(MIN_TIMER, MAX_TIMER);
        Debug.Log("missionTime " + missionTime);

        // 有効小数桁数が小数第 1 位になるように切り捨てる
        missionTime = (float)ToRoundDown(missionTime, 1);

        Debug.Log("指定された小数点第１位の時間 missionTime " + missionTime);

        missionTimeText.text = missionTime.ToString();

        missionTimeTmp = missionTime;

    }
	
	// Update is called once per frame
	void Update () {
        if (isInit) {
            timer += Time.deltaTime;

            missionTimeTmp -= Time.deltaTime;
            // 有効小数桁数が小数第 1 位になるように切り捨てる
            missionTimeText.text = missionTimeTmp.ToString("0.0");

            if (missionTimeTmp < missionTime - 1.0f) {
                var mtt_color = missionTimeText.color;
                var mti_color = missionTimeTextImage.color;

                mtt_color.a = Mathf.Lerp(1, 0, fadeTime / fadeMaxTime);
                mti_color.a = mtt_color.a;

                fadeTime += Time.deltaTime;

                missionTimeText.color = mtt_color;
                missionTimeTextImage.color = mti_color;

                effect.SetActive(true);
            }
        }
	}

    public double ToRoundDown(double dValue, int iDigits) {
        double dCoef = System.Math.Pow(10, iDigits);

        return dValue > 0 ? System.Math.Floor(dValue * dCoef) / dCoef :
                            System.Math.Ceiling(dValue * dCoef) / dCoef;
    }

}
