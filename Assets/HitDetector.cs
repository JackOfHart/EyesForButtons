using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.InputSystem;

public class HitDetector : MonoBehaviour
{
    public Material Shell;
    public float colorIncrease = 5f;
    private RaycastHit hit;
    public float RayCastDistance;
    public float CircumSize = 5f;
    public GameObject Parent;
    public float PlayerSlowdown;

    // Start is called before the first frame update
    void Start()
    {
        SetColor();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("Updating");

        int maxColliders = 5;
        Collider[] hitColliders = new Collider[maxColliders];
        int numColliders = Physics.OverlapSphereNonAlloc(this.transform.position, this.GetComponent<Renderer>().bounds.size.x + CircumSize, hitColliders);
        for (int i = 0; i < numColliders; i++)
        {
            

           if(hitColliders[i].gameObject.tag == "Death")
            {
                Debug.Log("hitting death");
                ColorIncrease();
                Destroy(hitColliders[i].gameObject);
            }
            
        }
    }

    private void ColorIncrease()
    {
        Color color = Shell.color;
        if (color.a <= .99)
        {
            color.a += colorIncrease;
            Shell.color = color;

            Parent.transform.DOShakePosition(1f);
            Parent.GetComponent<StarterAssets.FirstPersonController>().MoveSpeed -= PlayerSlowdown;
        }
        

        //else wait and load next section

    }

    private void SetColor()
    {
        Color color = Shell.color;
        color.a = 0;
        Shell.color = color;
    }

}
