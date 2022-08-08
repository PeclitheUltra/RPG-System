using System.Collections.Generic;
using UnityEngine;

public class BuffTarget
{
    private Stats _stats;
    private List<Buff> _buffs;

    public BuffTarget(Stats stats)
    {
        _buffs = new List<Buff>();
        _stats = stats;
    }

    public void ApplyBuff(Buff buff)
    {
        _buffs.Add(buff);
        buff.ApplyBuff(_stats, () => 
        { 
            _buffs.Remove(buff); 
            Debug.Log("Removed"); 
        });
    }


}
