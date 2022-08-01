using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 游戏管理
/// </summary>

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [HideInInspector]
    //玩家数据
    public int money;
    [HideInInspector]
    public int unlockedLevel;
    public int selectLevel;
    public int gunLevel;
    public Player player;

    //系统设置
    public float volume;
    public float joystickSize;


    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void LoadGame()
    {
        if (PlayerPrefs.HasKey("Money"))
        {
            money = PlayerPrefs.GetInt("Money");
        }
        else
        {
            money = 0;
        }
        if (PlayerPrefs.HasKey("Levels"))
        {
            unlockedLevel = PlayerPrefs.GetInt("Levels");
        }
        else
        {
            unlockedLevel = 1;
        }
        if (PlayerPrefs.HasKey("Sound"))
        {
            volume = PlayerPrefs.GetFloat("Sound");
        }
        else
        {
            volume = 1;
        }
        if (PlayerPrefs.HasKey("Joystick"))
        {
            joystickSize = PlayerPrefs.GetFloat("Joystick");
        }
        else
        {
            joystickSize = 0.3f;
        }
        selectLevel = 1;
    }
    
    
}
