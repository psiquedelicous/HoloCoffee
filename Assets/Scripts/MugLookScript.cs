using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugLookScript : MonoBehaviour
{

    public Texture2D LookingLeft;
    public Texture2D LookingRight;
    public Material MugLookMaterial;
    public Transform Reference1;
    public Transform Reference2;

    // Start is called before the first frame update
    void Start()
    {
        OriginalPosition = this.transform.position;
    }

    private Vector3 OriginalPosition;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = OriginalPosition + Vector3.up * .3f * Mathf.Sin(Time.realtimeSinceStartup * 2.0f);
        //Debug.Log();

        if (Vector3.SignedAngle(-Reference1.forward, Reference2.forward, Vector3.up) > 0) {
            MugLookMaterial.SetTexture("_MainTex", LookingLeft);
        }
        else
        {
            MugLookMaterial.SetTexture("_MainTex", LookingRight);
        }
    }
}
