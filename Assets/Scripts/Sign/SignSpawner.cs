using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignSpawner : MonoBehaviour
{
    public Car car;
    public Sprite[] signs;
    public SignMove signPref;
    public int waktumin, waktumax;

    public int maxSign;
    private void Start() {
        maxSign = 3;
        waktumin = 4;
        waktumax = 10;
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn(){
        while(!car.IsDead()){
            Debug.Log("spawn");
            int rand = UnityEngine.Random.Range(0, maxSign);
            
            SignMove newSign = Instantiate(signPref, transform.position, Quaternion.identity);
            newSign.gameObject.GetComponent<SpriteRenderer>().sprite = signs[rand];
            newSign.gameObject.SetActive(true);

            if(QuizManager.Instance.actualAnswer == -1){
                QuizManager.Instance.actualAnswer = rand;
                QuizManager.Instance.GenerateJawaban();
            }
            yield return new WaitForSeconds(UnityEngine.Random.Range(waktumin, waktumax));
        }
    }


}
