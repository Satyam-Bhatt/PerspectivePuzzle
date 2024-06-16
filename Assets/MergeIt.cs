using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MergeIt : MonoBehaviour
{
    [SerializeField] private GameObject text;
    [SerializeField] private GameObject disappearBlock;

    private void Start()
    {
        text.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            disappearBlock.SetActive(false);
            StartCoroutine(showText());
        }
    }

    IEnumerator showText()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        text.SetActive(false);
    }
}
