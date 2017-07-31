using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour {

    //publics
    public int cloudCount;
    public int spawnWait;
    public int waveWait;
    public Vector2 spawnValues;

    public GameObject moln;
    public GameObject moln1;
    public GameObject moln2;
    public GameObject moln3;
    public GameObject moln4;
    public GameObject moln5;
    public GameObject[] minaMoln;
    //List<GameObject> molnList = new List<GameObject>();
    public List<GameObject> molnList;

    //privates
    int j;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnClouds());
        //minaMoln = Resources.LoadAll<GameObject>("Prefabs");
        //minaMoln = Resources.LoadAll<GameObject>("Prefabs/MM_Clouds");

        minaMoln[0] = moln1;
        minaMoln[1] = moln2;
        minaMoln[2] = moln3;
        minaMoln[3] = moln4;
        minaMoln[4] = moln5;
        /*
        molnList.Add(moln1);
        molnList.Add(moln2);
        molnList.Add(moln3);
        molnList.Add(moln4);
        molnList.Add(moln5);
       
        molnList.Insert(0, moln1);
        molnList.Insert(0, moln2);
        molnList.Insert(0, moln3);
        molnList.Insert(0, moln4);
        molnList.Insert(0, moln5);
         */
    }

    // Update is called once per frame
    void Update () {
		
	}

    IEnumerator SpawnClouds()
    {
        while(true)
        {
            for(int i = 0; i < cloudCount; i++)
            {
                j = Random.Range(0, 4);
                moln = minaMoln[j];
                //moln = molnList.
                Vector3 spawnPosition = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), -1f);
                //Instantiate(moln, spawnPosition, Quaternion.identity);
                Instantiate(moln, spawnPosition, Quaternion.identity);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
        
    }
}
