using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnControl : MonoBehaviour
{

    public GameObject[] spawnPoints;
    public GameObject _Spawner;
    public List<GameObject> Spawned = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        int num = Random.Range(10, 20);
        Debug.Log(num);
        for (int i = 0; i <= num; i++)
        {
            int random = Random.Range(1, 8);
            if (random <= 2)
            {
                Instantiate(_Spawner, new Vector3(Random.Range(spawnPoints[0].transform.position.x, spawnPoints[1].transform.position.x), 8), Quaternion.identity);
                Spawned.Add(_Spawner);
            }
            else if (random > 2 && random <= 4)
            {
                Instantiate(_Spawner, new Vector3(14, Random.Range(spawnPoints[2].transform.position.y, spawnPoints[1].transform.position.y)), Quaternion.identity);
                Spawned.Add(_Spawner);
            }
            else if (random > 4 && random <= 6)
            {
                Instantiate(_Spawner, new Vector3(Random.Range(spawnPoints[3].transform.position.x, spawnPoints[2].transform.position.x), -8), Quaternion.identity);
                Spawned.Add(_Spawner);
            }
            else if (random > 6 && random <= 8)
            {
                Instantiate(_Spawner, new Vector3(-14, Random.Range(spawnPoints[3].transform.position.y, spawnPoints[0].transform.position.y)), Quaternion.identity);
                Spawned.Add(_Spawner);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
