using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantFlySpeed : MonoBehaviour
{
    public Vector3 Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        this.transform.position += Speed * Time.deltaTime;
    }
}
