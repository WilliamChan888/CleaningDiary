using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //资源
    public GameObject blood; //血迹
    public GameObject bloodParticle;//溅血特效
    public AudioClip bonus;//奖励音效

    //数据
    public bool isMoving;
    public float moveAngle;
    public int speed;
    public int maxHP;
    public float HP;
    public int regenHpSpeed;
    public int delayRegen;//受到伤害再次回复血量的延迟时间
    public float delayTimer;//可回复血量计时器 

    //引用
    private Rigidbody2D playRig;
    private AudioSource audioSource;

    private void Awake()
    {
        GameManager.Instance.player = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
