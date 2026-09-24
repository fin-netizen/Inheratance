using UnityEngine;

public class ElfScript : EnemyScript
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AttackPlayer();
        base.AttackPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void AttackPlayer()
    {
        print("Dragon is attacking player");
    }
}
