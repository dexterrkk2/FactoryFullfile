using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    public NPCFactory m_factory;

    private INPC m_Farmer;
    private INPC m_Beggar;
    private INPC m_Shopowner;

    public void SpawnVillager()
    {
        m_Beggar = m_factory.GetNPC(NPCTYPE.Beggar);
        m_Farmer = m_factory.GetNPC(NPCTYPE.Farmer);
        m_Shopowner = m_factory.GetNPC(NPCTYPE.ShopOwner);

        m_Beggar.Speak();
        m_Farmer.Speak();
        m_Shopowner.Speak();
    }
}
