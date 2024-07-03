using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Name of the scene to load
    [SerializeField]
    private string mainmenu;

    // Ensure the collider is set as a trigger in the inspector
    private void OnTriggerEnter(Collider other)
    {
        // Load the specified scene
        SceneManager.LoadScene(mainmenu);
    }
}
