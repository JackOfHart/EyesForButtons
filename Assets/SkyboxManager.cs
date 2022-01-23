using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxManager : MonoBehaviour
{
    public Material SkyboxColors;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SkyboxColors.GetColor("_Top"));
        Debug.Log(SkyboxColors.GetColor("_Bottom"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
