using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public GameObject distanceDisplay;
    public GameObject lastdistanceDisplay;
    public float distanceRun;
    public bool addDistance = false;
 
    void Start()
    {
        
    }

    
    void Update()
    {
        if (addDistance == false)
        {
            addDistance = true;
            StartCoroutine(showDis());
        }
    }

    IEnumerator showDis()
    {
        distanceRun = distanceRun + 1;
        distanceDisplay.GetComponent<Text>().text = "" + distanceRun;
        yield return new WaitForSeconds(0.35f);

        lastdistanceDisplay.GetComponent<Text>().text = "" + distanceRun;
        addDistance = false;
    }
}
