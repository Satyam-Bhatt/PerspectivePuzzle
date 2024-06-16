using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    [SerializeField] private Transform parent;
    [SerializeField] private Transform child;

    private float x = 0;
    private float y = 0;

    private Vector3 posiStore = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        posiStore = (child.position - parent.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (!Input.GetMouseButton(0)) return;


        this.x += Input.GetAxis("Mouse X");
        this.y += Input.GetAxis("Mouse Y");

        Quaternion rot1 = Quaternion.Euler(this.y, this.x, 0);

        this.transform.rotation = rot1;

       // Vector3 direction = Quaternion.Euler(this.y, this.x, 0) * posiStore;
        Vector3 direction = this.transform.rotation * posiStore;
        this.transform.position = direction;
    }
}
