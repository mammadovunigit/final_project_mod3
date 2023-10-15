using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndRun : MonoBehaviour
{

    public GameObject distance_ach;
    public GameObject endscreen;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EndingF());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EndingF()
    {
        yield return new WaitForSeconds(2);
        distance_ach.SetActive(false);
        endscreen.SetActive(true);

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}
