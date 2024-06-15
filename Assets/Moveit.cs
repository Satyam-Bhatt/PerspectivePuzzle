using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveit : MonoBehaviour
{
    private bool isMoving = false;
    private Vector3 movePosition = Vector3.zero;

    public bool s1 = false;
    public bool s2 = false;
    public bool s3 = false;

    [SerializeField] private GameObject show1;

    // Start is called before the first frame update
    void Start()
    {
        show1.SetActive(false);
        Transform child = gameObject.transform.GetChild(0);
        movePosition = child.position;
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
            transform.position = Vector3.Lerp(transform.position, movePosition, 10 * Time.deltaTime);
        }

        if (Vector2.Distance(this.transform.position, movePosition) < 0.1f && s1)
        {
            show1.SetActive(true);
        }
    }
}
