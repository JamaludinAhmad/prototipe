using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    #region SINGLETON

    public static QuizManager Instance;

    private void Awake() {
        if(Instance == null){
            Instance = this;
        }
    }

    #endregion

    public String[] AllAnswers;
    public int[] indexAnswer;
    public int actualAnswer;

    public Transform QuizPanel;
    //untuk mengganti text button sesuai Answer;
    private void Start() {
        
    }
    public void GenerateJawaban(){
        QuizPanel.gameObject.SetActive(true);
        // nilai awal
        indexAnswer = new int[3];
        for(int i = 0; i < indexAnswer.Length; i++){
            indexAnswer[i] = -1;
        }
        
        //buat jawaban yang benar disalah satu tiga button secara acak
        indexAnswer[UnityEngine.Random.Range(0,2)] = actualAnswer;

        //generate jawaban di button untuk yang salah
        for(int i = 0; i < 3; i++){
            Transform button = QuizPanel.GetChild(i);
            
            if(indexAnswer[i] != -1){
                button.GetChild(0).GetComponent<Text>().text = AllAnswers[indexAnswer[i]];
                continue;
            }

            indexAnswer[i] = UnityEngine.Random.Range(0,AllAnswers.Length - 1);
            button.GetChild(0).GetComponent<Text>().text = AllAnswers[indexAnswer[i]];
        }
    }

    public void SetAnswer(int ans){
        actualAnswer = ans;
    }

    public void Button(int idx){
        if(actualAnswer == indexAnswer[idx]){
            Debug.Log("Jawaban Anda Benar");
            actualAnswer = -1;
        }
        else{
            Debug.Log("Jawaban anda salah");
            actualAnswer = -1;
        }

        QuizPanel.gameObject.SetActive(false);

    }
}
