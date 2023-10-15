using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnv : MonoBehaviour
{
    public string envName;

    // Start is called before the first frame update
    void Start()
    {
        envName = transform.name;
        StartCoroutine(DeleteClone());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DeleteClone()
    {
        yield return new WaitForSeconds(35);

        if (envName == "env(Clone)")
        {
            Destroy(gameObject);
        }
    }
}

