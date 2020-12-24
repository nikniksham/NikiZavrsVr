using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] GameObject player;
    [SerializeField] Camera camera;

    public void summon() {        
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(camera.transform.forward);
        if (Physics.Raycast(ray, out hit)) { Instantiate(prefab, new Vector3(hit.transform.position.x, hit.transform.position.y + 3, hit.transform.position.z), prefab.transform.rotation);}}
}
