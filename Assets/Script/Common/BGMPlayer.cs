using UnityEngine;
using System.Collections;

public class BGMPlayer : MonoBehaviour {

    [SerializeField]
    private AudioSource source;
    [SerializeField]
    private void Start() {
        source.loop = true;
        source.Play();
        DontDestroyOnLoad(this.gameObject);
    }
}
