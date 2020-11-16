using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("太空人")]
    public Transform astro;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("移動速度")]
    public float move = 0.01f;
    [Header("旋轉速度")]
    public float turn = 3f;
    [Header("太空人動畫")]
    public Animator aniastro;

    private void Start()
    {
        print("開始事件");
    }
    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);
        astro.Rotate(0, joystick.Horizontal*turn, 0);
        astro.Translate(0,joystick.Vertical*move,0);
        astro.transform.position = new Vector3(0,Mathf.Clamp(astro.transform.position.y,0.1f,20f),0);

    }
    public void Playanimation(string aniName)
    {
        aniastro.SetTrigger(aniName);
        aniastro.SetBool(aniName, true);
    }
}