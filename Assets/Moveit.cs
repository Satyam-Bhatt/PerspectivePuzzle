using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveit : MonoBehaviour
{
    private Vector3[] movePosition = new Vector3[3];

    public bool s1 = false;
    public bool s2 = false;
    public bool s3 = false;

    [SerializeField] private Transform[] objectsToMove;

    [SerializeField] private GameObject[] show;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject o in show)
        {
            o.SetActive(false);
        }

        for(int i = 0; i < transform.childCount; i++)
        {
            movePosition[i] = transform.GetChild(i).position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            s1 = true;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            s2 = true;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            s3 = true;
        }

        if(s1)
        {
            objectsToMove[0].position = Vector3.Lerp(objectsToMove[0].position, movePosition[0], 10 * Time.deltaTime);
        }

        if (s2)
        {
            objectsToMove[1].position = Vector3.Lerp(objectsToMove[1].position, movePosition[1], 10 * Time.deltaTime);
        }

        if (s3)
        {
            objectsToMove[2].position = Vector3.Lerp(objectsToMove[2].position, movePosition[2], 10 * Time.deltaTime);
        }

        if (Vector2.Distance(objectsToMove[0].position, movePosition[0]) < 0.1f && s1)
        {
            show[0].SetActive(true);
            objectsToMove[0].gameObject.SetActive(false);
        }

        if (Vector2.Distance(objectsToMove[1].position, movePosition[1]) < 0.1f && s2)
        {
            show[1].SetActive(true);
            objectsToMove[1].gameObject.SetActive(false);
        }

        if (Vector2.Distance(objectsToMove[2].position, movePosition[2]) < 0.1f && s3)
        {
            show[2].SetActive(true);
            objectsToMove[2].gameObject.SetActive(false);
        }
    }
}
