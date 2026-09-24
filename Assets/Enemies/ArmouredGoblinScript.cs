using UnityEngine;

public class ArmouredGoblinScri : GoblinScript
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
        print("Armoured Orc is attacking player");
    }
}
