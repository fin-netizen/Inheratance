using UnityEngine;

public class FriendlyGoblinScript : GoblinScript
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
        print("Friendly orc is attacking player");
    }
}
