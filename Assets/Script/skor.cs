using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt ("skor",0);
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text> (). text = PlayerPrefs.GetInt ("skor").ToString();
    }
}