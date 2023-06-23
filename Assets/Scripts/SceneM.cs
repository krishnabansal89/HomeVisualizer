using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneM : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public GameObject Canva1;
    public void MoveToScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
}
