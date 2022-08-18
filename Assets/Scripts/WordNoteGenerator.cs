using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordNoteGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("aaaa");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) OnClick();
        var speed = 1*Time.time;
        //transform.Translate(0,speed,0);
        transform.localScale = new Vector3 (speed,speed,speed);
    }

    void OnClick()
    {
        if(InTimeRange(3, 250, Time.time))
        Debug.Log("bbbbb");
        Destroy(gameObject);
    }

    bool InTimeRange(float targetTime, float forwardRange, float resultTime, float? backwardRange=null)
    {
        if(backwardRange==null) backwardRange = forwardRange;
        if(targetTime-forwardRange <= resultTime && resultTime <= targetTime+backwardRange) return true;
        else return false;
    }
}
