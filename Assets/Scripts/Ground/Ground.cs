using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public float speed;
    public Car car;
    public Transform nextPos;

    private void Update() {
        if(!car.IsDead()){
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
    }

    public void SetNextGround(Ground ground){
        if(ground != null){
            ground.transform.position = nextPos.position;
        }
    }
}
