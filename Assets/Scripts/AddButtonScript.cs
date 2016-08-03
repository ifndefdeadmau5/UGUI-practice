using UnityEngine;
using System.Collections;

public class AddButtonScript : MonoBehaviour
{
    public GameObject prefab;
    public ListManager listManager;

    public void Add( )
    {
        listManager.addItem(prefab);
    }
}
