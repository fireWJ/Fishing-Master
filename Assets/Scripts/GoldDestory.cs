﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldDestory : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Gold")
        {
            Destroy(gameObject);
        }
    }
}
