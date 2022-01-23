using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DeathObject : MonoBehaviour
{
    // Start is called before the first frame update

    private float DeathObjectSpeed;
    private float DeathObjectSpeedMin = 5f;
    private float DeathObjectSpeedMax = 15f;
    private float ObjectScaleSpeed = 2f;
    

    void Start()
    {
        //some tween for falling
        DeathObjectSpeed = Random.Range(DeathObjectSpeedMin, DeathObjectSpeedMax);

        Sequence mySequence = DOTween.Sequence();

        mySequence.Append(this.transform.DOMoveY(0.5f,DeathObjectSpeed));

        mySequence.Append(this.transform.DOScale(2f, ObjectScaleSpeed));
    }

    private void Update()
    {
        if(this.transform.position.y <= 0.5f)
        {
            //Destroy(this.gameObject);
        }
    }
}
