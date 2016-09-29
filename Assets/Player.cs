using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public GameObject spawnPointsParent;
    public bool respawn = false;

    // Use this for initialization
    void Start() {
        ReSpawn();//start at random spawn point
    }

    // Update is called once per frame
    void Update() {
        if (respawn) {
            ReSpawn();
            respawn = false;
        }
    }

    void ReSpawn() {
        int index = (int)Random.Range(0, spawnPointsParent.transform.childCount);
        Transform spawnPoint = spawnPointsParent.transform.GetChild(index);

        transform.position = spawnPoint.position;
        transform.rotation = spawnPoint.rotation;
    }
}
