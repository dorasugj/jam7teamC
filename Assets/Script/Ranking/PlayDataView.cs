using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayDataView : MonoBehaviour {

    [SerializeField]
    private Text rankText;
    [SerializeField]
    private Text nameText;
    [SerializeField]
    private Text timeText;
    [SerializeField]
    private Text diffText;
    [SerializeField]
    private Text pointText;

    public void SetData(int rank, string name, float time, float diff, int point) {
        rankText.text = rank.ToString();
        nameText.text = name;
        timeText.text = time.ToString();
        diffText.text = diff.ToString();
        pointText.text = point.ToString();
    }
}
