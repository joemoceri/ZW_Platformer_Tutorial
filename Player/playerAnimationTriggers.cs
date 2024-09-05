using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationTriggers : MonoBehaviour
{
    //This is shorthand to grab the component
    [SerializeField]
    private Player player => GetComponentInParent<Player>();

    public void AnimationTrigger()
    {
        player.AnimationTrigger();
    }

    private void AttackTrigger()
    {
        /* //We will capture all colliders in one frame that are within the sphere
         Collider[] colliders = Physics.OverlapSphere(player.attackCheck.position, player.attackCheckRadius);

         foreach (var hit in colliders)
         {
             if ((hit.GetComponent<Enemy>() != null))
             {
                 EnemyStats _target = hit.GetComponent<EnemyStats>();

                 if (_target != null)
                 {
                     player.stats.DoDamage(_target);
                 }

                 ItemData_Equipment weaponData = Inventory.instance.GetEquipment(EquipmentType.Weapon);

                 if (weaponData != null)
                     weaponData.Effect(_target.transform);
             }
         }*/
        Debug.Log("Trying to throw an attack!!!");
    }
}