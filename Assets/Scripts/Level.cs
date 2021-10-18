using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    SceneLoader sceneloader;
    [SerializeField] int breakableBlocks;

    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void RemoveTotalBlocks()
    {
        breakableBlocks--;
        if (breakableBlocks == 0)
        {
            sceneloader.LoadNextScene();
        }
    }

}
