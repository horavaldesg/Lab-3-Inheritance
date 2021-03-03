using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public static RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
        rect.localScale = new Vector3(1, 1, 1);

    }

    // Update is called once per frame
    void Update()
    {
        if (TakeDamage.newRound)
        {
            rect.localScale = new Vector3(1, 1, 1);

        }
    }
    public static void PlayerHit(float damage)
    {
        rect.localScale = new Vector3(rect.localScale.x - damage, 1, 1);
    }
}
