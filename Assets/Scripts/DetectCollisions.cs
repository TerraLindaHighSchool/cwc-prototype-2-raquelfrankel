using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

private void OnTriggerEnter(Collider other)
    {
      //removes object if it passes a player in the game
      Destroy(gameObject);
      Destroy(other.gameObject);
    }
}
