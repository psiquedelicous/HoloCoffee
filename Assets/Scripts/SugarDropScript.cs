using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SugarDropScript : MonoBehaviour
{
    private float firstPosition;
    private bool frequency = true;
    private int timeToFrequency = 0;

    // Start is called before the first frame update
    void Start()
    {
        firstPosition = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (frequency == true)
        {
            this.transform.Translate(new Vector3(0, -.6f, 0) * Mathf.Sin(Time.deltaTime), Space.World);

            if (this.transform.position.y <= firstPosition + -1f)
            {
                Vector3 pos = this.transform.position;
                pos.y = firstPosition;

                this.transform.position = pos;
                frequency = false;
                this.GetComponent<Renderer>().enabled = false;
            }
        }
        else
        {
            timeToFrequency += 1;
            Debug.Log(timeToFrequency);
            if (timeToFrequency == 290)
            {
                frequency = true;
                this.GetComponent<Renderer>().enabled = true;
                timeToFrequency = 0;
            }
        }
        }
    }

