using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SaveName : MonoBehaviour
{
    public TMP_InputField playerHandle;
   
    public string playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SavePlayerName()
    {
        playerName = playerHandle.text;
        PlayerPrefs.SetString("ThisPlayer", playerName);
        
        
    }
    
}
