using UnityEngine;
using System.Collections;

public class AssetLoader : MonoBehaviour
{
    IEnumerator Start ()
    {
        while (true) {
            var prefab = Resources.Load ("Cube");
            var go = Instantiate (prefab) as GameObject;

            yield return new WaitForSeconds (0.3f);
            Object.Destroy (go);

            prefab = null;
            go = null;

            yield return Resources.UnloadUnusedAssets ();
            yield return new WaitForSeconds (0.2f);
        }
    }
}