using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int xPos = 1000;
    public bool creatingSection = false;
    public int secNum;

    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false) 
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(xPos, 0, 0), Quaternion.identity);
        xPos += 1000;
        yield return new WaitForSeconds(10);
        creatingSection = false;
    }
}
