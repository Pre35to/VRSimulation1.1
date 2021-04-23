using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    TextMeshProUGUI txt;
    // Start is called before the first frame update
    void Start()
    {

    }
    void Awake()
    {
        txt = GetComponent<TextMeshProUGUI>();
    }
    // Update is called once per frame
    void Update()
    {
        // if ()
        //txt.text = Time.time.ToString("#.00");
        txt.text = Time.fixedTime.ToString("#.00");
    }
}
