using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCFactory : MonoBehaviour
{
    public INPC GetNPC(NPCTYPE type)
    {
        switch (type)
        {
            case NPCTYPE.Beggar:
                INPC beggar = new Beggar();
                return beggar;
            case NPCTYPE.Farmer:
                INPC farmer = new Farmer();
                return farmer;
            case NPCTYPE.ShopOwner:
                INPC shopOwner = new ShopOwner();
                return shopOwner;
        }
        return null;
    }
}
