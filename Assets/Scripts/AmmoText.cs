﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoText : TextScript
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.SetText(ammo.ToString());
    }
}
