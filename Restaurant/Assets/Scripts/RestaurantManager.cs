using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class RestaurantManager : MonoBehaviour
{
    public int money, popularity, price;
    public int food, clean, security;
    public enum StateStates
    {
        Cooked,
        Low,
        Mid,
        High,
        Splendid
    }
    public enum SecondaryStates {
        Low,
        Mid,
        High
    }
    public StateStates moneyState, popularityState, priceState;
    public SecondaryStates foodState, cleanState, securityState;

    public void SetStat(bool sum, int quantity, ref int stat)
    {
        if (sum)
        {
            stat = stat + quantity;
        }
        else
        {
            stat = stat - quantity;
        }
    }

    public void ChangeState (StateStates state, int variable)
    {
        if(variable > 0 && variable <= 3)
        {
            state = StateStates.Cooked;
        }
        else if(variable <= 6)
        {
            state = StateStates.Low;
        }
        else if (variable <= 9)
        {
            state = StateStates.Mid;
        }
        else if (variable <= 12)
        {
            state = StateStates.High;
        }
        else if (variable <= 15)
        {
            state = StateStates.High;
        }
    }

    public void ChangeState(SecondaryStates state, int variable)
    {
        if (variable > 0 && variable <= 3)
        {
            state = SecondaryStates.Low;
        }
        else if (variable <= 6)
        {
            state = SecondaryStates.Mid;
        }
        else if (variable <= 9)
        {
            state = SecondaryStates.High;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }


}
