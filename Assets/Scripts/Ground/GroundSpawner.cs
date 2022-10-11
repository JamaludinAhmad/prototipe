using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public Ground groundRef, prevGround;

    void SpawnGround(){
        Ground newGround = Instantiate(groundRef);

        newGround.gameObject.SetActive(true);
        
        //set pos
        prevGround.SetNextGround(newGround);
    }

    private void OnTriggerExit2D(Collider2D other) {
        Ground ground = other.GetComponent<Ground>();

        if(ground){
            prevGround = ground;

            SpawnGround();
        }
    }
}
