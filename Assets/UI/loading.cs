using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loading : MonoBehaviour {
    public int e;
    // Use this for initialization
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate
        {
            ClickBtn(this.gameObject);
        });
    }
    // Update is called once per frame
    void Update()
    {

    }
    void ClickBtn(GameObject obj)
    {
        Application.LoadLevel(e); Debug.Log("fuck");
        Debug.Log("ClickBtn");
    }
}
