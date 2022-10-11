using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public bool isDead;
    public bool usedHelm;
    public float speed;
    public float jarakTempuh;

    public bool isBahaya;
    public bool[] jenisbahaya = new bool[3];

    //UI
    public Text jarakTempuhText;
    public GameObject bahayaSign;
    public bool IsDead(){
        return isDead;
    }

    private void Update() {
        if(usedHelm && !isDead){
            jarakTempuh += speed * Time.deltaTime;
            jarakTempuhText.text = string.Format("{0:00}", jarakTempuh) + " meter";
        }

        //cek di jenisbahaya apakah ada yang true, jika ada maka dalam bahaya
        for(int i = 0; i < 3; i++){
            if(jenisbahaya[i] == true){
                isBahaya = true;
                bahayaSign.gameObject.SetActive(true);
            }
        }
    }

}
