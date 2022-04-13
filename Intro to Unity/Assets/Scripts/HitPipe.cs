using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPipe : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("something hits pipe");
        GameManager gm = GameObject.FindObjectOfType<GameManager>();
        gm.BirdDies();
    }
}
