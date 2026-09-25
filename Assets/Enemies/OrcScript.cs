using UnityEngine;

public class GoblinScript : EnemyScript
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        AttackPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void AttackPlayer()
    {
        variable.text = "orc is attacking player";
    }
}
