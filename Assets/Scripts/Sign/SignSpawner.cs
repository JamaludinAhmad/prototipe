using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignSpawner : MonoBehaviour
{
    public Sprite[] signs;
    public SignMove signPref;
    private void Start() {
        InvokeRepeating("Spawn", 0f, 5f);
    }

    void Spawn(){
        Debug.Log("spawn");
        int rand = UnityEngine.Random.Range(0, signs.Length);
        
        SignMove newSign = Instantiate(signPref, transform.position, Quaternion.identity);
        newSign.gameObject.GetComponent<SpriteRenderer>().sprite = signs[rand];
        newSign.gameObject.SetActive(true);

        if(QuizManager.Instance.actualAnswer == -1){
            QuizManager.Instance.actualAnswer = rand;
            QuizManager.Instance.GenerateJawaban();
        }
    }
}
