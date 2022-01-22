using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DeathObject : MonoBehaviour
{
    // Start is called before the first frame update

    private float DeathObjectSpeed;
    private float DeathObjectSpeedMin = 15f;
    private float DeathObjectSpeedMax = 30f;
    

    void Start()
    {
        //some tween for falling
        DeathObjectSpeed = Random.Range(DeathObjectSpeedMin, DeathObjectSpeedMax);

        this.transform.DOMoveY(-10,DeathObjectSpeed);
    }

    private void Update()
    {
        if(this.transform.position.y <= -5f)
        {
            Destroy(this.gameObject);
        }
    }
}
