using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreateCharacter : MonoBehaviour
{
    [SerializeField] private GameObject character;

    public void Create()
    {
        Scene sceneToLoad = SceneManager.GetSceneByName("Ship");
        SceneManager.LoadScene(sceneToLoad.name, LoadSceneMode.Additive);
        SceneManager.MoveGameObjectToScene(character, sceneToLoad);

    }
}
