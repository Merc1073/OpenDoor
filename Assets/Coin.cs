using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static Player;

public class Coin : MonoBehaviour
{

     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (this.gameObject)
        {
            if (collision.gameObject.tag == "Cube")
            {
                Debug.Log("Coin");
                Destroy(this.gameObject);
                Coins += 1;
                Debug.Log(Coins);
            }
        }
      
    }

}
