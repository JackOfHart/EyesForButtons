using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SkyboxManager : MonoBehaviour
{
    public Material SkyboxColors;
    public Color TopColor1;
    public Color TopColor2;

    public Color BottomColor1;
    public Color BottomColor2;

    public float ColorChangeSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SkyboxColors.GetColor("_Top"));
        Debug.Log(SkyboxColors.GetColor("_Bottom"));

        ColorLoop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ColorLoop()
    {
        Sequence mySequence = DOTween.Sequence();
        mySequence.SetLoops(-1, LoopType.Yoyo);
        mySequence.Append(SkyboxColors.DOColor(TopColor1,"_Top",ColorChangeSpeed));
        mySequence.Append(SkyboxColors.DOColor(TopColor2, "_Top", ColorChangeSpeed));

        mySequence.Append(SkyboxColors.DOColor(BottomColor1, "_Bottom", ColorChangeSpeed));
        mySequence.Append(SkyboxColors.DOColor(BottomColor2, "_Bottom", ColorChangeSpeed));

    }
}
