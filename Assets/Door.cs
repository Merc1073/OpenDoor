using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Player player;

    void Update()
    {
        if(player.GetComponent<Player>().Coins == 5)
        {
            Destroy(this.gameObject);
        }
    }
}
