
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinscript : MonoBehaviour 
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        scorescript.coinAmount += 1;
        Destroy(gameObject);
    }
}
