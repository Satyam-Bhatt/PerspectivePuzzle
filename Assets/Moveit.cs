using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveit : MonoBehaviour
{
    private Vector3[] movePosition;

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
            movePosition[i] = transform.GetChild(i).transform.position;
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
            transform.position = Vector3.Lerp(transform.position, movePosition[1], 10 * Time.deltaTime);
        }

        if (Vector2.Distance(this.transform.position, movePosition[1]) < 0.1f && s1)
        {
            show[0].SetActive(true);
        }
    }
}
