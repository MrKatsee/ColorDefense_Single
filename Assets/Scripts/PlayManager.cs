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
