using UnityEngine;
using System.Collections;

public class ListManager : MonoBehaviour
{
    /// <summary>
    /// Add Instantiated object to layout group.
    /// </summary>
    public void addItem(GameObject prefab)
    {
        GameObject a = (GameObject)Instantiate(prefab);
        a.transform.SetParent(gameObject.transform, false);
    }
}
