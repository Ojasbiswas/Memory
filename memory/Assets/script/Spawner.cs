using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(initial());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator initial()
    {
        yield return new WaitForSeconds(1);
        GameObject inheritance = Instantiate(obj, gameObject.transform.position, Quaternion.identity);
        inheritance.transform.parent = transform;
    }
}
