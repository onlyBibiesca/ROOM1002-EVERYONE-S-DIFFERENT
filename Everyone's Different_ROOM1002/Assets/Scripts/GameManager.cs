using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Objects")]
    public GameObject doorHouse;

    private void Start()
    {
        doorHouse.SetActive(false);
    }
}
