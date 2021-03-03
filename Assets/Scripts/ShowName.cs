using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShowName : MonoBehaviour
{
    TextMeshProUGUI text;
    string playerName;
    // Start is called before the first frame update
    void Start()
    {
        playerName = PlayerPrefs.GetString("ThisPlayer", "playerName");
        
        text = GetComponent<TextMeshProUGUI>();

        text.SetText(playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
