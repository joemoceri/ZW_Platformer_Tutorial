using System.Text;
using UnityEngine;


[CreateAssetMenu(fileName = "New Attack Data", menuName = "Data/Attack Details")]
public class PlayerAttackDetails : ScriptableObject
{
    [Header("Attack details")]
    public int attackLevel;

    public Vector3[] primaryAttackMovements;
    public Vector3[] primaryAirAttackMovement;
    public Vector3 defaultHeavyAttackMovement;
    public Vector3 defaultWeaponArtMovement;

    public float[] primaryAttackSpeeds;
    public float[] primaryAirAttackSpeeds;
    public float[] primaryAttackTimes;

    public float[] heavyAttackSpeeds;
    public float[] heavyAirAttackSpeeds;
    public float[] heavyAirAttackTimes;

    public float counterAttackDuration = .2f;
    public float weaponArtCooldown = 2f;
    public float heavyAttackCooldown = 0.5f;
    public int primaryAttackComboCeiling;

    protected StringBuilder sb = new StringBuilder();


}