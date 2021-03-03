using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextScript : Gun
{
    public TextMeshProUGUI text;
    string gunName;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();   
    }

    // Update is called once per frame
    void Update()
    {
        gunName = getName();
        GunName.gunName = gunName;
    }
}
