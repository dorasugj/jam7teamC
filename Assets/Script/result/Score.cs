using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Sprite[] girlSprites;
    [SerializeField]
    private Image image;
    [SerializeField]
    private Image potato;

    int score = 0;

    // Use this for initialization
    void Start()
    {
        score = SaveData.Data.Current.Point; //数値受け取り
        var rank = Mathf.CeilToInt(score/ 20f);
        rank = Mathf.Clamp(rank, 1, 5);
        image.sprite = girlSprites[rank-1];
        scoreText.text = "Score : "+ score;
        var col = 255f / (5 - rank + 1);
        potato.color = new Color(col,col,col,255f);
    }

}