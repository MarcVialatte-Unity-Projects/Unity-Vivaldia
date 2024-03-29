﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerInventory>().AddBomb(); //Pour récupérer une bombe
            Destroy(gameObject); //On détruit l'objet
        }
    }
}
