using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreText : MonoBehaviour
{
    TextMeshProUGUI text;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(score.ToString());
    }
}
