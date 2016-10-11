using UnityEngine;
using System.Collections;
using System.Linq;
public class RankingViewer : MonoBehaviour {

    [SerializeField]
    private GameObject item;
    [SerializeField]
    private int viewItems;
    [SerializeField]
    private Transform viewContent;
    private void Start() {
        var database = SaveData.Data.playDataList;
        var sortData = database.OrderByDescending(data => data.Point).ToArray();
        Debug.Log(database.Count);
        for (int i = 0; i < viewItems && i < database.Count; i++) {
            var obj = Instantiate<GameObject>(item);
            obj.transform.SetParent(viewContent,false);
            obj.transform.localScale = Vector3.one;
            var data = sortData[i];
            obj.GetComponent<PlayDataView>().SetData(i+1, data.Name,data.Time,data.DifferenceTime,data.Point);
        }
    }
}
