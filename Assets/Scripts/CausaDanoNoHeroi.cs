using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CausaDanoNoHeroi : MonoBehaviour
{
    public int valorDoDanoAoHeroi;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameControle.instance.DanoDoHeroi(valorDoDanoAoHeroi);
        }
    }
}