using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathObjectManager : MonoBehaviour
{
    private float timer;
    public float minTimer = 1f;
    public float maxTimer = 5f;

    private float sizeX;
    private float sizeY;

    public GameObject[] DeathObjects;

    // Start is called before the first frame update
    void Start()
    {
        sizeX = this.GetComponent<Renderer>().bounds.size.x;
        sizeY = this.GetComponent<Renderer>().bounds.size.z;

        Debug.Log("x position " + sizeX + " " + "y size " + sizeY);

        //start timer
        SetTimer();

        Debug.Log(this.GetComponent<Renderer>().bounds.extents.x);

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0 )
        {
            FireDeathObject();

            SetTimer();
        }
    }

    private void SetTimer()
    {
        timer = Random.Range(minTimer, maxTimer);
    }

    private void FireDeathObject()
    {
        //Decide Where Death Object Goes

        Vector3 ObjectPosition = SetObjectPosition();


        //Spawn death object in that position
        
        Instantiate(DeathObjects[0], ObjectPosition, Quaternion.identity);
    }

    private Vector3 SetObjectPosition()
    {
        Vector3 NewPosition = Vector3.zero;

        float newX = 0;
        float newY = 0;

        newX = Random.Range(-sizeX, sizeX);
        newY = Random.Range(-sizeY, sizeY);

        NewPosition = new Vector3(newX, this.transform.position.y, newY);

        return NewPosition;
    }
}
