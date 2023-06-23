using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    private Button btn;
    [SerializeField] public GameObject furniture;
    [SerializeField] public GameObject Canva1;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(SelectObject);
    }
    void SelectObject()
    {
        DataHandler.Instance.furniture = furniture;
        Canva1.SetActive(false);

    }


}
