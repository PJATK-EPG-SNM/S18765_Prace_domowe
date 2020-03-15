using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    public GameObject Player;
    public float time = 2;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == Player)
        {
            Destroy(this.gameObject, time);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == Player)
        { }
    }



}
