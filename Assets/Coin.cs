using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using static Player;

public class Coin : MonoBehaviour
{

    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        //Debug.Log(player.GetComponent<Player>().Coins);


    }

    private void OnTriggerEnter(Collider collision)
    {
        if (this.gameObject)
        {
            if (collision.gameObject.tag == "Cube")
            {
                Debug.Log("Coin");
                Destroy(this.gameObject);
                player.GetComponent<Player>().Coins += 1;
                Debug.Log(player.GetComponent<Player>().Coins);
            }
        }
      
    }

}
