using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleSceneScript : MonoBehaviour
{
    public List<GameObject> ObjectsToDither = new List<GameObject>();

    void Start()
    {
        ObjectsToDither = new List<GameObject>();
        foreach (GameObject obj in FindObjectsOfType<GameObject>())
        {
            int seeThroughLayer = LayerMask.NameToLayer("EnvironmentSeeThrough");
            if (obj.layer == seeThroughLayer)
            {
                ObjectsToDither.Add(obj);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int visibleLayer = LayerMask.NameToLayer("EnvironmentA");
            int seeThroughLayer = LayerMask.NameToLayer("EnvironmentSeeThrough");
            foreach (GameObject obj in ObjectsToDither)
            {
                if (obj.layer == seeThroughLayer)
                {
                    obj.layer = visibleLayer;
                }
                else
                {
                    obj.layer = seeThroughLayer;
                }
            }
        }
    }
}
