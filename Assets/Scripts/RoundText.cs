using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RoundText : MonoBehaviour
{
    public static int roundText = 1;
    TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(roundText.ToString());
    }
}
