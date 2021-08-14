using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacement : MonoBehaviour
{
    public HeightMapSettings heightMapSettings;
    public MeshSettings meshSettings;
    public GameObject obj;
    void Start(){
        
        StartCoroutine("delayedExec");
        //Debug.Log(heightMap.values[heightMap.maxValueX,heightMap.maxValueZ] + ": "+ heightMap.values[13,2]);
    }

    IEnumerator delayedExec(){
        yield return new WaitForSeconds(2);
        HeightMap heightMap = HeightMapGenerator.GenerateHeightMap(meshSettings.numVertsPerLine, meshSettings.numVertsPerLine,heightMapSettings, Vector2.zero);
        float x = heightMap.values[heightMap.maxValueX,heightMap.maxValueZ];
        float z = heightMap.values[heightMap.maxValueX,heightMap.maxValueZ];
        //Debug.Log(LODMesh.maxHeight);
        obj.transform.position = new Vector3(x,LODMesh.maxHeight,z);
    }
}
