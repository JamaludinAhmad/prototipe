using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class SignMove : MonoBehaviour
{
    public float speed;

    private void Update() {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
