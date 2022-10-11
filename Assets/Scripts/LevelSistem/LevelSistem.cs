using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class LevelSistem : MonoBehaviour
{
    public Car car;
    public SignSpawner signSpawner;
    public GroundSpawner groundSpawner;

    private void Update() {
        if(car.jarakTempuh > 300){
            signSpawner.maxSign = 12;
        }
        else if(car.jarakTempuh > 250){
            signSpawner.maxSign = 9;
        }
        else if(car.jarakTempuh > 100){
            signSpawner.maxSign = 6;
        }
    }
}
