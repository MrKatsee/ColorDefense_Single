using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    public static PlayManager Instance { get; private set; } = null;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        GameObject.Find("DropBox").GetComponent<DropBox>().Init_DropBox();
    }

    public GameObject player;

    public PlayerControl GetControl()
    {
        return player.GetComponent<PlayerControl>();
    }

    public PlayerData GetData()
    {
        return player.GetComponent<PlayerData>();
    }

    
}
