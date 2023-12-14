using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.GetComponent<SupermanController> () != null)
        {
            GameControl.instance.BirdScored();
        }
    }
}
